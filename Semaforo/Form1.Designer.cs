namespace Semaforo
{
    partial class Semaforos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semaforos));
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.PrimerSemaforo = new System.Windows.Forms.Timer(this.components);
            this.TimNoche = new System.Windows.Forms.Timer(this.components);
            this.btnNoche = new System.Windows.Forms.Button();
            this.chbAsignarTiempo = new System.Windows.Forms.CheckBox();
            this.gpTiempo = new System.Windows.Forms.GroupBox();
            this.txtTiempoAmarillo = new System.Windows.Forms.TextBox();
            this.txtTiempoVerde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprobar = new System.Windows.Forms.Button();
            this.pic7Seg = new System.Windows.Forms.PictureBox();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.pbs1 = new System.Windows.Forms.PictureBox();
            this.pbs2 = new System.Windows.Forms.PictureBox();
            this.pbs3 = new System.Windows.Forms.PictureBox();
            this.pbs4 = new System.Windows.Forms.PictureBox();
            this.gpTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic7Seg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.Location = new System.Drawing.Point(105, 600);
            this.btnEmpezar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(220, 39);
            this.btnEmpezar.TabIndex = 2;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = false;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // PrimerSemaforo
            // 
            this.PrimerSemaforo.Tick += new System.EventHandler(this.PrimerSemaforo_Tick_1);
            // 
            // TimNoche
            // 
            this.TimNoche.Tick += new System.EventHandler(this.TimNoche_Tick);
            // 
            // btnNoche
            // 
            this.btnNoche.BackColor = System.Drawing.Color.Transparent;
            this.btnNoche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoche.Location = new System.Drawing.Point(105, 647);
            this.btnNoche.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoche.Name = "btnNoche";
            this.btnNoche.Size = new System.Drawing.Size(220, 40);
            this.btnNoche.TabIndex = 7;
            this.btnNoche.Text = "Amarillos";
            this.btnNoche.UseVisualStyleBackColor = false;
            this.btnNoche.Click += new System.EventHandler(this.btnNoche_Click);
            // 
            // chbAsignarTiempo
            // 
            this.chbAsignarTiempo.AutoSize = true;
            this.chbAsignarTiempo.BackColor = System.Drawing.Color.White;
            this.chbAsignarTiempo.Location = new System.Drawing.Point(-349, 66);
            this.chbAsignarTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.chbAsignarTiempo.Name = "chbAsignarTiempo";
            this.chbAsignarTiempo.Size = new System.Drawing.Size(129, 21);
            this.chbAsignarTiempo.TabIndex = 8;
            this.chbAsignarTiempo.Text = "Asignar Tiempo";
            this.chbAsignarTiempo.UseVisualStyleBackColor = false;
            this.chbAsignarTiempo.Visible = false;
            this.chbAsignarTiempo.CheckedChanged += new System.EventHandler(this.chbAsignarTiempo_CheckedChanged);
            // 
            // gpTiempo
            // 
            this.gpTiempo.BackColor = System.Drawing.Color.White;
            this.gpTiempo.Controls.Add(this.txtTiempoAmarillo);
            this.gpTiempo.Controls.Add(this.txtTiempoVerde);
            this.gpTiempo.Controls.Add(this.label3);
            this.gpTiempo.Controls.Add(this.label2);
            this.gpTiempo.Location = new System.Drawing.Point(-349, 134);
            this.gpTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.gpTiempo.Name = "gpTiempo";
            this.gpTiempo.Padding = new System.Windows.Forms.Padding(4);
            this.gpTiempo.Size = new System.Drawing.Size(228, 92);
            this.gpTiempo.TabIndex = 9;
            this.gpTiempo.TabStop = false;
            this.gpTiempo.Text = "Tiempo";
            this.gpTiempo.Visible = false;
            // 
            // txtTiempoAmarillo
            // 
            this.txtTiempoAmarillo.Location = new System.Drawing.Point(69, 57);
            this.txtTiempoAmarillo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoAmarillo.Name = "txtTiempoAmarillo";
            this.txtTiempoAmarillo.Size = new System.Drawing.Size(132, 22);
            this.txtTiempoAmarillo.TabIndex = 3;
            // 
            // txtTiempoVerde
            // 
            this.txtTiempoVerde.Location = new System.Drawing.Point(69, 26);
            this.txtTiempoVerde.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoVerde.Name = "txtTiempoVerde";
            this.txtTiempoVerde.Size = new System.Drawing.Size(132, 22);
            this.txtTiempoVerde.TabIndex = 2;
            this.txtTiempoVerde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amarillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verde";
            // 
            // btnprobar
            // 
            this.btnprobar.Location = new System.Drawing.Point(-348, 98);
            this.btnprobar.Margin = new System.Windows.Forms.Padding(4);
            this.btnprobar.Name = "btnprobar";
            this.btnprobar.Size = new System.Drawing.Size(337, 23);
            this.btnprobar.TabIndex = 10;
            this.btnprobar.Text = "Probar";
            this.btnprobar.UseVisualStyleBackColor = true;
            this.btnprobar.Visible = false;
            this.btnprobar.Click += new System.EventHandler(this.btnprobar_Click);
            // 
            // pic7Seg
            // 
            this.pic7Seg.Image = global::Semaforo.Properties.Resources.CeroBlanco;
            this.pic7Seg.InitialImage = global::Semaforo.Properties.Resources.verde9;
            this.pic7Seg.Location = new System.Drawing.Point(1165, 574);
            this.pic7Seg.Margin = new System.Windows.Forms.Padding(4);
            this.pic7Seg.Name = "pic7Seg";
            this.pic7Seg.Size = new System.Drawing.Size(59, 85);
            this.pic7Seg.TabIndex = 11;
            this.pic7Seg.TabStop = false;
            this.pic7Seg.Visible = false;
            // 
            // pbDisplay
            // 
            this.pbDisplay.Image = global::Semaforo.Properties.Resources._0;
            this.pbDisplay.Location = new System.Drawing.Point(536, 390);
            this.pbDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(91, 110);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplay.TabIndex = 16;
            this.pbDisplay.TabStop = false;
            this.pbDisplay.Click += new System.EventHandler(this.pbDisplay_Click);
            // 
            // pbs1
            // 
            this.pbs1.Image = global::Semaforo.Properties.Resources.S1OFF;
            this.pbs1.Location = new System.Drawing.Point(277, 296);
            this.pbs1.Margin = new System.Windows.Forms.Padding(4);
            this.pbs1.Name = "pbs1";
            this.pbs1.Size = new System.Drawing.Size(115, 144);
            this.pbs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbs1.TabIndex = 12;
            this.pbs1.TabStop = false;
            // 
            // pbs2
            // 
            this.pbs2.Image = global::Semaforo.Properties.Resources.S2OFF;
            this.pbs2.Location = new System.Drawing.Point(592, 199);
            this.pbs2.Margin = new System.Windows.Forms.Padding(4);
            this.pbs2.Name = "pbs2";
            this.pbs2.Size = new System.Drawing.Size(165, 82);
            this.pbs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbs2.TabIndex = 13;
            this.pbs2.TabStop = false;
            this.pbs2.Click += new System.EventHandler(this.pbs2_Click);
            // 
            // pbs3
            // 
            this.pbs3.Image = global::Semaforo.Properties.Resources.S3OFF;
            this.pbs3.Location = new System.Drawing.Point(785, 419);
            this.pbs3.Margin = new System.Windows.Forms.Padding(4);
            this.pbs3.Name = "pbs3";
            this.pbs3.Size = new System.Drawing.Size(100, 132);
            this.pbs3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbs3.TabIndex = 14;
            this.pbs3.TabStop = false;
            // 
            // pbs4
            // 
            this.pbs4.Image = global::Semaforo.Properties.Resources.S4OFF;
            this.pbs4.Location = new System.Drawing.Point(418, 579);
            this.pbs4.Margin = new System.Windows.Forms.Padding(4);
            this.pbs4.Name = "pbs4";
            this.pbs4.Size = new System.Drawing.Size(165, 87);
            this.pbs4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbs4.TabIndex = 15;
            this.pbs4.TabStop = false;
            // 
            // Semaforos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1165, 912);
            this.Controls.Add(this.pbDisplay);
            this.Controls.Add(this.pbs4);
            this.Controls.Add(this.pbs3);
            this.Controls.Add(this.pbs2);
            this.Controls.Add(this.pbs1);
            this.Controls.Add(this.pic7Seg);
            this.Controls.Add(this.btnprobar);
            this.Controls.Add(this.gpTiempo);
            this.Controls.Add(this.chbAsignarTiempo);
            this.Controls.Add(this.btnNoche);
            this.Controls.Add(this.btnEmpezar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Semaforos";
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpTiempo.ResumeLayout(false);
            this.gpTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic7Seg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbs4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Timer PrimerSemaforo;
        private System.Windows.Forms.Timer TimNoche;
        private System.Windows.Forms.Button btnNoche;
        private System.Windows.Forms.CheckBox chbAsignarTiempo;
        private System.Windows.Forms.GroupBox gpTiempo;
        private System.Windows.Forms.TextBox txtTiempoAmarillo;
        private System.Windows.Forms.TextBox txtTiempoVerde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprobar;
        private System.Windows.Forms.PictureBox pic7Seg;
        private System.Windows.Forms.PictureBox pbDisplay;
        private System.Windows.Forms.PictureBox pbs1;
        private System.Windows.Forms.PictureBox pbs2;
        private System.Windows.Forms.PictureBox pbs3;
        private System.Windows.Forms.PictureBox pbs4;
    }
}

