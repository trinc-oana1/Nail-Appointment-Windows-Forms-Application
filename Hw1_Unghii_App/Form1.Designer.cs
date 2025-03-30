namespace Hw1_Unghii_App
{
    partial class Form1
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
            this.trackBarLungime = new System.Windows.Forms.TrackBar();
            this.labelLungime = new System.Windows.Forms.Label();
            this.groupBoxForma = new System.Windows.Forms.GroupBox();
            this.radioMigdala = new System.Windows.Forms.RadioButton();
            this.radioOvala = new System.Windows.Forms.RadioButton();
            this.radioPatrata = new System.Windows.Forms.RadioButton();
            this.listBoxCulori = new System.Windows.Forms.ListBox();
            this.labelCulori = new System.Windows.Forms.Label();
            this.listBoxModel = new System.Windows.Forms.ListBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonGenerare = new System.Windows.Forms.Button();
            this.pictureBoxRezultat = new System.Windows.Forms.PictureBox();
            this.groupBoxFinisaj = new System.Windows.Forms.GroupBox();
            this.radioLucios = new System.Windows.Forms.RadioButton();
            this.radioMat = new System.Windows.Forms.RadioButton();
            this.buttonFaProgramare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLungime)).BeginInit();
            this.groupBoxForma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezultat)).BeginInit();
            this.groupBoxFinisaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarLungime
            // 
            this.trackBarLungime.BackColor = System.Drawing.Color.IndianRed;
            this.trackBarLungime.Location = new System.Drawing.Point(12, 38);
            this.trackBarLungime.Maximum = 3;
            this.trackBarLungime.Minimum = 1;
            this.trackBarLungime.Name = "trackBarLungime";
            this.trackBarLungime.Size = new System.Drawing.Size(146, 56);
            this.trackBarLungime.TabIndex = 0;
            this.trackBarLungime.Value = 2;
            // 
            // labelLungime
            // 
            this.labelLungime.AutoSize = true;
            this.labelLungime.Location = new System.Drawing.Point(12, 9);
            this.labelLungime.Name = "labelLungime";
            this.labelLungime.Size = new System.Drawing.Size(99, 16);
            this.labelLungime.TabIndex = 1;
            this.labelLungime.Text = "Lungime unghii:";
            // 
            // groupBoxForma
            // 
            this.groupBoxForma.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxForma.Controls.Add(this.radioMigdala);
            this.groupBoxForma.Controls.Add(this.radioOvala);
            this.groupBoxForma.Controls.Add(this.radioPatrata);
            this.groupBoxForma.Location = new System.Drawing.Point(12, 119);
            this.groupBoxForma.Name = "groupBoxForma";
            this.groupBoxForma.Size = new System.Drawing.Size(172, 102);
            this.groupBoxForma.TabIndex = 2;
            this.groupBoxForma.TabStop = false;
            this.groupBoxForma.Text = "Forma unghiei";
            // 
            // radioMigdala
            // 
            this.radioMigdala.AutoSize = true;
            this.radioMigdala.Location = new System.Drawing.Point(3, 73);
            this.radioMigdala.Name = "radioMigdala";
            this.radioMigdala.Size = new System.Drawing.Size(77, 20);
            this.radioMigdala.TabIndex = 7;
            this.radioMigdala.Text = "Migdala";
            this.radioMigdala.UseVisualStyleBackColor = true;
            // 
            // radioOvala
            // 
            this.radioOvala.AutoSize = true;
            this.radioOvala.Location = new System.Drawing.Point(6, 47);
            this.radioOvala.Name = "radioOvala";
            this.radioOvala.Size = new System.Drawing.Size(64, 20);
            this.radioOvala.TabIndex = 4;
            this.radioOvala.Text = "Ovala";
            this.radioOvala.UseVisualStyleBackColor = true;
            // 
            // radioPatrata
            // 
            this.radioPatrata.AutoSize = true;
            this.radioPatrata.Checked = true;
            this.radioPatrata.Location = new System.Drawing.Point(6, 21);
            this.radioPatrata.Name = "radioPatrata";
            this.radioPatrata.Size = new System.Drawing.Size(71, 20);
            this.radioPatrata.TabIndex = 3;
            this.radioPatrata.TabStop = true;
            this.radioPatrata.Text = "Patrata";
            this.radioPatrata.UseVisualStyleBackColor = true;
            // 
            // listBoxCulori
            // 
            this.listBoxCulori.BackColor = System.Drawing.Color.IndianRed;
            this.listBoxCulori.FormattingEnabled = true;
            this.listBoxCulori.ItemHeight = 16;
            this.listBoxCulori.Items.AddRange(new object[] {
            "Negru",
            "Alb",
            "Rosu"});
            this.listBoxCulori.Location = new System.Drawing.Point(500, 38);
            this.listBoxCulori.Name = "listBoxCulori";
            this.listBoxCulori.Size = new System.Drawing.Size(128, 52);
            this.listBoxCulori.TabIndex = 3;
            // 
            // labelCulori
            // 
            this.labelCulori.AutoSize = true;
            this.labelCulori.Location = new System.Drawing.Point(497, 9);
            this.labelCulori.Name = "labelCulori";
            this.labelCulori.Size = new System.Drawing.Size(95, 16);
            this.labelCulori.TabIndex = 4;
            this.labelCulori.Text = "Culoare unghii:";
            // 
            // listBoxModel
            // 
            this.listBoxModel.BackColor = System.Drawing.Color.IndianRed;
            this.listBoxModel.FormattingEnabled = true;
            this.listBoxModel.ItemHeight = 16;
            this.listBoxModel.Items.AddRange(new object[] {
            "Simplu",
            "Sclipici"});
            this.listBoxModel.Location = new System.Drawing.Point(280, 38);
            this.listBoxModel.Name = "listBoxModel";
            this.listBoxModel.Size = new System.Drawing.Size(116, 52);
            this.listBoxModel.TabIndex = 5;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(277, 9);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(86, 16);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Model unghii:";
            // 
            // buttonGenerare
            // 
            this.buttonGenerare.BackColor = System.Drawing.Color.IndianRed;
            this.buttonGenerare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.buttonGenerare.Location = new System.Drawing.Point(84, 351);
            this.buttonGenerare.Name = "buttonGenerare";
            this.buttonGenerare.Size = new System.Drawing.Size(150, 40);
            this.buttonGenerare.TabIndex = 10;
            this.buttonGenerare.Text = "Generare model";
            this.buttonGenerare.UseVisualStyleBackColor = false;
            this.buttonGenerare.Click += new System.EventHandler(this.buttonGenerare_Click);
            // 
            // pictureBoxRezultat
            // 
            this.pictureBoxRezultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRezultat.Location = new System.Drawing.Point(392, 220);
            this.pictureBoxRezultat.Name = "pictureBoxRezultat";
            this.pictureBoxRezultat.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxRezultat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRezultat.TabIndex = 11;
            this.pictureBoxRezultat.TabStop = false;
            // 
            // groupBoxFinisaj
            // 
            this.groupBoxFinisaj.BackColor = System.Drawing.Color.IndianRed;
            this.groupBoxFinisaj.Controls.Add(this.radioLucios);
            this.groupBoxFinisaj.Controls.Add(this.radioMat);
            this.groupBoxFinisaj.Location = new System.Drawing.Point(272, 119);
            this.groupBoxFinisaj.Name = "groupBoxFinisaj";
            this.groupBoxFinisaj.Size = new System.Drawing.Size(183, 79);
            this.groupBoxFinisaj.TabIndex = 12;
            this.groupBoxFinisaj.TabStop = false;
            this.groupBoxFinisaj.Text = "Finisaj unghii";
            // 
            // radioLucios
            // 
            this.radioLucios.AutoSize = true;
            this.radioLucios.Location = new System.Drawing.Point(3, 52);
            this.radioLucios.Name = "radioLucios";
            this.radioLucios.Size = new System.Drawing.Size(67, 20);
            this.radioLucios.TabIndex = 1;
            this.radioLucios.Text = "Lucios";
            this.radioLucios.UseVisualStyleBackColor = true;
            // 
            // radioMat
            // 
            this.radioMat.AutoSize = true;
            this.radioMat.Checked = true;
            this.radioMat.Location = new System.Drawing.Point(3, 18);
            this.radioMat.Name = "radioMat";
            this.radioMat.Size = new System.Drawing.Size(50, 20);
            this.radioMat.TabIndex = 0;
            this.radioMat.TabStop = true;
            this.radioMat.Text = "Mat";
            this.radioMat.UseVisualStyleBackColor = true;
            // 
            // buttonFaProgramare
            // 
            this.buttonFaProgramare.BackColor = System.Drawing.Color.IndianRed;
            this.buttonFaProgramare.Location = new System.Drawing.Point(84, 424);
            this.buttonFaProgramare.Name = "buttonFaProgramare";
            this.buttonFaProgramare.Size = new System.Drawing.Size(150, 33);
            this.buttonFaProgramare.TabIndex = 14;
            this.buttonFaProgramare.Text = "Fa programarea";
            this.buttonFaProgramare.UseVisualStyleBackColor = false;
            this.buttonFaProgramare.Click += new System.EventHandler(this.buttonFaProgramare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.buttonFaProgramare);
            this.Controls.Add(this.groupBoxFinisaj);
            this.Controls.Add(this.pictureBoxRezultat);
            this.Controls.Add(this.buttonGenerare);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.listBoxModel);
            this.Controls.Add(this.labelCulori);
            this.Controls.Add(this.listBoxCulori);
            this.Controls.Add(this.groupBoxForma);
            this.Controls.Add(this.labelLungime);
            this.Controls.Add(this.trackBarLungime);
            this.Name = "Form1";
            this.Text = "Configurator unghii";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLungime)).EndInit();
            this.groupBoxForma.ResumeLayout(false);
            this.groupBoxForma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezultat)).EndInit();
            this.groupBoxFinisaj.ResumeLayout(false);
            this.groupBoxFinisaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarLungime;
        private System.Windows.Forms.Label labelLungime;
        private System.Windows.Forms.GroupBox groupBoxForma;
        private System.Windows.Forms.RadioButton radioMigdala;
        private System.Windows.Forms.RadioButton radioOvala;
        private System.Windows.Forms.RadioButton radioPatrata;
        private System.Windows.Forms.ListBox listBoxCulori;
        private System.Windows.Forms.Label labelCulori;
        private System.Windows.Forms.ListBox listBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button buttonGenerare;
        private System.Windows.Forms.PictureBox pictureBoxRezultat;
        private System.Windows.Forms.GroupBox groupBoxFinisaj;
        private System.Windows.Forms.RadioButton radioLucios;
        private System.Windows.Forms.RadioButton radioMat;
        private System.Windows.Forms.Button buttonFaProgramare;
    }
}

