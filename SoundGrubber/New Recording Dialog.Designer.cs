namespace SoundGrubber
{
    partial class New_Recording_Dialog
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileNameLable = new System.Windows.Forms.Label();
            this.fileNameTextBx = new System.Windows.Forms.TextBox();
            this.filePathTextBx = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(269, 101);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // fileNameLable
            // 
            this.fileNameLable.AutoSize = true;
            this.fileNameLable.Location = new System.Drawing.Point(13, 13);
            this.fileNameLable.Name = "fileNameLable";
            this.fileNameLable.Size = new System.Drawing.Size(89, 13);
            this.fileNameLable.TabIndex = 1;
            this.fileNameLable.Text = "Enter name of file";
            // 
            // fileNameTextBx
            // 
            this.fileNameTextBx.Location = new System.Drawing.Point(16, 30);
            this.fileNameTextBx.Name = "fileNameTextBx";
            this.fileNameTextBx.Size = new System.Drawing.Size(328, 20);
            this.fileNameTextBx.TabIndex = 2;
            // 
            // filePathTextBx
            // 
            this.filePathTextBx.Location = new System.Drawing.Point(16, 75);
            this.filePathTextBx.Name = "filePathTextBx";
            this.filePathTextBx.Size = new System.Drawing.Size(328, 20);
            this.filePathTextBx.TabIndex = 3;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(13, 59);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(48, 13);
            this.filePathLabel.TabIndex = 4;
            this.filePathLabel.Text = "File Path";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(269, 135);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(160, 135);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // New_Recording_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 170);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.filePathTextBx);
            this.Controls.Add(this.fileNameTextBx);
            this.Controls.Add(this.fileNameLable);
            this.Controls.Add(this.browseBtn);
            this.Name = "New_Recording_Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Recording Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label fileNameLable;
        private System.Windows.Forms.TextBox fileNameTextBx;
        private System.Windows.Forms.TextBox filePathTextBx;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}