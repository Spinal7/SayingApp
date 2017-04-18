namespace SayingApps
{
    partial class FrmSayingsGUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxSaying = new System.Windows.Forms.TextBox();
            this.btnStoreSaying = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Favorite Saying:";
            // 
            // txtBoxSaying
            // 
            this.txtBoxSaying.Location = new System.Drawing.Point(61, 67);
            this.txtBoxSaying.Multiline = true;
            this.txtBoxSaying.Name = "txtBoxSaying";
            this.txtBoxSaying.Size = new System.Drawing.Size(352, 185);
            this.txtBoxSaying.TabIndex = 1;
            // 
            // btnStoreSaying
            // 
            this.btnStoreSaying.Location = new System.Drawing.Point(195, 284);
            this.btnStoreSaying.Name = "btnStoreSaying";
            this.btnStoreSaying.Size = new System.Drawing.Size(93, 44);
            this.btnStoreSaying.TabIndex = 2;
            this.btnStoreSaying.Text = "Store Saying";
            this.btnStoreSaying.UseVisualStyleBackColor = true;
            this.btnStoreSaying.Click += new System.EventHandler(this.btnStoreSaying_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Lucida Fax", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(58, 356);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 3;
            // 
            // FrmSayingsGUI
            // 
            this.AcceptButton = this.btnStoreSaying;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnStoreSaying);
            this.Controls.Add(this.txtBoxSaying);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSayingsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                     Favorite Sayings Storing App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSayingsGUI_Close);
            this.Load += new System.EventHandler(this.FrmSayingsGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxSaying;
        private System.Windows.Forms.Button btnStoreSaying;
        private System.Windows.Forms.Label lblWarning;
    }
}

