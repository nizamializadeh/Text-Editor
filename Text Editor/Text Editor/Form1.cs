using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.SelectAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            text.SelectAll();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Bold);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            text.Undo();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            text.Redo();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            about about = new about();
            about.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void size14ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Italic);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Underline);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Strikeout);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = text.SelectionColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            colorDialog1.Color != text.SelectionColor)
            {
                text.SelectionColor = colorDialog1.Color;
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Regular);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            text.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            text.SelectionIndent += text.SelectionIndent = 20;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            text.SelectionIndent += text.SelectionIndent = -20;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = text.SelectionColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            colorDialog1.Color != text.SelectionColor)
            {
                text.SelectionColor = colorDialog1.Color;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Underline);
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Font = new Font(text.Font, FontStyle.Strikeout);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd1 = new FontDialog();
            fd1.Font = text.SelectionFont;

            if (fd1.ShowDialog() != DialogResult.Cancel)
            {
                text.Font = fd1.Font;
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            text.Font = new Font("regular", 38);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void a(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var z = Convert.ToInt16(button.Text);
            text.Font = new Font("regular", z);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter SW = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false, Encoding.ASCII);
                SW.Write(text.Text);
                SW.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(OpenFileDialog.FileName);
                text.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
         
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
          SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (text.Text.Length > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter SW = new System.IO.StreamWriter(
                        saveFileDialog1.FileName, false, Encoding.ASCII);
                    SW.Write(text.Text);
                    SW.Close();
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Show the Open File dialog. If the user clicks OK, load the 
                // picture that the user chose.   
                pictureBox2.Load(OpenFileDialog.FileName);
                Clipboard.SetImage(pictureBox2.Image);
                pictureBox2.Image = null;
                this.text.Paste();

            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Form1 mirrorForm = new Form1();
            //Copy the content.
            mirrorForm.text.Rtf = this.text.Rtf;
            //Enable mirror.
            mirrorForm.text.RightToLeft = RightToLeft.Yes;
            mirrorForm.Show();
        }
    }
}
