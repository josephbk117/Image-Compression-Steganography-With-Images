using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressionTest
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BW_compressionBtn_Click(object sender, EventArgs e)
        {
            Form bw = new Form1();
            bw.Show();
        }

        private void stenographyBtn_Click(object sender, EventArgs e)
        {
            Form st = new StegnographyForm();
            st.Show();
        }
    }
}
