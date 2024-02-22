using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grabe_naman_yung_seatwork_andami
{
    public partial class Options : Form
    {
        Form1 form1;

        public Options(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var isOpen = csvOpener.ShowDialog();

            if (isOpen == DialogResult.OK)
            {
                var sw = new StreamReader(csvOpener.FileName);

                while (!sw.EndOfStream)
                {
                    var line = sw.ReadLine();
                    
                    var data = line.Split(',');

                    if (data.Length < 7 || data.Length > 7)
                    {
                        MessageBox.Show("Mali ang data mo");
                        return;
                    }

                    form1.richOutput.AppendText($"{data[0]}\t{data[1]}\t{data[2]}\t\t{data[3]}\t{data[4]}\t\t{data[5]}\t\t{data[6]}\n");
                    
                }
                sw.Close();
                Close();
                return;
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var writeForm = new WriteCsv();
            writeForm.ShowDialog();
        }
    }
}
