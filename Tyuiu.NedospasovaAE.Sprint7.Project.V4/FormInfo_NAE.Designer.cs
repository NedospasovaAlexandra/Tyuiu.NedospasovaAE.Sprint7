
using System;

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    partial class FormInfo_NAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo_NAE));
            this.textBoxInfo_NAE = new System.Windows.Forms.TextBox();
            this.buttonCloseFormInfo_NAE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo_NAE
            // 
            this.textBoxInfo_NAE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxInfo_NAE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_NAE.Location = new System.Drawing.Point(12, 12);
            this.textBoxInfo_NAE.Multiline = true;
            this.textBoxInfo_NAE.Name = "textBoxInfo_NAE";
            this.textBoxInfo_NAE.ReadOnly = true;
            this.textBoxInfo_NAE.Size = new System.Drawing.Size(460, 202);
            this.textBoxInfo_NAE.TabIndex = 0;
            this.textBoxInfo_NAE.Text = resources.GetString("textBoxInfo_NAE.Text");
            // 
            // buttonCloseFormInfo_NAE
            // 
            this.buttonCloseFormInfo_NAE.Location = new System.Drawing.Point(383, 170);
            this.buttonCloseFormInfo_NAE.Name = "buttonCloseFormInfo_NAE";
            this.buttonCloseFormInfo_NAE.Size = new System.Drawing.Size(89, 44);
            this.buttonCloseFormInfo_NAE.TabIndex = 1;
            this.buttonCloseFormInfo_NAE.Text = "ОК";
            this.buttonCloseFormInfo_NAE.UseVisualStyleBackColor = true;
            this.buttonCloseFormInfo_NAE.Click += new System.EventHandler(this.buttonCloseFormInfo_NAE_Click);
            // 
            // FormInfo_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.buttonCloseFormInfo_NAE);
            this.Controls.Add(this.textBoxInfo_NAE);
            this.MaximizeBox = false;
            this.Name = "FormInfo_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_NAE;
        private System.Windows.Forms.Button buttonCloseFormInfo_NAE;
    }
}