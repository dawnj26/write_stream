using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grabe_naman_yung_seatwork_andami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
            richOutput.Text = "STUDENT ID\tNAME\t\t\tCOURSE\t\tYEAR\tSECTION\t\tSUBJECT\tGRADE\n";
            Options options = new Options(this);
            options.ShowDialog();
        }
    }
}
