using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class MainTempForm : Form
    {
        public MainTempForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoorLoop f = new FoorLoop();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WhileLoop w = new WhileLoop();
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoWhile d = new DoWhile();
            d.Show();
        }
    }
}
