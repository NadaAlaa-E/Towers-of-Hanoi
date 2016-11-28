namespace Tower_of_Hanoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.numDiscsTxt = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Discs";
            // 
            // numDiscsTxt
            // 
            this.numDiscsTxt.Location = new System.Drawing.Point(210, 34);
            this.numDiscsTxt.Name = "numDiscsTxt";
            this.numDiscsTxt.Size = new System.Drawing.Size(150, 31);
            this.numDiscsTxt.TabIndex = 1;
            this.numDiscsTxt.TextChanged += new System.EventHandler(this.numDiscsTxt_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(380, 32);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(147, 40);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(42, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 803);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(380, 78);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopBtn.Size = new System.Drawing.Size(147, 40);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1728, 1017);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.numDiscsTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numDiscsTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopBtn;
    }
}

