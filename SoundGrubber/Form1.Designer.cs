namespace SoundGrubber
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
            this.components = new System.ComponentModel.Container();
            this.newRecBtn = new System.Windows.Forms.Button();
            this.fileNameTextbx = new System.Windows.Forms.TextBox();
            this.directoryPathTextbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startRecBtn = new System.Windows.Forms.Button();
            this.stopRecBtn = new System.Windows.Forms.Button();
            this.timeView = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelRecBtn = new System.Windows.Forms.Button();
            this.recTime = new System.Windows.Forms.Timer(this.components);
            this.stateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newRecBtn
            // 
            this.newRecBtn.Location = new System.Drawing.Point(49, 32);
            this.newRecBtn.Name = "newRecBtn";
            this.newRecBtn.Size = new System.Drawing.Size(368, 30);
            this.newRecBtn.TabIndex = 0;
            this.newRecBtn.Text = "New Recording";
            this.newRecBtn.UseVisualStyleBackColor = true;
            this.newRecBtn.Click += new System.EventHandler(this.newRecBtn_Click);
            // 
            // fileNameTextbx
            // 
            this.fileNameTextbx.Location = new System.Drawing.Point(12, 92);
            this.fileNameTextbx.Name = "fileNameTextbx";
            this.fileNameTextbx.Size = new System.Drawing.Size(454, 20);
            this.fileNameTextbx.TabIndex = 1;
            this.fileNameTextbx.Text = "NewRecording";
            // 
            // directoryPathTextbx
            // 
            this.directoryPathTextbx.Location = new System.Drawing.Point(12, 146);
            this.directoryPathTextbx.Name = "directoryPathTextbx";
            this.directoryPathTextbx.Size = new System.Drawing.Size(454, 20);
            this.directoryPathTextbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Directory";
            // 
            // startRecBtn
            // 
            this.startRecBtn.Location = new System.Drawing.Point(12, 224);
            this.startRecBtn.Name = "startRecBtn";
            this.startRecBtn.Size = new System.Drawing.Size(143, 53);
            this.startRecBtn.TabIndex = 6;
            this.startRecBtn.Text = "Start Recording";
            this.startRecBtn.UseVisualStyleBackColor = true;
            this.startRecBtn.Click += new System.EventHandler(this.startRecBtn_Click);
            // 
            // stopRecBtn
            // 
            this.stopRecBtn.Enabled = false;
            this.stopRecBtn.Location = new System.Drawing.Point(311, 224);
            this.stopRecBtn.Name = "stopRecBtn";
            this.stopRecBtn.Size = new System.Drawing.Size(155, 53);
            this.stopRecBtn.TabIndex = 7;
            this.stopRecBtn.Text = "Stop Recording";
            this.stopRecBtn.UseVisualStyleBackColor = true;
            this.stopRecBtn.Click += new System.EventHandler(this.stopRecBtn_Click);
            // 
            // timeView
            // 
            this.timeView.AutoSize = true;
            this.timeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeView.Location = new System.Drawing.Point(87, 295);
            this.timeView.Name = "timeView";
            this.timeView.Size = new System.Drawing.Size(293, 76);
            this.timeView.TabIndex = 8;
            this.timeView.Text = "00:00:00";
            // 
            // cancelRecBtn
            // 
            this.cancelRecBtn.Location = new System.Drawing.Point(165, 172);
            this.cancelRecBtn.Name = "cancelRecBtn";
            this.cancelRecBtn.Size = new System.Drawing.Size(132, 23);
            this.cancelRecBtn.TabIndex = 9;
            this.cancelRecBtn.Text = "Cancel Recording";
            this.cancelRecBtn.UseVisualStyleBackColor = true;
            this.cancelRecBtn.Click += new System.EventHandler(this.cancelRecBtn_Click);
            // 
            // recTime
            // 
            this.recTime.Interval = 1000;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(193, 207);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(76, 13);
            this.stateLabel.TabIndex = 10;
            this.stateLabel.Text = "Not Recording";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 416);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cancelRecBtn);
            this.Controls.Add(this.timeView);
            this.Controls.Add(this.stopRecBtn);
            this.Controls.Add(this.startRecBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryPathTextbx);
            this.Controls.Add(this.fileNameTextbx);
            this.Controls.Add(this.newRecBtn);
            this.MaximumSize = new System.Drawing.Size(490, 455);
            this.MinimumSize = new System.Drawing.Size(490, 455);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundGrubber";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRecBtn;
        private System.Windows.Forms.TextBox fileNameTextbx;
        private System.Windows.Forms.TextBox directoryPathTextbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startRecBtn;
        private System.Windows.Forms.Button stopRecBtn;
        private System.Windows.Forms.Label timeView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cancelRecBtn;
        private System.Windows.Forms.Timer recTime;
        private System.Windows.Forms.Label stateLabel;
    }
}

