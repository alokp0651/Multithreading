namespace Multithreading
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
            this.process1 = new System.Diagnostics.Process();
            this.TimeConsumingWork = new System.Windows.Forms.Button();
            this.PrintNumber = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // TimeConsumingWork
            // 
            this.TimeConsumingWork.Location = new System.Drawing.Point(154, 74);
            this.TimeConsumingWork.Name = "TimeConsumingWork";
            this.TimeConsumingWork.Size = new System.Drawing.Size(498, 56);
            this.TimeConsumingWork.TabIndex = 0;
            this.TimeConsumingWork.Text = "Time Consuming Work";
            this.TimeConsumingWork.UseVisualStyleBackColor = true;
            this.TimeConsumingWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintNumber
            // 
            this.PrintNumber.Location = new System.Drawing.Point(154, 146);
            this.PrintNumber.Name = "PrintNumber";
            this.PrintNumber.Size = new System.Drawing.Size(498, 54);
            this.PrintNumber.TabIndex = 1;
            this.PrintNumber.Text = "PrintNumber";
            this.PrintNumber.UseVisualStyleBackColor = true;
            this.PrintNumber.Click += new System.EventHandler(this.PrintNumber_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(154, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 173);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PrintNumber);
            this.Controls.Add(this.TimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button PrintNumber;
        private System.Windows.Forms.Button TimeConsumingWork;
        private System.Windows.Forms.ListBox listBox1;
    }
}

