namespace Cronometro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teHora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teMinuto = new System.Windows.Forms.NumericUpDown();
            this.teSegundo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tdSegundo = new System.Windows.Forms.NumericUpDown();
            this.tdMinuto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tdHora = new System.Windows.Forms.NumericUpDown();
            this.lblTimbreRuta = new System.Windows.Forms.Label();
            this.btnTimbre = new System.Windows.Forms.Button();
            this.gbRutina = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAutomatico = new System.Windows.Forms.RadioButton();
            this.gbManual = new System.Windows.Forms.GroupBox();
            this.numRepite = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.gbControlTimbre = new System.Windows.Forms.GroupBox();
            this.dgvTiempos = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnStopTimbre = new System.Windows.Forms.Button();
            this.btnPauseTimbre = new System.Windows.Forms.Button();
            this.btnPlayTimbre = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdHora)).BeginInit();
            this.gbRutina.SuspendLayout();
            this.gbManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepite)).BeginInit();
            this.gbControles.SuspendLayout();
            this.gbControlTimbre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teHora
            // 
            this.teHora.Location = new System.Drawing.Point(124, 50);
            this.teHora.Name = "teHora";
            this.teHora.Size = new System.Drawing.Size(48, 20);
            this.teHora.TabIndex = 2;
            this.teHora.ValueChanged += new System.EventHandler(this.teHora_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurar Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo Estudio:";
            // 
            // teMinuto
            // 
            this.teMinuto.Location = new System.Drawing.Point(192, 50);
            this.teMinuto.Name = "teMinuto";
            this.teMinuto.Size = new System.Drawing.Size(48, 20);
            this.teMinuto.TabIndex = 4;
            this.teMinuto.ValueChanged += new System.EventHandler(this.teMinuto_ValueChanged);
            // 
            // teSegundo
            // 
            this.teSegundo.Location = new System.Drawing.Point(260, 50);
            this.teSegundo.Name = "teSegundo";
            this.teSegundo.Size = new System.Drawing.Size(48, 20);
            this.teSegundo.TabIndex = 6;
            this.teSegundo.ValueChanged += new System.EventHandler(this.teSegundo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // tdSegundo
            // 
            this.tdSegundo.Location = new System.Drawing.Point(260, 90);
            this.tdSegundo.Name = "tdSegundo";
            this.tdSegundo.Size = new System.Drawing.Size(48, 20);
            this.tdSegundo.TabIndex = 12;
            this.tdSegundo.ValueChanged += new System.EventHandler(this.tdSegundo_ValueChanged);
            // 
            // tdMinuto
            // 
            this.tdMinuto.Location = new System.Drawing.Point(192, 90);
            this.tdMinuto.Name = "tdMinuto";
            this.tdMinuto.Size = new System.Drawing.Size(48, 20);
            this.tdMinuto.TabIndex = 10;
            this.tdMinuto.ValueChanged += new System.EventHandler(this.tdMinuto_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiempo Descanso:";
            // 
            // tdHora
            // 
            this.tdHora.Location = new System.Drawing.Point(124, 90);
            this.tdHora.Name = "tdHora";
            this.tdHora.Size = new System.Drawing.Size(48, 20);
            this.tdHora.TabIndex = 8;
            this.tdHora.ValueChanged += new System.EventHandler(this.tdHora_ValueChanged);
            // 
            // lblTimbreRuta
            // 
            this.lblTimbreRuta.AutoSize = true;
            this.lblTimbreRuta.Location = new System.Drawing.Point(154, 144);
            this.lblTimbreRuta.Name = "lblTimbreRuta";
            this.lblTimbreRuta.Size = new System.Drawing.Size(86, 13);
            this.lblTimbreRuta.TabIndex = 16;
            this.lblTimbreRuta.Text = "Ruta del Archivo";
            // 
            // btnTimbre
            // 
            this.btnTimbre.Location = new System.Drawing.Point(25, 139);
            this.btnTimbre.Name = "btnTimbre";
            this.btnTimbre.Size = new System.Drawing.Size(109, 23);
            this.btnTimbre.TabIndex = 15;
            this.btnTimbre.Text = "Escoger Timbre";
            this.btnTimbre.UseVisualStyleBackColor = true;
            this.btnTimbre.Click += new System.EventHandler(this.btnTimbre_Click);
            // 
            // gbRutina
            // 
            this.gbRutina.Controls.Add(this.rbManual);
            this.gbRutina.Controls.Add(this.rbAutomatico);
            this.gbRutina.Location = new System.Drawing.Point(333, 35);
            this.gbRutina.Name = "gbRutina";
            this.gbRutina.Size = new System.Drawing.Size(201, 46);
            this.gbRutina.TabIndex = 13;
            this.gbRutina.TabStop = false;
            this.gbRutina.Text = "Rutina";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(127, 20);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbAutomatico
            // 
            this.rbAutomatico.AutoSize = true;
            this.rbAutomatico.Checked = true;
            this.rbAutomatico.Location = new System.Drawing.Point(23, 20);
            this.rbAutomatico.Name = "rbAutomatico";
            this.rbAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbAutomatico.TabIndex = 0;
            this.rbAutomatico.TabStop = true;
            this.rbAutomatico.Text = "Automatico";
            this.rbAutomatico.UseVisualStyleBackColor = true;
            this.rbAutomatico.CheckedChanged += new System.EventHandler(this.rbAutomatico_CheckedChanged);
            // 
            // gbManual
            // 
            this.gbManual.Controls.Add(this.numRepite);
            this.gbManual.Controls.Add(this.label9);
            this.gbManual.Enabled = false;
            this.gbManual.Location = new System.Drawing.Point(333, 87);
            this.gbManual.Name = "gbManual";
            this.gbManual.Size = new System.Drawing.Size(201, 46);
            this.gbManual.TabIndex = 14;
            this.gbManual.TabStop = false;
            this.gbManual.Text = "Configurar Manual";
            // 
            // numRepite
            // 
            this.numRepite.Location = new System.Drawing.Point(100, 20);
            this.numRepite.Name = "numRepite";
            this.numRepite.Size = new System.Drawing.Size(87, 20);
            this.numRepite.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Repeticiones:";
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.btnStop);
            this.gbControles.Controls.Add(this.btnPause);
            this.gbControles.Controls.Add(this.btnPlay);
            this.gbControles.Enabled = false;
            this.gbControles.Location = new System.Drawing.Point(333, 180);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(201, 70);
            this.gbControles.TabIndex = 17;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Control General";
            // 
            // gbControlTimbre
            // 
            this.gbControlTimbre.Controls.Add(this.btnStopTimbre);
            this.gbControlTimbre.Controls.Add(this.btnPauseTimbre);
            this.gbControlTimbre.Controls.Add(this.btnPlayTimbre);
            this.gbControlTimbre.Location = new System.Drawing.Point(25, 180);
            this.gbControlTimbre.Name = "gbControlTimbre";
            this.gbControlTimbre.Size = new System.Drawing.Size(201, 70);
            this.gbControlTimbre.TabIndex = 17;
            this.gbControlTimbre.TabStop = false;
            this.gbControlTimbre.Text = "Control de Timbre";
            // 
            // dgvTiempos
            // 
            this.dgvTiempos.AllowUserToAddRows = false;
            this.dgvTiempos.AllowUserToDeleteRows = false;
            this.dgvTiempos.AllowUserToResizeColumns = false;
            this.dgvTiempos.AllowUserToResizeRows = false;
            this.dgvTiempos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempos.Location = new System.Drawing.Point(580, 7);
            this.dgvTiempos.Name = "dgvTiempos";
            this.dgvTiempos.RowHeadersVisible = false;
            this.dgvTiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiempos.Size = new System.Drawing.Size(317, 243);
            this.dgvTiempos.TabIndex = 19;
            this.dgvTiempos.DoubleClick += new System.EventHandler(this.dgvTiempos_DoubleClick);
            // 
            // btnShowData
            // 
            this.btnShowData.Image = global::Cronometro.Properties.Resources.right;
            this.btnShowData.Location = new System.Drawing.Point(540, 74);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(22, 106);
            this.btnShowData.TabIndex = 18;
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnStopTimbre
            // 
            this.btnStopTimbre.Image = global::Cronometro.Properties.Resources.stop;
            this.btnStopTimbre.Location = new System.Drawing.Point(134, 19);
            this.btnStopTimbre.Name = "btnStopTimbre";
            this.btnStopTimbre.Size = new System.Drawing.Size(51, 40);
            this.btnStopTimbre.TabIndex = 2;
            this.btnStopTimbre.UseVisualStyleBackColor = true;
            this.btnStopTimbre.Click += new System.EventHandler(this.btnStopTimbre_Click);
            // 
            // btnPauseTimbre
            // 
            this.btnPauseTimbre.Image = global::Cronometro.Properties.Resources.pause;
            this.btnPauseTimbre.Location = new System.Drawing.Point(75, 19);
            this.btnPauseTimbre.Name = "btnPauseTimbre";
            this.btnPauseTimbre.Size = new System.Drawing.Size(51, 40);
            this.btnPauseTimbre.TabIndex = 1;
            this.btnPauseTimbre.UseVisualStyleBackColor = true;
            this.btnPauseTimbre.Click += new System.EventHandler(this.btnPauseTimbre_Click);
            // 
            // btnPlayTimbre
            // 
            this.btnPlayTimbre.Image = global::Cronometro.Properties.Resources.play2;
            this.btnPlayTimbre.Location = new System.Drawing.Point(16, 19);
            this.btnPlayTimbre.Name = "btnPlayTimbre";
            this.btnPlayTimbre.Size = new System.Drawing.Size(51, 40);
            this.btnPlayTimbre.TabIndex = 0;
            this.btnPlayTimbre.UseVisualStyleBackColor = true;
            this.btnPlayTimbre.Click += new System.EventHandler(this.btnPlayTimbre_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::Cronometro.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(134, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(51, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::Cronometro.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(75, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(51, 40);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Cronometro.Properties.Resources.play2;
            this.btnPlay.Location = new System.Drawing.Point(16, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.dgvTiempos);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.gbControlTimbre);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.gbManual);
            this.Controls.Add(this.gbRutina);
            this.Controls.Add(this.btnTimbre);
            this.Controls.Add(this.lblTimbreRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tdSegundo);
            this.Controls.Add(this.tdMinuto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tdHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teSegundo);
            this.Controls.Add(this.teMinuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 301);
            this.MinimumSize = new System.Drawing.Size(581, 301);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronometro Estudiantil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdHora)).EndInit();
            this.gbRutina.ResumeLayout(false);
            this.gbRutina.PerformLayout();
            this.gbManual.ResumeLayout(false);
            this.gbManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepite)).EndInit();
            this.gbControles.ResumeLayout(false);
            this.gbControlTimbre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown teHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown teMinuto;
        private System.Windows.Forms.NumericUpDown teSegundo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tdSegundo;
        private System.Windows.Forms.NumericUpDown tdMinuto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tdHora;
        private System.Windows.Forms.Label lblTimbreRuta;
        private System.Windows.Forms.Button btnTimbre;
        private System.Windows.Forms.GroupBox gbRutina;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAutomatico;
        private System.Windows.Forms.GroupBox gbManual;
        private System.Windows.Forms.NumericUpDown numRepite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox gbControlTimbre;
        private System.Windows.Forms.Button btnStopTimbre;
        private System.Windows.Forms.Button btnPauseTimbre;
        private System.Windows.Forms.Button btnPlayTimbre;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView dgvTiempos;
    }
}

