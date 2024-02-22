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
    public partial class WriteCsv : Form
    {
        public WriteCsv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\psuur\Documents\hatdog.csv";
            var sw = new StreamWriter(path, true);
            sw.WriteLine($"{write.Text}");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
