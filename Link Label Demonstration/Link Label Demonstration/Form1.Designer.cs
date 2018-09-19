namespace Link_Label_Demonstration
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
            this.lnkTest = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkTest
            // 
            this.lnkTest.AutoSize = true;
            this.lnkTest.Location = new System.Drawing.Point(12, 9);
            this.lnkTest.Name = "lnkTest";
            this.lnkTest.Size = new System.Drawing.Size(91, 13);
            this.lnkTest.TabIndex = 0;
            this.lnkTest.TabStop = true;
            this.lnkTest.Text = "This is a test label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 341);
            this.Controls.Add(this.lnkTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkTest;
    }
}

