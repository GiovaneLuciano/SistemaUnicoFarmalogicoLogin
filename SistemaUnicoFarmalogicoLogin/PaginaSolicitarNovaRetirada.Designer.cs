namespace SistemaUnicoFarmalogicoLogin
{
    partial class PaginaSolicitarNovaRetirada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaSolicitarNovaRetirada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textExamesSolicitar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nomePacienteSolicitar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textLDL = new System.Windows.Forms.Label();
            this.textHDL = new System.Windows.Forms.Label();
            this.textTIREOIDE = new System.Windows.Forms.Label();
            this.textETC = new System.Windows.Forms.Label();
            this.ButtonSolicitar = new System.Windows.Forms.Button();
            this.buttonEspecificarExame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.buttonEspecificarExame);
            this.panel1.Controls.Add(this.ButtonSolicitar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(200, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textExamesSolicitar);
            this.panel2.Location = new System.Drawing.Point(43, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 63);
            this.panel2.TabIndex = 0;
            // 
            // textExamesSolicitar
            // 
            this.textExamesSolicitar.AutoSize = true;
            this.textExamesSolicitar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textExamesSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExamesSolicitar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textExamesSolicitar.Location = new System.Drawing.Point(5, 14);
            this.textExamesSolicitar.Name = "textExamesSolicitar";
            this.textExamesSolicitar.Size = new System.Drawing.Size(162, 18);
            this.textExamesSolicitar.TabIndex = 0;
            this.textExamesSolicitar.Text = "Exames que o paciente";
            this.textExamesSolicitar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(56, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "precisa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.nomePacienteSolicitar);
            this.panel3.Location = new System.Drawing.Point(271, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 36);
            this.panel3.TabIndex = 1;
            // 
            // nomePacienteSolicitar
            // 
            this.nomePacienteSolicitar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomePacienteSolicitar.AutoSize = true;
            this.nomePacienteSolicitar.ForeColor = System.Drawing.SystemColors.Control;
            this.nomePacienteSolicitar.Location = new System.Drawing.Point(18, 2);
            this.nomePacienteSolicitar.Name = "nomePacienteSolicitar";
            this.nomePacienteSolicitar.Size = new System.Drawing.Size(146, 16);
            this.nomePacienteSolicitar.TabIndex = 0;
            this.nomePacienteSolicitar.Text = "Rita Aparecida Oliveira";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.textETC);
            this.panel4.Controls.Add(this.textTIREOIDE);
            this.panel4.Controls.Add(this.textHDL);
            this.panel4.Controls.Add(this.textLDL);
            this.panel4.Location = new System.Drawing.Point(135, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 111);
            this.panel4.TabIndex = 2;
            // 
            // textLDL
            // 
            this.textLDL.AutoSize = true;
            this.textLDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLDL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textLDL.Location = new System.Drawing.Point(77, 17);
            this.textLDL.Name = "textLDL";
            this.textLDL.Size = new System.Drawing.Size(35, 18);
            this.textLDL.TabIndex = 0;
            this.textLDL.Text = "LDL";
            this.textLDL.Click += new System.EventHandler(this.label1_Click);
            // 
            // textHDL
            // 
            this.textHDL.AutoSize = true;
            this.textHDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHDL.ForeColor = System.Drawing.SystemColors.Control;
            this.textHDL.Location = new System.Drawing.Point(77, 35);
            this.textHDL.Name = "textHDL";
            this.textHDL.Size = new System.Drawing.Size(38, 18);
            this.textHDL.TabIndex = 1;
            this.textHDL.Text = "HDL";
            this.textHDL.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTIREOIDE
            // 
            this.textTIREOIDE.AutoSize = true;
            this.textTIREOIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTIREOIDE.ForeColor = System.Drawing.SystemColors.Control;
            this.textTIREOIDE.Location = new System.Drawing.Point(56, 53);
            this.textTIREOIDE.Name = "textTIREOIDE";
            this.textTIREOIDE.Size = new System.Drawing.Size(77, 18);
            this.textTIREOIDE.TabIndex = 2;
            this.textTIREOIDE.Text = "TIREOIDE";
            this.textTIREOIDE.Click += new System.EventHandler(this.label1_Click);
            // 
            // textETC
            // 
            this.textETC.AutoSize = true;
            this.textETC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textETC.ForeColor = System.Drawing.SystemColors.Control;
            this.textETC.Location = new System.Drawing.Point(74, 71);
            this.textETC.Name = "textETC";
            this.textETC.Size = new System.Drawing.Size(38, 18);
            this.textETC.TabIndex = 3;
            this.textETC.Text = "ETC";
            // 
            // ButtonSolicitar
            // 
            this.ButtonSolicitar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSolicitar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonSolicitar.Location = new System.Drawing.Point(135, 349);
            this.ButtonSolicitar.Name = "ButtonSolicitar";
            this.ButtonSolicitar.Size = new System.Drawing.Size(200, 47);
            this.ButtonSolicitar.TabIndex = 3;
            this.ButtonSolicitar.Text = "SOLICITAR";
            this.ButtonSolicitar.UseVisualStyleBackColor = false;
            this.ButtonSolicitar.Click += new System.EventHandler(this.ButtonSolicitar_Click);
            // 
            // buttonEspecificarExame
            // 
            this.buttonEspecificarExame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEspecificarExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEspecificarExame.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEspecificarExame.Location = new System.Drawing.Point(135, 277);
            this.buttonEspecificarExame.Name = "buttonEspecificarExame";
            this.buttonEspecificarExame.Size = new System.Drawing.Size(200, 36);
            this.buttonEspecificarExame.TabIndex = 4;
            this.buttonEspecificarExame.Text = "Especificar novo exame";
            this.buttonEspecificarExame.UseVisualStyleBackColor = false;
            this.buttonEspecificarExame.Click += new System.EventHandler(this.buttonEspecificarExame_Click);
            // 
            // PaginaSolicitarNovaRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PaginaSolicitarNovaRetirada";
            this.Text = "PaginaSolicitarNovaRetirada";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label textExamesSolicitar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nomePacienteSolicitar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label textLDL;
        private System.Windows.Forms.Button buttonEspecificarExame;
        private System.Windows.Forms.Button ButtonSolicitar;
        private System.Windows.Forms.Label textETC;
        private System.Windows.Forms.Label textTIREOIDE;
        private System.Windows.Forms.Label textHDL;
    }
}