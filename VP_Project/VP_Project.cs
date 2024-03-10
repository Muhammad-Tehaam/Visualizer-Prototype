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
    public partial class VP_Project : Form
    {
        //---------MDI Form-----------//
        FoorLoop FL = new FoorLoop();
        WhileLoop WL = new WhileLoop();
        DoWhile DW = new DoWhile();
        //
        public bool isForLoopOpen = false;
        public bool isWhileLoopOpen = false;
        public bool isDoWhileLoopOpen = false;
        public VP_Project()
        {
            InitializeComponent();
        }

        private void showRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FL.MdiParent = this;
            if (this.isForLoopOpen==true)
            {
                MessageBox.Show("For Loop Form is already Opened ! ");

            }
            else
            {

                FL.Show();
                isForLoopOpen = true;
            }
            if (isWhileLoopOpen == true) { WL.Visible=false; isWhileLoopOpen = false; }
            else if (isDoWhileLoopOpen == true) { DW.Visible=false; isDoWhileLoopOpen = false; }
          }

        private void whileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WL.MdiParent = this;
            if (this.isWhileLoopOpen==true)
            {
                MessageBox.Show("While Loop Form is already Opened ! ");

            }
            else
            {

                WL.Show();
                isWhileLoopOpen = true;
            }
            if (isForLoopOpen == true) { FL.Visible=false; isForLoopOpen = false; }
            else if (isDoWhileLoopOpen == true) { DW.Visible=false; isDoWhileLoopOpen = false; }
        }

        private void doWhileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DW.MdiParent = this;
            if (this.isDoWhileLoopOpen==true)
            {
                MessageBox.Show("Do While Loop Form is already Opened ! ");

            }
            else
            {

                DW.Show();
                isDoWhileLoopOpen = true;
            }
            if (isWhileLoopOpen == true) { WL.Visible=false; isWhileLoopOpen = false; }
            else if (isForLoopOpen == true) { FL.Visible=false; isForLoopOpen = false; }
        }

        private void VP_Project_Load(object sender, EventArgs e)
        {

        }

        private void VP_Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            FL.Close();
            DW.Close();
            WL.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
