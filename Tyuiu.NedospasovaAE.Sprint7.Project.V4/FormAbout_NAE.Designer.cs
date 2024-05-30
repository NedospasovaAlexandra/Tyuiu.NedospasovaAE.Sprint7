
namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    partial class FormAbout_NAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_NAE));
            this.textBoxShowInfo_NAE = new System.Windows.Forms.TextBox();
            this.pictureBoxShowPhoto_NAE = new System.Windows.Forms.PictureBox();
            this.buttonCloseFormAbout_NAE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPhoto_NAE)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxShowInfo_NAE
            // 
            this.textBoxShowInfo_NAE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxShowInfo_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShowInfo_NAE.Location = new System.Drawing.Point(182, 12);
            this.textBoxShowInfo_NAE.Multiline = true;
            this.textBoxShowInfo_NAE.Name = "textBoxShowInfo_NAE";
            this.textBoxShowInfo_NAE.ReadOnly = true;
            this.textBoxShowInfo_NAE.Size = new System.Drawing.Size(290, 143);
            this.textBoxShowInfo_NAE.TabIndex = 0;
            this.textBoxShowInfo_NAE.Text = resources.GetString("textBoxShowInfo_NAE.Text");
            // 
            // pictureBoxShowPhoto_NAE
            // 
            this.pictureBoxShowPhoto_NAE.Image = global::Tyuiu.NedospasovaAE.Sprint7.Project.V4.Properties.Resources.FormAbout;
            this.pictureBoxShowPhoto_NAE.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxShowPhoto_NAE.Name = "pictureBoxShowPhoto_NAE";
            this.pictureBoxShowPhoto_NAE.Size = new System.Drawing.Size(154, 205);
            this.pictureBoxShowPhoto_NAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShowPhoto_NAE.TabIndex = 1;
            this.pictureBoxShowPhoto_NAE.TabStop = false;
            // 
            // buttonCloseFormAbout_NAE
            // 
            this.buttonCloseFormAbout_NAE.Location = new System.Drawing.Point(383, 173);
            this.buttonCloseFormAbout_NAE.Name = "buttonCloseFormAbout_NAE";
            this.buttonCloseFormAbout_NAE.Size = new System.Drawing.Size(89, 44);
            this.buttonCloseFormAbout_NAE.TabIndex = 2;
            this.buttonCloseFormAbout_NAE.Text = "ОК";
            this.buttonCloseFormAbout_NAE.UseVisualStyleBackColor = true;
            this.buttonCloseFormAbout_NAE.Click += new System.EventHandler(this.buttonCloseFormAbout_NAE_Click);
            // 
            // FormAbout_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.buttonCloseFormAbout_NAE);
            this.Controls.Add(this.pictureBoxShowPhoto_NAE);
            this.Controls.Add(this.textBoxShowInfo_NAE);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 265);
            this.MinimumSize = new System.Drawing.Size(500, 265);
            this.Name = "FormAbout_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPhoto_NAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowInfo_NAE;
        private System.Windows.Forms.PictureBox pictureBoxShowPhoto_NAE;
        private System.Windows.Forms.Button buttonCloseFormAbout_NAE;
    }
}