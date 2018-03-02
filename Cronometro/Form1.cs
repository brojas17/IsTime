using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WMPLib;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region CargarInicial
        //Datos
        Boolean showDatos = false;
        //int vIni_Id, VIni_Segundos;
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        
        //varibles para almacenar datos xml
        int codigo = 1; int tiempoTrabSeg = 0; DateTime fechaActual = DateTime.Today.Date;
        //variables play del sistema
        DateTime today = DateTime.Today;
        int _tehora, _temin, _teseg, _tdhora, _tdmin, _tdseg, varNumRepite;
        DateTime teGeneral, tdGeneral;
        string Estado = "te";//te=tiempo de estudio //td=tiempo de descanso
        string btnControlGeneral = "sin_iniciar";

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearXML(codigo, tiempoTrabSeg, fechaActual);
        }
        #endregion

        #region Objetos
        private void btnPlayTimbre_Click(object sender, EventArgs e)
        {
            //wplayer.URL = lblTimbreRuta.Text;
            wplayer.controls.play();
        }

        private void btnPauseTimbre_Click(object sender, EventArgs e)
        {
            //wplayer.URL = lblTimbreRuta.Text;
            wplayer.controls.pause();
        }

        private void btnStopTimbre_Click(object sender, EventArgs e)
        {
            //wplayer.URL = lblTimbreRuta.Text;
            wplayer.controls.stop();
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked == true) { gbManual.Enabled = true; } else { gbManual.Enabled = false; }
        }

        private void rbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked == true) { gbManual.Enabled = true; } else { gbManual.Enabled = false; }
        }

        private void btnTimbre_Click(object sender, EventArgs e)
        {
            lblTimbreRuta.Text = "Ruta del Archivo";
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            openFileDialog1.Title = "Select a Cursor File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assign the cursor in the Stream to the Form's Cursor property.
                //this.Cursor = new Cursor(openFileDialog1.OpenFile());
                lblTimbreRuta.Text = openFileDialog1.FileName;
            }
            wplayer.URL = lblTimbreRuta.Text;
            wplayer.controls.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numRepite.Value > 0)
            {
                if (Estado == "te")
                {
                    if (teSegundo.Value > 0)
                    {
                        teSegundo.Value -= 1;
                    }
                    else if (teMinuto.Value > 0)
                    {
                        teMinuto.Value -= 1;
                        teSegundo.Value = 59;
                    }
                    else if (teHora.Value > 0)
                    {
                        teHora.Value -= 1;
                        teMinuto.Value = 59;
                        teSegundo.Value = 59;
                    }
                    else
                    {
                        //tiempoTrabSeg = (_tehora * 60 * 60) + (_temin * 60) + _teseg;
                        tiempoTrabSeg += (_tehora * 60 * 60) + (_temin * 60) + _teseg;
                        //------------------------
                        fechaActual = DateTime.Today.Date;
                        Estado = "td";
                        ActualizarXML(fechaActual, tiempoTrabSeg);
                        //------------------------
                        wplayer.controls.play();
                        teSegundo.Value = _teseg;
                        teMinuto.Value = _temin;
                        teHora.Value = _tehora;
                    }
                }
                else if (Estado == "td")
                {
                    if (tdSegundo.Value > 0)
                    {
                        tdSegundo.Value -= 1;
                    }
                    else if (tdMinuto.Value > 0)
                    {
                        tdMinuto.Value -= 1;
                        tdSegundo.Value = 59;
                    }
                    else if (tdHora.Value > 0)
                    {
                        tdHora.Value -= 1;
                        tdMinuto.Value = 59;
                        tdSegundo.Value = 59;
                    }
                    else
                    {
                        Estado = "te";
                        wplayer.controls.play();
                        tdSegundo.Value = _tdseg;
                        tdMinuto.Value = _tdmin;
                        tdHora.Value = _tdhora;
                        if (numRepite.Value > 0) { numRepite.Value -= 1; }
                    }
                }
            }
            else
            {
                numRepite.Value = varNumRepite;
                teHora.Value = _tehora;
                teMinuto.Value = _temin;
                teSegundo.Value = _teseg;

                tdHora.Value = _tdhora;
                tdMinuto.Value = _tdmin;
                tdSegundo.Value = _tdseg;
                btnControlGeneral = "sin_iniciar";
                btnPlay.Enabled = true;
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                Estado = "te";
                timer1.Stop();
                EstadoDatos(0);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //if (btnPause.Enabled == false) { btnControlGeneral = "play"; } else { btnControlGeneral = "pause"; }
            if (btnControlGeneral == "sin_iniciar")
            {
                if (gbManual.Enabled == true && numRepite.Value <= 0) { MessageBox.Show("La cantidad de veces que se repita debe ser mayor a cero"); }
                else
                {
                    EstadoDatos(1);
                    _tehora = Convert.ToInt32(teHora.Value);
                    _temin = Convert.ToInt32(teMinuto.Value);
                    _teseg = Convert.ToInt32(teSegundo.Value);
                    teGeneral = new DateTime(today.Year, today.Month, today.Day, _tehora, _temin, _teseg);
                    _tdhora = Convert.ToInt32(tdHora.Value);
                    _tdmin = Convert.ToInt32(tdMinuto.Value);
                    _tdseg = Convert.ToInt32(tdSegundo.Value);
                    tdGeneral = new DateTime(today.Year, today.Month, today.Day, _tdhora, _tdmin, _tdseg);

                    
                    btnPlay.Enabled = false;
                    btnPause.Enabled = true;
                    btnStop.Enabled = true;
                    if (rbAutomatico.Checked == true) { varNumRepite = 100; numRepite.Value = varNumRepite; } else { varNumRepite = Convert.ToInt32(numRepite.Value); }
                    timer1.Start();
                }
                btnControlGeneral = "iniciado";
            }
            else if (btnControlGeneral == "iniciado")
            {
                timer1.Start();
                btnPlay.Enabled = false;
                btnPause.Enabled = true;
                btnControlGeneral = "iniciado";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
            timer1.Stop();
            btnControlGeneral = "iniciado";
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            //Cargar BD
            if (Estado == "te" && btnControlGeneral == "iniciado") 
            { 
                tiempoTrabSeg = tiempoTrabSeg + (((_tehora - Convert.ToInt32(teHora.Value)) * 60 * 60) + ((_temin - Convert.ToInt32(teMinuto.Value)) * 60) + (_teseg - Convert.ToInt32(teSegundo.Value)));
                fechaActual = DateTime.Today.Date;
                ActualizarXML(fechaActual, tiempoTrabSeg);
            }
            //-----------------
            //-----------------
            numRepite.Value = varNumRepite;
            teHora.Value = _tehora;
            teMinuto.Value = _temin;
            teSegundo.Value = _teseg;

            tdHora.Value = _tdhora;
            tdMinuto.Value = _tdmin;
            tdSegundo.Value = _tdseg;
            btnControlGeneral = "sin_iniciar";
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            Estado = "te";
            timer1.Stop();
            EstadoDatos(0);
        }
        #endregion

        #region Eventos
        private void teHora_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }
        private void teMinuto_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }

        private void teSegundo_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }

        private void tdHora_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }

        private void tdMinuto_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }

        private void tdSegundo_ValueChanged(object sender, EventArgs e)
        {
            if (ConfirmarHoraProgramada() == 1) { gbControles.Enabled = true; } else { gbControles.Enabled = false; }
        }
        #endregion

        #region Funciones
        int ConfirmarHoraProgramada() 
        {
            int retVal = 0;
            if (teHora.Value > 0 || teMinuto.Value > 0 || teSegundo.Value > 0) { retVal = 1; } else { retVal = 0; }
            if (tdHora.Value > 0 || tdMinuto.Value > 0 || tdSegundo.Value > 0 || retVal>0) { retVal = 1; } else { retVal = 0; }
            return retVal;
        }
        void EstadoDatos(int bloqueo)
        {
            if (bloqueo == 1)
            {
                teHora.Enabled = false;
                teMinuto.Enabled = false;
                teSegundo.Enabled = false;
                tdHora.Enabled = false;
                tdMinuto.Enabled = false;
                tdSegundo.Enabled = false;

                gbRutina.Enabled = false;
                gbManual.Enabled = false;
                btnTimbre.Enabled = false;
            }
            else if (bloqueo == 0)
            {
                teHora.Enabled = true;
                teMinuto.Enabled = true;
                teSegundo.Enabled = true;
                tdHora.Enabled = true;
                tdMinuto.Enabled = true;
                tdSegundo.Enabled = true;

                gbRutina.Enabled = true;
                gbManual.Enabled = true;
                btnTimbre.Enabled = true;
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Estado == "te" && btnControlGeneral == "iniciado")
            {
                tiempoTrabSeg = tiempoTrabSeg + (((_tehora - Convert.ToInt32(teHora.Value)) * 60 * 60) + ((_temin - Convert.ToInt32(teMinuto.Value)) * 60) + (_teseg - Convert.ToInt32(teSegundo.Value)));
                fechaActual = DateTime.Today.Date;
                ActualizarXML(fechaActual, tiempoTrabSeg);
            }
        }

        void Guardar_Tiempo_Seg() 
        {
            fechaActual = DateTime.Today.Date;
            XmlWriter w = null;
            if (File.Exists("DBTiempo.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("DBTiempo.xml");
                string fila = (Convert.ToString(DateTime.Today.Day) + Convert.ToString(DateTime.Today.Month) + Convert.ToString(DateTime.Today.Year));
                doc.SelectSingleNode("//a" + fila).Attributes["segundos"].InnerText = doc.SelectSingleNode("//a" + fila).Attributes["segundos"].Value + tiempoTrabSeg;
                doc.Save("DBTiempo.xml");
            } 
            else 
            { 
                w = XmlWriter.Create("DBTiempo.xml");
                string fila = (Convert.ToString(DateTime.Today.Day) + Convert.ToString(DateTime.Today.Month) + Convert.ToString(DateTime.Today.Year));
                w.WriteStartElement("a" + fila);
                w.WriteElementString("segundos", tiempoTrabSeg.ToString());
                w.WriteElementString("fecha", fechaActual.ToShortDateString());
                w.WriteEndElement();
                w.Close();
            }
        }
        void Guardar_Tiempo_Seg2() 
        {
            fechaActual = DateTime.Today.Date;
            if (!(File.Exists("DBTiempo.xml"))) 
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Creating an XML Tree using LINQ to XML"),
                    new XElement("Tiempos",
                        new XElement("Tiempo", new XAttribute("Id", 1),
                            new XElement("tiempoSeg", tiempoTrabSeg.ToString()),
                            new XElement("fecha", fechaActual.ToString()))));
                xmlDocument.Save("DBTiempo.xml");
            }
        }
        void BuscarUltimaFecha() 
        {
            DateTime fecha = DateTime.Today.Date;
            XElement root = XElement.Load("DBTiempo.xml");
            IEnumerable<XElement> Tiempos =
                from el in root.Elements("Tiempo")
                where (string)el.Element("fecha") == fecha.ToString("dd-mm-yyyy")
                select el;
            foreach (XElement el in Tiempos)
            {
                //vIni_Id = ((int)el.Attribute("Id"));
                //VIni_Segundos = ((int)el.Attribute("tiempoSeg"));
            }
        }

        void CrearXML(int _codigo, int _tiempoTrabSeg, DateTime _fechaActual)
        {
            if (!(File.Exists("DBTiempo.xml")))
            {
                XDocument xmlDocument = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("Creating an XML Tree using LINQ to XML"),
                    new XElement("Tiempos", 
                        new XElement("Tiempo", new XAttribute("codigo", _codigo),
                            new XElement("tiempoSeg", _tiempoTrabSeg),
                            new XElement("fecha", _fechaActual.ToString("dd-MM-yyyy")))));
                xmlDocument.Save("DBTiempo.xml");
            }
            else
            {
                Boolean estExistReg = false;
                XElement docXML = XElement.Load("DBTiempo.xml");
                IEnumerable<XElement> Tiempos =
                    from consulta in docXML.Elements("Tiempo")
                    where (string)consulta.Element("fecha") == _fechaActual.ToString("dd-MM-yyyy")
                    select consulta;
                foreach (XElement consulta in Tiempos)
                {
                    estExistReg = true;
                    codigo = (int)consulta.Attribute("codigo");
                    tiempoTrabSeg = (int)consulta.Element("tiempoSeg");
                    fechaActual = Convert.ToDateTime((string)consulta.Element("fecha"));
                }
                if (estExistReg == false) 
                {
                    //---------------------------------------------
                    XElement ultimodoc = XElement.Load("DBTiempo.xml");
                    int maxNr = ultimodoc.Descendants("Tiempo")
                        .Max(x => (int)x.Attribute("codigo"));
                    //---------------------------------------------
                    XElement newDocXML = XElement.Load("DBTiempo.xml");
                    
                    XElement newTiempo = new XElement("Tiempo", new XAttribute("codigo", (maxNr + 1)),
                        new XElement("tiempoSeg", _tiempoTrabSeg),
                        new XElement("fecha", _fechaActual.ToString("dd-MM-yyyy")));

                    newDocXML.Add(newTiempo);
                    newDocXML.Save("DBTiempo.xml");
                    //---------------------------------------------
                    codigo = maxNr + 1;
                    tiempoTrabSeg = _tiempoTrabSeg;
                    fechaActual = _fechaActual;
                }
            }
        }

        void ActualizarXML(DateTime _fechaActual, int _tiempoTrabSeg) 
        {
            Boolean estExistReg = false;
            XElement docXML = XElement.Load("DBTiempo.xml");
            IEnumerable<XElement> Tiempos =
                from consulta in docXML.Elements("Tiempo")
                where (string)consulta.Element("fecha") == _fechaActual.ToString("dd-MM-yyyy")
                select consulta;
            foreach (XElement consulta in Tiempos)
            {
                estExistReg = true;
                codigo = (int)consulta.Attribute("codigo");
               
                    XDocument doc1 = XDocument.Load("DBTiempo.xml");
                    doc1.Element("Tiempos")
                        .Elements("Tiempo")
                        .Where(x=>x.Attribute("codigo").Value==Convert.ToString(codigo)).FirstOrDefault()
                        .SetElementValue("tiempoSeg", _tiempoTrabSeg);
                    //--------------------------------------------------
                    doc1.Save("DBTiempo.xml");
            }
            if (estExistReg == false)
            {
                XElement ultimodoc = XElement.Load("DBTiempo.xml");
                int maxNr = ultimodoc.Descendants("Tiempo")
                    .Max(x => (int)x.Attribute("codigo"));
                //---------------------------------------------
                XElement newDocXML = XElement.Load("DBTiempo.xml");
                //---------tiempo solo debe ser el programado
                tiempoTrabSeg=((_tehora * 60 * 60) + (_temin * 60) + _teseg);
                //---------------------------------------------
                if (Estado == "te" && btnControlGeneral == "iniciado")
                {
                    tiempoTrabSeg = (((_tehora - Convert.ToInt32(teHora.Value)) * 60 * 60) + ((_temin - Convert.ToInt32(teMinuto.Value)) * 60) + (_teseg - Convert.ToInt32(teSegundo.Value)));
                }
                //---------------------------------------------
                XElement newTiempo = new XElement("Tiempo", new XAttribute("codigo", (maxNr + 1)),
                    new XElement("tiempoSeg", tiempoTrabSeg),
                    new XElement("fecha", _fechaActual.ToString("dd-MM-yyyy")));

                newDocXML.Add(newTiempo);
                newDocXML.Save("DBTiempo.xml");
                //---------------------------------------------
                codigo = maxNr + 1;
                fechaActual = _fechaActual;
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (showDatos == false)
            {
                this.MinimumSize = new Size(0, 0);
                this.MaximumSize = new Size(0, 0);
                DataSet dataSet = new DataSet();
                dataSet.ReadXml("DBTiempo.xml", XmlReadMode.InferSchema);
                dgvTiempos.DataSource = dataSet.Tables[0];
                //------------------------
                //Point newSize=new Point(925, 301);
                this.Size = new Size(925, 301);
                btnShowData.Image = global::Cronometro.Properties.Resources.left;
                showDatos = true;
                this.MinimumSize = new Size(925, 301);
                this.MaximumSize = new Size(925, 301);
            }
            else 
            {
                this.MinimumSize = new Size(0, 0);
                this.MaximumSize = new Size(0, 0);
                dgvTiempos.DataSource = null;
                this.Size = new Size(581, 301);
                btnShowData.Image = global::Cronometro.Properties.Resources.right;
                showDatos = false;
                this.MinimumSize = new Size(581, 301);
                this.MaximumSize = new Size(581, 301);
            }
        }

        private void dgvTiempos_DoubleClick(object sender, EventArgs e)
        {
            dgvTiempos.DataSource = null;
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("DBTiempo.xml", XmlReadMode.InferSchema);
            dgvTiempos.DataSource = dataSet.Tables[0];
        }
    }
}
