using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace BlocoDeNotas
{
    public partial class Janela : Form
    {
        Thread t1;

        public Janela()
        {
            InitializeComponent();
        }

        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private FontDialog alterFont;

        //Format Text
        private void Janela_Load(object sender, EventArgs e)
        {
            alterFont = new FontDialog();
        }

        //Functions for open and save files
        private void OpenFile()
        {
            try
            {
                openFile = new OpenFileDialog();

                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = File.ReadAllText(openFile.FileName);
                    this.Text = openFile.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                openFile = null;
            }
        }

        private void SaveFile()
        {
            try
            {
                saveFile = new SaveFileDialog();
                saveFile.Filter = "Arquivo de Texto (*.txt) | *.txt";

                if(saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, this.richTextBox1.Text);
                    this.Text = saveFile.FileName;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                saveFile = null;
            }
        }

        //Open file local
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        //Save file local
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //Format Text
        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(alterFont.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Font = alterFont.Font;
                }
            }
            catch (Exception ex)
            {

            }
        }

        //Return Page
        private void returnWindow(object obj)
        {
            Application.Run(new Principal());
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(returnWindow);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
