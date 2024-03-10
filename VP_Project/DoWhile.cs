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
    public partial class DoWhile : Form
    {
        string valueFromWhile2 = "";
        string initialVariableVal = "";
        ArrayList loopLabels;
        ArrayList while2loopLabels;
        //
        public DoWhile()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += Animate;
            backgroundWorker2.DoWork += Animate2;

        }
        //
        //
        private void Animate(object sender, DoWorkEventArgs e)
        {
            //While 1
            if (while1ConditionCB.SelectedItem.ToString() == "true")
            {
                boolLB.BackColor = Color.Green;
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Text = "Initial Variable " + while1VariableSelectionCB.SelectedItem.ToString() + " has a return type Bool, Set to : " + while1ConditionCB.SelectedItem.ToString();
                Thread.Sleep(1000);
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Text = "";
                boolLB.BackColor = Color.White;
                //
                while1EqualsLB.BackColor = Color.Green;

                Thread.Sleep(1000);
                while1EqualsLB.BackColor = Color.White;
                //
                intNoWhile1LB.BackColor = Color.Green;
                AnimateintWhile1NOLB.Text = "An Integer Variable no is initialized with 0";
                Thread.Sleep(1000);
                AnimateintWhile1NOLB.Text = "";
                intNoWhile1LB.BackColor = Color.White;
                //
                bool n = true;
                int no = 0;

                do
                {
                    arrowPB.Visible = false;
                    foreach (Label l in loopLabels)
                    {
                        if (no < 4)
                        {
                            l.BackColor = Color.Green;

                            While1InnerLoopLB2.BackColor = Color.White;
                            While1InnerLoopLB3.BackColor = Color.White;
                            While1InnerLoopLB4.BackColor = Color.White;
                            While1InnerLoopLB6.BackColor = Color.White;
                            varianbleBoolCheckLB.BackColor = Color.White;
                            Thread.Sleep(1000);
                            if (while1VariableNameLB.BackColor == Color.Green)
                            {
                                animateWhile1ConditionLB.Text = "The Condition is " + while1ConditionCB.SelectedItem.ToString();
                            }
                            else if (While1InnerLoopLB1.BackColor == Color.Green)
                            {
                                animateWhile1IfConditionLB.Text = "As Condition is false , Body will not execute!";
                            }
                            else if (While1InnerLoopLB7.BackColor == Color.Green)
                            {
                                animateWhile1IncreamentLB.Text = "no is increamented by 1 and the updated no value is :" + (no + 1);
                            }
                            else if (While1InnerLoopLB8.BackColor == Color.Green)
                            {
                                animateWhile1PrintLB.Text = "The Output Console will print Value ";
                            }
                            else if (while1StartingBRLB.BackColor == Color.Green)
                            {
                                arrowPB.Visible = true;
                                Thread.Sleep(1000);
                            }

                            l.BackColor = Color.White;
                        }
                        else
                        {
                            l.BackColor = Color.Green;
                            Thread.Sleep(1000);
                            if (while1StartBRLB.BackColor == Color.Green)
                            {
                                animateWhile1IfConditionLB.Text = "Condition is true , body will be executed!";
                            }
                            else if (While1InnerLoopLB4.BackColor == Color.Green)
                            {
                                animateInnerIfWhile1LB.Text = "The Variable " + varianbleBoolCheckLB.Text + " is set to " + While1InnerLoopLB4.Text;
                            }
                            else if (while1StartingBRLB.BackColor == Color.Green)
                            {
                                arrowPB.Visible = true;
                                Thread.Sleep(1000);
                            }
                            l.BackColor = Color.White;

                        }
                    }
                    if (no >= 4)
                    {
                        n = false;
                    }
                    no = no + 1;
                    richTextBox1.Text += "Value : " + no + "\n";
                } while (n);
                whileLB1.BackColor = Color.Green;
                while1VariableNameLB.BackColor = Color.Green;
                while1CEndLB.BackColor = Color.Green;
                Thread.Sleep(1000);
                whileLB1.BackColor = Color.Red;
                while1VariableNameLB.BackColor = Color.Red;
                while1CEndLB.BackColor = Color.Red;
                //
                animateWhile1ConditionLB.Text = "The Condition is false , So Execution Ends here !";
                AnimateintWhile1NOLB.Text = "";
                animateWhile1IfConditionLB.Text = "";
                animateInnerIfWhile1LB.Text = "";
                animateWhile1IncreamentLB.Text = "";
                animateWhile1PrintLB.Text = "";
            }
            //
            //
            //
            else if (while1ConditionCB.SelectedItem.ToString() == "false")
            {
                boolLB.BackColor = Color.Green;
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Text = "Initial Variable " + while1VariableSelectionCB.SelectedItem.ToString() + " has a return type Bool, Set to : " + while1ConditionCB.SelectedItem.ToString();
                Thread.Sleep(1000);
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Text = "";
                boolLB.BackColor = Color.White;
                //
                while1EqualsLB.BackColor = Color.Green;

                Thread.Sleep(1000);
                while1EqualsLB.BackColor = Color.White;
                //
                intNoWhile1LB.BackColor = Color.Green;
                AnimateintWhile1NOLB.Text = "An Integer Variable no is initialized with 0";
                Thread.Sleep(1000);
                AnimateintWhile1NOLB.Text = "";
                intNoWhile1LB.BackColor = Color.White;
                //

                bool n = false;
                int no = 0;
                do
                {
                    arrowPB.Visible = false;
                    foreach (Label l in loopLabels)
                    {
                        if (no < 4)
                        {
                            l.BackColor = Color.Green;

                            While1InnerLoopLB2.BackColor = Color.White;
                            While1InnerLoopLB3.BackColor = Color.White;
                            While1InnerLoopLB4.BackColor = Color.White;
                            While1InnerLoopLB6.BackColor = Color.White;
                            varianbleBoolCheckLB.BackColor = Color.White;
                            Thread.Sleep(1000);
                            if (while1VariableNameLB.BackColor == Color.Green)
                            {
                                animateWhile1ConditionLB.Text = "The Condition is " + while1ConditionCB.SelectedItem.ToString();
                            }
                            else if (While1InnerLoopLB1.BackColor == Color.Green)
                            {
                                animateWhile1IfConditionLB.Text = "As Condition is false , Body will not execute!";
                            }
                            else if (While1InnerLoopLB7.BackColor == Color.Green)
                            {
                                animateWhile1IncreamentLB.Text = "no is increamented by 1 and the updated no value is :" + (no + 1);
                            }
                            else if (While1InnerLoopLB8.BackColor == Color.Green)
                            {
                                animateWhile1PrintLB.Text = "The Output Console will print Value ";
                            }
                            else if (while1StartingBRLB.BackColor == Color.Green)
                            {
                                arrowPB.Visible = true;
                                Thread.Sleep(1000);
                            }

                            l.BackColor = Color.White;
                        }
                        else
                        {
                            l.BackColor = Color.Green;
                            Thread.Sleep(1000);
                            if (while1StartBRLB.BackColor == Color.Green)
                            {
                                animateWhile1IfConditionLB.Text = "Condition is true , body will be executed!";
                            }
                            else if (While1InnerLoopLB4.BackColor == Color.Green)
                            {
                                animateInnerIfWhile1LB.Text = "The Variable " + varianbleBoolCheckLB.Text + " is set to " + While1InnerLoopLB4.Text;
                            }
                            else if (while1StartingBRLB.BackColor == Color.Green)
                            {
                                arrowPB.Visible = true;
                                Thread.Sleep(1000);
                            }
                            l.BackColor = Color.White;

                        }
                    }

                    //
                    if (no >= 4)
                    {
                        n = true;
                    }
                    no = no + 1;
                    richTextBox1.Text += "Value : " + no + "\n";
                } while (n == false);
                whileLB1.BackColor = Color.Green;
                while1VariableNameLB.BackColor = Color.Green;
                while1CEndLB.BackColor = Color.Green;
                Thread.Sleep(1000);
                whileLB1.BackColor = Color.Red;
                while1VariableNameLB.BackColor = Color.Red;
                while1CEndLB.BackColor = Color.Red;
                //
                animateWhile1ConditionLB.Text = "The Condition is true , So Execution Ends here !";
                AnimateintWhile1NOLB.Text = "";
                animateWhile1IfConditionLB.Text = "";
                animateInnerIfWhile1LB.Text = "";
                animateWhile1IncreamentLB.Text = "";
                animateWhile1PrintLB.Text = "";
            }

            //
            //
            if (richTextBox1.Text == "")
            {
                errorProvider1.SetError(executeBT, "The Logical Operators are not set Correctly  !");
                errorProvider1.Icon = Properties.Resources.CrossMini;
            }
            else
            {
                errorProvider1.SetError(executeBT, " ");
                errorProvider1.Icon = Properties.Resources.TickMini;
            }
        }
        //
        //
        // While 2
        private void Animate2(object sender, DoWorkEventArgs e)
        {
            while2initalValueLB.BackColor = Color.Green;
            Thread.Sleep(1000);
            while2initalValueLB.BackColor = Color.White;
            while2EqualsLB.BackColor = Color.Green;
            animateWhile2InitiateVariableLB.Text = "Variable " + while2VariableSelectionCB.SelectedItem.ToString() + " is initiated with " + initialVariableValueCB.SelectedItem.ToString();
            Thread.Sleep(2000);
            while2EqualsLB.BackColor = Color.White;
            animateWhile2InitiateVariableLB.Text = "";
            int nu = int.Parse(initialVariableVal);
            if (while2ConditionCB.SelectedItem.ToString() == ">")
            {
                do
                {
                    closeBracketsLB.Text = "-1)) ;";
                    pictureBox1.Visible = false;
                    foreach (Label l in while2loopLabels)
                    {
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (whileLB2.BackColor == Color.Green)
                        {
                            animateWhile2ConditionLB.Text = "Condition is set as " + while2VariableNameSelectionFromcbLB.Text + " is " + while2ConditionCB.SelectedItem.ToString() + " " + while2ConditionLoopLimitCB.SelectedItem.ToString() + "\n" + "Which is TRUE";
                        }
                        else if (writeInstructionsLB.BackColor == Color.Green)
                        {
                            animateWhile2PrintLB.Text = "Value of " + while2VariableNameSelectionFromcbLB.Text + " is de-creamented by 1 \n" + " Updated Value is " + (nu - 1);
                        }
                        l.BackColor = Color.White;
                    }
                    pictureBox1.Visible = true;
                    nu = nu - 1;
                    richTextBox2.Text += "Value : " + nu + "\n";
                    Thread.Sleep(1000);

                } while (nu > int.Parse(valueFromWhile2));
                whileLB2.BackColor = Color.Red;
                while2VariableNameSelectionFromcbLB.BackColor = Color.Red;
                while2CEndLB.BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";

            }
            else if (while2ConditionCB.SelectedItem.ToString() == "<")
            {

                do
                {
                    closeBracketsLB.Text = "+1)) ;";
                    pictureBox1.Visible = false;
                    foreach (Label l in while2loopLabels)
                    {
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (whileLB2.BackColor == Color.Green)
                        {
                            animateWhile2ConditionLB.Text = "Condition is set as " + while2VariableNameSelectionFromcbLB.Text + " is " + while2ConditionCB.SelectedItem.ToString() + " " + while2ConditionLoopLimitCB.SelectedItem.ToString() + "\n" + "Which is TRUE";
                        }
                        else if (writeInstructionsLB.BackColor == Color.Green)
                        {
                            animateWhile2PrintLB.Text = "Value of " + while2VariableNameSelectionFromcbLB.Text + " is increamented by 1 \n" + " Updated Value is " + (nu + 1);
                        }
                        l.BackColor = Color.White;
                    }
                    pictureBox1.Visible = true;
                    nu = nu + 1;
                    pictureBox1.Visible = true;
                    richTextBox2.Text += "Value : " + nu + "\n";
                    Thread.Sleep(1000);

                } while (nu < int.Parse(valueFromWhile2));
                whileLB2.BackColor = Color.Red;
                while2VariableNameSelectionFromcbLB.BackColor = Color.Red;
                while2CEndLB.BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";
            }
            else if (while2ConditionCB.SelectedItem.ToString() == "==")
            {
                closeBracketsLB.Text = "+1)) ;";
                do
                {
                    pictureBox1.Visible = false;
                    foreach (Label l in while2loopLabels)
                    {
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if (whileLB2.BackColor == Color.Green)
                        {
                            animateWhile2ConditionLB.Text = "Condition is set as " + while2VariableNameSelectionFromcbLB.Text + " is " + while2ConditionCB.SelectedItem.ToString() + " " + while2ConditionLoopLimitCB.SelectedItem.ToString() + "\n" + "Which is TRUE";
                        }
                        else if (writeInstructionsLB.BackColor == Color.Green)
                        {
                            animateWhile2PrintLB.Text = "Value of " + while2VariableNameSelectionFromcbLB.Text + " is increamented by 1 \n" + " Updated Value is " + (nu + 1);
                        }
                        l.BackColor = Color.White;
                    }
                    pictureBox1.Visible = true;
                    nu = nu + 1;
                    richTextBox2.Text += "Value : " + nu + "\n";
                    Thread.Sleep(1000);

                } while (nu == int.Parse(valueFromWhile2));
                whileLB2.BackColor = Color.Red;
                while2VariableNameSelectionFromcbLB.BackColor = Color.Red;
                while2CEndLB.BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";
            }
        }
        private void closeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void executeBT_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if (while1EnableRB.Checked == true)
            {
                While1InnerLoopLB1.Visible = true;
                While1InnerLoopLB2.Visible = true;
                While1InnerLoopLB3.Visible = true;
                While1InnerLoopLB4.Visible = true;
                While1InnerLoopLB6.Visible = true;
                While1InnerLoopLB7.Visible = true;
                While1InnerLoopLB8.Visible = true;
                writeInstructionsLB.Visible = false;
                selectedVariableChange3.Visible = false;
                closeBracketsLB.Visible = false;
                intNoWhile1LB.Visible = true;
                label12.Visible = true;
                label5.Visible = false;
                if(while1VariableSelectionCB.SelectedItem==null|| while1ConditionCB.SelectedItem == null)
                {
                    MessageBox.Show("Please Enter All the Given Fields !");
                }
                else { while1(); }
                
            }
            else if (while2EnableRB.Checked == true)
            {
                label5.Visible = false;
                label12.Visible = false;
                While1InnerLoopLB1.Visible = false;
                While1InnerLoopLB2.Visible = false;
                While1InnerLoopLB3.Visible = false;
                While1InnerLoopLB4.Visible = false;
                While1InnerLoopLB6.Visible = false;
                While1InnerLoopLB7.Visible = false;
                While1InnerLoopLB8.Visible = false;
                writeInstructionsLB.Visible = true;
                selectedVariableChange3.Visible = true;
                closeBracketsLB.Visible = true;
                intNoWhile1LB.Visible = false;
                if(while2VariableSelectionCB.SelectedItem == null || initialVariableValueCB.SelectedItem == null || while2ConditionCB.SelectedItem == null || while2ConditionLoopLimitCB.SelectedItem == null)
                {
                    MessageBox.Show("Please Enter All the Given Fields !");
                }
                else { while2Condition(); }
                
            }
            
        }
        //
        // While 1 Implementation
        void while1()
        {
            //
            //
            loopLabels = new ArrayList();
            loopLabels.Add(Do1LB);
            loopLabels.Add(while1StartBRLB);
            loopLabels.Add(While1InnerLoopLB1);
            loopLabels.Add(While1InnerLoopLB2);
            loopLabels.Add(While1InnerLoopLB3);
            loopLabels.Add(While1InnerLoopLB4);
            loopLabels.Add(While1InnerLoopLB6);
            loopLabels.Add(While1InnerLoopLB7);
            loopLabels.Add(While1InnerLoopLB8);
            loopLabels.Add(while1StartingBRLB);
            loopLabels.Add(whileLB1);
            loopLabels.Add(while1VariableNameLB);
            loopLabels.Add(while1CEndLB);
            backgroundWorker1.RunWorkerAsync();
            
        }
        //Do While Load
        private void DoWhile_Load(object sender, EventArgs e)
        {
            RadioButtonCheck();
            While1InnerLoopLB1.Visible = false;
            While1InnerLoopLB2.Visible = false;
            While1InnerLoopLB3.Visible = false;
            While1InnerLoopLB4.Visible = false;
            While1InnerLoopLB6.Visible = false;
            While1InnerLoopLB7.Visible = false;
            While1InnerLoopLB8.Visible = false;
            writeInstructionsLB.Visible = false;
            selectedVariableChange3.Visible = false;
            closeBracketsLB.Visible = false;
            intNoWhile1LB.Visible = false;
            arrowPB.Visible = false;
            pictureBox1.Visible = false;
        }
        //
        //Enablig on Radio Buttons
        void RadioButtonCheck()
        {
            if (while1EnableRB.Checked == true)
            {
                while1CEndLB.Enabled = true;
                while1ConditionCB.Enabled = true;
                while1StartBRLB.Enabled = true;
                while1StartingBRLB.Enabled = true;
                whileLB1.Enabled = true;
                while2CEndLB.Enabled = false;
                while2ConditionCB.Enabled = false;
                while2ConditionLoopLimitCB.Enabled = false;
                while2StartBRLB.Enabled = false;
                while2VariableSelectionCB.Enabled = false;
                whileLB2.Enabled = false;
                whileStartBRLB.Enabled = false;
                while2VariableSelectionCB.Enabled = false;
                while2EqualsLB.Enabled = false;
                initialVariableValueCB.Enabled = false;
                while2initalValueLB.Enabled = false;
                while1EqualsLB.Enabled = true;
                while1VariableSelectionCB.Enabled = true;
                boolLB.Enabled = true;
                Do1LB.Enabled = true;
                Do2LB.Enabled = false;
            }
            else if (while2EnableRB.Checked == true)
            {
                while1CEndLB.Enabled = false;
                while1ConditionCB.Enabled = false;
                while1StartBRLB.Enabled = false;
                while1StartingBRLB.Enabled = false;
                whileLB1.Enabled = false;
                while2CEndLB.Enabled = true;
                while2ConditionCB.Enabled = true;
                while2ConditionLoopLimitCB.Enabled = true;
                while2StartBRLB.Enabled = true;
                while2VariableSelectionCB.Enabled = true;
                whileLB2.Enabled = true;
                whileStartBRLB.Enabled = true;
                while2VariableSelectionCB.Enabled = true;
                while2EqualsLB.Enabled = true;
                initialVariableValueCB.Enabled = true;
                while2initalValueLB.Enabled = true;
                while1EqualsLB.Enabled = false;
                while1VariableSelectionCB.Enabled = false;
                boolLB.Enabled = false;
                Do1LB.Enabled = false;
                Do2LB.Enabled = true;
            }
        }
        //
        //While 2 Condition (FOR VALUES !)
        void while2Condition()
        {
            while2loopLabels = new ArrayList();
            while2loopLabels.Add(whileStartBRLB);
            while2loopLabels.Add(writeInstructionsLB);
            while2loopLabels.Add(selectedVariableChange3);
            while2loopLabels.Add(closeBracketsLB);
            while2loopLabels.Add(while2StartBRLB);
            while2loopLabels.Add(whileLB2);
            while2loopLabels.Add(while2VariableNameSelectionFromcbLB);
            while2loopLabels.Add(while2CEndLB);
            backgroundWorker2.RunWorkerAsync();
           
        }
        //
        private void while1EnableRB_CheckedChanged_1(object sender, EventArgs e)
        {//
            RadioButtonCheck();
        }
        //
        private void while2EnableRB_CheckedChanged(object sender, EventArgs e)
        {//
            RadioButtonCheck();
        }
        //
        //
        private void initialVariableValueCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            initialVariableVal = initialVariableValueCB.SelectedItem.ToString();
        }
        //
        private void while1VariableSelectionCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            while1VariableNameLB.Text = while1VariableSelectionCB.SelectedItem.ToString();
            varianbleBoolCheckLB.Text = while1VariableSelectionCB.SelectedItem.ToString();
        }
        //
        private void while1ConditionCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (while1ConditionCB.SelectedItem.ToString() == "true")
            {
                While1InnerLoopLB4.Text = "false ;";
                while1CEndLB.Text = ")";

            }
            else if (while1ConditionCB.SelectedItem.ToString() == "false")
            {
                While1InnerLoopLB4.Text = "true ;";
                while1CEndLB.Text = "== false)";
            }
        }
        //
        private void while2VariableSelectionCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedVariableChange3.Text = while2VariableSelectionCB.SelectedItem.ToString();
            while2VariableNameSelectionFromcbLB.Text = while2VariableSelectionCB.SelectedItem.ToString();
        }
        //
        private void while2ConditionLoopLimitCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            valueFromWhile2 = while2ConditionLoopLimitCB.SelectedItem.ToString();
        }
        //
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
