/*   
 *   Author: Muhammad Tehaam
 *   Roll no: (BSCS)-01-134172-071
 *   YEAR: 2018
 *   
 *      " PROJECT FOR BEGINNERS TO LEARN LOOPING STRUCTURES "
 *
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
namespace VP_Project
{
    public partial class FoorLoop : Form
    {
        //
        //
        ArrayList loopLabels;
        ArrayList loopComboBox;
        string initialVariableValue = "";
        string operatorValue = "";
        string LimitValue = "";
        string LoopingValue = "";
        string variable = "";

        public FoorLoop()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += Animate;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //
        //Changing Text w.r.t the selected variable
        void changeText()
        {
            variableSelectedLB.Text = initialingVariableCB.SelectedItem.ToString();
            selectedVariableChange2.Text = initialingVariableCB.SelectedItem.ToString();
            selectedVariableChange3.Text = initialingVariableCB.SelectedItem.ToString();
        }
        //
        private void closeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            writeInstructionsLB.Visible = false;
            selectedVariableChange3.Visible = false;
            closeBracketsLB.Visible = false;
            arrowPB.Visible = false;

        }

        private void initialingVariableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeText();
            variable = initialingVariableCB.SelectedItem.ToString();
        }

        private void selectedVariableChange3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
   
        
        private void Animate(object sender,DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            if (operatorValue == "==" && LoopingValue == "++")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;

                for (int var = int.Parse(initialVariableValue); var == int.Parse(LimitValue); var++)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }
            //
            //
            else if (operatorValue == "==" && LoopingValue == "--")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;
                for (int var = int.Parse(initialVariableValue); var == int.Parse(LimitValue); var--)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }
            //
            //
            else if (operatorValue == ">=" && LoopingValue == "++")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;
                for (int var = int.Parse(initialVariableValue); var >= int.Parse(LimitValue); var++)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }
            //
            //
            else if (operatorValue == ">=" && LoopingValue == "--")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;
                for (int var = int.Parse(initialVariableValue); var >= int.Parse(LimitValue); var--)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }
            //
            //
            else if (operatorValue == "<=" && LoopingValue == "++")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;
                animateINT_VARIABLE_WITH_VALUE.Visible = false;
                for (int var = int.Parse(initialVariableValue); var <= int.Parse(LimitValue); var++)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }
            //
            //
            else if (operatorValue == "<=" && LoopingValue == "--")
            {
                Animate_conditionCheck.Visible = true;
                Animate_inLoopValueLB.Visible = true;
                for (int var = int.Parse(initialVariableValue); var <= int.Parse(LimitValue); var--)
                {
                    foreach (Label l in loopLabels)
                    {
                        arrowPB.Visible = false;
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (selectedVariableChange2.BackColor == Color.Green) { Animate_conditionCheck.Text = "Value of :" + initialingVariableCB.SelectedItem.ToString() + " is " + var; }
                        else if (var == int.Parse(LimitValue) && (variableSelectedLB.BackColor == Color.Green)) { Animate_conditionCheck.Text = "The Condition is met as " + initialingVariableCB.SelectedItem.ToString() + " = " + LimitValue; }
                        else if (closeBracketsLB.BackColor == Color.Green)
                        { Animate_inLoopValueLB.Text = "Writing value of " + variableSelectedLB.Text + " at this point is " + var + "\n" + " and it will be written on the Console" + "\n" + "using this Command !"; }
                        if (label10.BackColor == Color.Green)
                        {
                            animateOutPutLB.Text = "OutPut will give Value :  " + var;
                            arrowPB.Visible = true;
                            Thread.Sleep(1000);
                        }
                        l.BackColor = Color.White;
                    }
                    richTextBox1.Text += "Value : " + var + "\n";
                }
                Animate_conditionCheck.Visible = false;
                Animate_inLoopValueLB.Visible = false;
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            writeInstructionsLB.Visible = true;
            selectedVariableChange3.Visible = true;
            closeBracketsLB.Visible = true;
            richTextBox1.Text = "";
            if(initialingVariableCB.SelectedItem==null|| initalValueOfVariableCB.SelectedItem==null|| conditionForVariableCB.SelectedItem==null|| conditionValueForVariableCB.SelectedItem==null|| variableValueChangeCB.SelectedItem==null)
            {
                MessageBox.Show("Please Enter all the Specified Fields ! ");

            }
            else { forLoop(); }
            
        }

        void check()
        {
            if (richTextBox1.Text == "")
            {
                errorProvider1.SetError(button1, "The Logical Operators are not set Correctly  !");
                errorProvider1.Icon = Properties.Resources.CrossMini;
            }
            else
            {
                errorProvider1.SetError(button1, "Execution is Done ! ");
                errorProvider1.Icon = Properties.Resources.TickMini;
            }
        }
        
        //
        //
        //For Loop 
        void forLoop()
        {

            animateINT_VARIABLE_WITH_VALUE.Text = "Variable : " + initialingVariableCB.SelectedItem.ToString() + " is initialized with : " + initalValueOfVariableCB.SelectedItem.ToString();
            loopLabels = new ArrayList();
            loopLabels.Add(forLB);
            loopLabels.Add(forStartingBRLB);
            loopLabels.Add(intLB);
            loopLabels.Add(equalsToLB);
            loopLabels.Add(semicolonLB);
            loopLabels.Add(variableSelectedLB);
            loopLabels.Add(secondsemicolonLB);
            loopLabels.Add(selectedVariableChange2);
            loopLabels.Add(closingBRLB);
            loopLabels.Add(openingBR);
            loopLabels.Add(writeInstructionsLB);
            loopLabels.Add(selectedVariableChange3);
            loopLabels.Add(closeBracketsLB);
            loopLabels.Add(label10);
            loopComboBox = new ArrayList();
            loopComboBox.Add(initialingVariableCB);
            loopComboBox.Add(initalValueOfVariableCB);
            loopComboBox.Add(conditionForVariableCB);
            loopComboBox.Add(conditionValueForVariableCB);
            loopComboBox.Add(variableValueChangeCB);
            backgroundWorker1.RunWorkerAsync();






            //if (operatorValue=="=="&&LoopingValue=="++")
            //{
                
            //    for (int var = int.Parse(initialVariableValue); var == int.Parse(LimitValue);var++)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //        richTextBox1.Text += "Value : " + var+"\n";
            //    }
            //}
            //
            //else if (operatorValue == "==" && LoopingValue == "--")
            //{
            //    for (int var = int.Parse(initialVariableValue); var == int.Parse(LimitValue); var--)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //        richTextBox1.Text += "Value : " + var + "\n";
            //    }
            //}
            //
            //else if (operatorValue == ">=" && LoopingValue == "++")
            //{
               
            //    for (int var = int.Parse(initialVariableValue); var >= int.Parse(LimitValue); var++)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //        richTextBox1.Text += "Value : " + var + "\n";
            //    }
            //}
            //
            //else if (operatorValue == ">=" && LoopingValue == "--")
            //{
            //    for (int var = int.Parse(initialVariableValue); var >= int.Parse(LimitValue); var--)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //        richTextBox1.Text += "Value : " + var + "\n";
            //    }
            //}
            //
            //else if (operatorValue == "<=" && LoopingValue == "++")
            //{
              

            //    //for (int var = int.Parse(initialVariableValue); var <= int.Parse(LimitValue); var++)
            //    //{
            //    //    richTextBox1.Text += "Value : " + var + "\n";
            //    //}
           
            //}
            //
            //else if (operatorValue == "<=" && LoopingValue == "--")
            //{
               
            //    for (int var = int.Parse(initialVariableValue); var <= int.Parse(LimitValue); var--)
            //    {
            //        backgroundWorker1.RunWorkerAsync();
            //        richTextBox1.Text += "Value : " + var + "\n";
            //    }
               
            //}
            //
           


        }

        private void initalValueOfVariableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialVariableValue = initalValueOfVariableCB.SelectedItem.ToString();
        }

        private void conditionForVariableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            operatorValue = conditionForVariableCB.SelectedItem.ToString();
        }

        private void conditionValueForVariableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimitValue = conditionValueForVariableCB.SelectedItem.ToString();
        }

        private void variableValueChangeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoopingValue = variableValueChangeCB.SelectedItem.ToString();
        }

        private void forLB_ForeColorChanged(object sender, EventArgs e)
        {
       
        }
    }
}
