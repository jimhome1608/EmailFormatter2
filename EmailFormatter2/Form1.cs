using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailFormatter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlFormattedMessage.Hide();
            pnlOriginalMessage.Dock = DockStyle.Fill;
            pnlFormattedMessage.Dock = DockStyle.Fill;
           // pictureBox1.Image = imageList1.Images[0];
        }

        private void cleanOriginalMessage(object sender, EventArgs e)
        {
            String orginalMessage = txtOrginalText.Text.Replace("> ", "");
            String[] messageLines = orginalMessage.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            // txtFormattedText.Text = messageLines.Count().ToString() + "\r\n";
            txtFormattedText.Text = "";
            int CharPerLine = (int)nudCharPerLine.Value;
            foreach (string eachLine in messageLines)
            {
                String formatLine = eachLine;
                while (formatLine.Length > CharPerLine)
                {
                    Boolean foundSpaceToBreakOn = false;
                    // Find the right most space to break on.
                    for (int charIndex = CharPerLine - 1; charIndex >= 0; charIndex--)
                    {
                        if (formatLine[charIndex] == ' ')
                        {
                            String shortLine = formatLine.Substring(0, charIndex);
                            txtFormattedText.Text = txtFormattedText.Text + "\r\n" + shortLine;
                            formatLine = formatLine.Substring(charIndex + 1);
                            foundSpaceToBreakOn = true;
                            break;
                        }
                    }
                    if (!foundSpaceToBreakOn)
                    {
                        String shortLine = formatLine.Substring(0, CharPerLine - 1);
                        txtFormattedText.Text = txtFormattedText.Text + "\r\n" + shortLine;
                        formatLine = formatLine.Substring(CharPerLine);
                    }
                }
                txtFormattedText.Text = txtFormattedText.Text + "\r\n" + formatLine;
            }
        }

        private void llGoToFormattedMessageClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cleanOriginalMessage(sender, e);
            pnlOriginalMessage.Hide();
            pnlFormattedMessage.Show();
        }

        private void llGoToOriginalMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlFormattedMessage.Hide();
            pnlOriginalMessage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

   
    }
}
