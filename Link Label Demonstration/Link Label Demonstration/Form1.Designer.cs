namespace Link_Label_Demonstration
{
    partial class lnkDemo
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
            this.lnkPictureChange = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkPictureChange
            // 
            this.lnkPictureChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPictureChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPictureChange.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.lnkPictureChange.Location = new System.Drawing.Point(12, 32);
            this.lnkPictureChange.Name = "lnkPictureChange";
            this.lnkPictureChange.Size = new System.Drawing.Size(276, 47);
            this.lnkPictureChange.TabIndex = 0;
            this.lnkPictureChange.TabStop = true;
            this.lnkPictureChange.Text = "Click HERE to visit the bored button";
            this.lnkPictureChange.UseCompatibleTextRendering = true;
            this.lnkPictureChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPictureChange_LinkClicked);
            // 
            // lnkDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 530);
            this.Controls.Add(this.lnkPictureChange);
            this.Name = "lnkDemo";
            this.Text = "Link Label Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPictureChange;
    }
}

