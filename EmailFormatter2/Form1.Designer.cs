namespace EmailFormatter2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlFormattedMessage = new System.Windows.Forms.Panel();
            this.txtFormattedText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llGoToOriginalMessage = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudCharPerLine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOriginalMessage = new System.Windows.Forms.Panel();
            this.txtOrginalText = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.llGoToFormattedMessage = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFormattedMessage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharPerLine)).BeginInit();
            this.pnlOriginalMessage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormattedMessage
            // 
            this.pnlFormattedMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFormattedMessage.Controls.Add(this.txtFormattedText);
            this.pnlFormattedMessage.Controls.Add(this.panel1);
            this.pnlFormattedMessage.Controls.Add(this.panel4);
            this.pnlFormattedMessage.Location = new System.Drawing.Point(13, 22);
            this.pnlFormattedMessage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormattedMessage.Name = "pnlFormattedMessage";
            this.pnlFormattedMessage.Size = new System.Drawing.Size(899, 230);
            this.pnlFormattedMessage.TabIndex = 0;
            // 
            // txtFormattedText
            // 
            this.txtFormattedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormattedText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormattedText.Location = new System.Drawing.Point(0, 96);
            this.txtFormattedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormattedText.Multiline = true;
            this.txtFormattedText.Name = "txtFormattedText";
            this.txtFormattedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormattedText.Size = new System.Drawing.Size(895, 130);
            this.txtFormattedText.TabIndex = 6;
            this.txtFormattedText.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.llGoToOriginalMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 48);
            this.panel1.TabIndex = 7;
            // 
            // llGoToOriginalMessage
            // 
            this.llGoToOriginalMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.llGoToOriginalMessage.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGoToOriginalMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llGoToOriginalMessage.ImageList = this.imageList1;
            this.llGoToOriginalMessage.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.llGoToOriginalMessage.Location = new System.Drawing.Point(0, 0);
            this.llGoToOriginalMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llGoToOriginalMessage.Name = "llGoToOriginalMessage";
            this.llGoToOriginalMessage.Size = new System.Drawing.Size(323, 48);
            this.llGoToOriginalMessage.TabIndex = 10;
            this.llGoToOriginalMessage.TabStop = true;
            this.llGoToOriginalMessage.Text = "Go back to original  message ";
            this.llGoToOriginalMessage.UseCompatibleTextRendering = true;
            this.llGoToOriginalMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoToOriginalMessage_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "CheckedDoc.png");
            this.imageList1.Images.SetKeyName(1, "CheckedDocNot.png");
            this.imageList1.Images.SetKeyName(2, "CheckedDocNot2.png");
            this.imageList1.Images.SetKeyName(3, "CheckedDocNot3.png");
            this.imageList1.Images.SetKeyName(4, "CheckedDoc10.png");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(895, 48);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudCharPerLine);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(323, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 48);
            this.panel2.TabIndex = 11;
            // 
            // nudCharPerLine
            // 
            this.nudCharPerLine.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCharPerLine.ForeColor = System.Drawing.Color.DarkBlue;
            this.nudCharPerLine.Location = new System.Drawing.Point(4, 11);
            this.nudCharPerLine.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudCharPerLine.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCharPerLine.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCharPerLine.Name = "nudCharPerLine";
            this.nudCharPerLine.Size = new System.Drawing.Size(75, 30);
            this.nudCharPerLine.TabIndex = 4;
            this.nudCharPerLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharPerLine.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCharPerLine.ValueChanged += new System.EventHandler(this.cleanOriginalMessage);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.ImageIndex = 4;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "         Reformatted  with lines wrapped to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOriginalMessage
            // 
            this.pnlOriginalMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOriginalMessage.Controls.Add(this.txtOrginalText);
            this.pnlOriginalMessage.Controls.Add(this.panel5);
            this.pnlOriginalMessage.Controls.Add(this.panel3);
            this.pnlOriginalMessage.Location = new System.Drawing.Point(13, 283);
            this.pnlOriginalMessage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOriginalMessage.Name = "pnlOriginalMessage";
            this.pnlOriginalMessage.Size = new System.Drawing.Size(899, 230);
            this.pnlOriginalMessage.TabIndex = 1;
            // 
            // txtOrginalText
            // 
            this.txtOrginalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrginalText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginalText.Location = new System.Drawing.Point(0, 96);
            this.txtOrginalText.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrginalText.Multiline = true;
            this.txtOrginalText.Name = "txtOrginalText";
            this.txtOrginalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrginalText.Size = new System.Drawing.Size(895, 130);
            this.txtOrginalText.TabIndex = 6;
            this.txtOrginalText.Text = resources.GetString("txtOrginalText.Text");
            this.txtOrginalText.WordWrap = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.llGoToFormattedMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(895, 48);
            this.panel5.TabIndex = 7;
            // 
            // llGoToFormattedMessage
            // 
            this.llGoToFormattedMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.llGoToFormattedMessage.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGoToFormattedMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llGoToFormattedMessage.ImageList = this.imageList1;
            this.llGoToFormattedMessage.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.llGoToFormattedMessage.Location = new System.Drawing.Point(0, 0);
            this.llGoToFormattedMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llGoToFormattedMessage.Name = "llGoToFormattedMessage";
            this.llGoToFormattedMessage.Size = new System.Drawing.Size(351, 48);
            this.llGoToFormattedMessage.TabIndex = 8;
            this.llGoToFormattedMessage.TabStop = true;
            this.llGoToFormattedMessage.Text = "Clean and Reformat this  message ";
            this.llGoToFormattedMessage.UseCompatibleTextRendering = true;
            this.llGoToFormattedMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoToFormattedMessageClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 48);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.ImageIndex = 3;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(603, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "        Copy and paste your email message into the box below and then click ..";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 577);
            this.Controls.Add(this.pnlOriginalMessage);
            this.Controls.Add(this.pnlFormattedMessage);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Email Format Cleaner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFormattedMessage.ResumeLayout(false);
            this.pnlFormattedMessage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCharPerLine)).EndInit();
            this.pnlOriginalMessage.ResumeLayout(false);
            this.pnlOriginalMessage.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormattedMessage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFormattedText;
        private System.Windows.Forms.Panel pnlOriginalMessage;
        private System.Windows.Forms.TextBox txtOrginalText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llGoToFormattedMessage;
        private System.Windows.Forms.LinkLabel llGoToOriginalMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudCharPerLine;
        private System.Windows.Forms.Label label1;
    }
}

