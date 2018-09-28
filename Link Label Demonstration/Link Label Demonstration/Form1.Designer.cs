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
            this.tblLinkDemo = new System.Windows.Forms.TableLayoutPanel();
            this.lnkNotepad = new System.Windows.Forms.LinkLabel();
            this.lblGoof = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.tblLinkDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkPictureChange
            // 
            this.lnkPictureChange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkPictureChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkPictureChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPictureChange.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.lnkPictureChange.Location = new System.Drawing.Point(3, 51);
            this.lnkPictureChange.Name = "lnkPictureChange";
            this.lnkPictureChange.Size = new System.Drawing.Size(184, 48);
            this.lnkPictureChange.TabIndex = 0;
            this.lnkPictureChange.TabStop = true;
            this.lnkPictureChange.Text = "Click HERE to visit the bored button";
            this.lnkPictureChange.UseCompatibleTextRendering = true;
            this.lnkPictureChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPictureChange_LinkClicked);
            // 
            // tblLinkDemo
            // 
            this.tblLinkDemo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblLinkDemo.ColumnCount = 2;
            this.tblLinkDemo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLinkDemo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLinkDemo.Controls.Add(this.lnkPictureChange, 0, 1);
            this.tblLinkDemo.Controls.Add(this.lnkNotepad, 1, 1);
            this.tblLinkDemo.Controls.Add(this.lblGoof, 0, 0);
            this.tblLinkDemo.Controls.Add(this.lblWork, 1, 0);
            this.tblLinkDemo.Location = new System.Drawing.Point(12, 33);
            this.tblLinkDemo.Name = "tblLinkDemo";
            this.tblLinkDemo.RowCount = 2;
            this.tblLinkDemo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.8F));
            this.tblLinkDemo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.2F));
            this.tblLinkDemo.Size = new System.Drawing.Size(380, 125);
            this.tblLinkDemo.TabIndex = 1;
            // 
            // lnkNotepad
            // 
            this.lnkNotepad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lnkNotepad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNotepad.LinkArea = new System.Windows.Forms.LinkArea(13, 21);
            this.lnkNotepad.Location = new System.Drawing.Point(193, 51);
            this.lnkNotepad.Name = "lnkNotepad";
            this.lnkNotepad.Size = new System.Drawing.Size(184, 47);
            this.lnkNotepad.TabIndex = 0;
            this.lnkNotepad.TabStop = true;
            this.lnkNotepad.Text = "Get to work; Launch Notepad";
            this.lnkNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkNotepad.UseCompatibleTextRendering = true;
            this.lnkNotepad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNotepad_LinkClicked);
            // 
            // lblGoof
            // 
            this.lblGoof.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGoof.AutoSize = true;
            this.lblGoof.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoof.Location = new System.Drawing.Point(39, 3);
            this.lblGoof.Name = "lblGoof";
            this.lblGoof.Size = new System.Drawing.Size(112, 18);
            this.lblGoof.TabIndex = 1;
            this.lblGoof.Text = "For Goofing Off";
            // 
            // lblWork
            // 
            this.lblWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWork.AutoSize = true;
            this.lblWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWork.Location = new System.Drawing.Point(249, 3);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(72, 18);
            this.lblWork.TabIndex = 2;
            this.lblWork.Text = "For Work";
            // 
            // lnkDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 530);
            this.Controls.Add(this.tblLinkDemo);
            this.Name = "lnkDemo";
            this.Text = "Link Label Demo";
            this.tblLinkDemo.ResumeLayout(false);
            this.tblLinkDemo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkPictureChange;
        private System.Windows.Forms.TableLayoutPanel tblLinkDemo;
        private System.Windows.Forms.LinkLabel lnkNotepad;
        private System.Windows.Forms.Label lblGoof;
        private System.Windows.Forms.Label lblWork;
    }
}

