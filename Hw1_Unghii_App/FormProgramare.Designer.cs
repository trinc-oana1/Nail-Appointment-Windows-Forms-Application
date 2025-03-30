namespace Hw1_Unghii_App
{
    partial class FormProgramare
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
            this.calendarProgramare = new System.Windows.Forms.MonthCalendar();
            this.buttonConfirma = new System.Windows.Forms.Button();
            this.comboOra = new System.Windows.Forms.ComboBox();
            this.comboMinute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendarProgramare
            // 
            this.calendarProgramare.BackColor = System.Drawing.Color.IndianRed;
            this.calendarProgramare.Location = new System.Drawing.Point(67, 93);
            this.calendarProgramare.Name = "calendarProgramare";
            this.calendarProgramare.TabIndex = 0;
            // 
            // buttonConfirma
            // 
            this.buttonConfirma.BackColor = System.Drawing.Color.IndianRed;
            this.buttonConfirma.Location = new System.Drawing.Point(450, 352);
            this.buttonConfirma.Name = "buttonConfirma";
            this.buttonConfirma.Size = new System.Drawing.Size(170, 30);
            this.buttonConfirma.TabIndex = 1;
            this.buttonConfirma.Text = "Confirma programarea";
            this.buttonConfirma.UseVisualStyleBackColor = false;
            this.buttonConfirma.Click += new System.EventHandler(this.buttonConfirma_Click);
            // 
            // comboOra
            // 
            this.comboOra.BackColor = System.Drawing.Color.IndianRed;
            this.comboOra.FormattingEnabled = true;
            this.comboOra.Location = new System.Drawing.Point(466, 171);
            this.comboOra.Name = "comboOra";
            this.comboOra.Size = new System.Drawing.Size(134, 24);
            this.comboOra.TabIndex = 3;
            // 
            // comboMinute
            // 
            this.comboMinute.BackColor = System.Drawing.Color.IndianRed;
            this.comboMinute.FormattingEnabled = true;
            this.comboMinute.Location = new System.Drawing.Point(466, 238);
            this.comboMinute.Name = "comboMinute";
            this.comboMinute.Size = new System.Drawing.Size(134, 24);
            this.comboMinute.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alege data si ora programarii:";
            // 
            // FormProgramare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMinute);
            this.Controls.Add(this.comboOra);
            this.Controls.Add(this.buttonConfirma);
            this.Controls.Add(this.calendarProgramare);
            this.Name = "FormProgramare";
            this.Text = "FormProgramare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarProgramare;
        private System.Windows.Forms.Button buttonConfirma;
        private System.Windows.Forms.ComboBox comboOra;
        private System.Windows.Forms.ComboBox comboMinute;
        private System.Windows.Forms.Label label1;
    }
}