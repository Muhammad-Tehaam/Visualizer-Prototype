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
    public partial class WhileLoop : Form
    {
        ArrayList loopLabels;
        ArrayList while2loopLabels;
        string valueFromWhile2 = "";
        string initialVariableVal = "";
        public WhileLoop()
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

                while (n)
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
                            else if(While1InnerLoopLB1.BackColor==Color.Green)
                            {
                                animateWhile1IfConditionLB.Text = "As Condition is false , Body will not execute!";
                            }
                            else if(While1InnerLoopLB7.BackColor==Color.Green)
                            {
                                animateWhile1IncreamentLB.Text = "no is increamented by 1 and the updated no value is :" +(no+1);
                            }
                            else if(While1InnerLoopLB8.BackColor==Color.Green)
                            {
                                animateWhile1PrintLB.Text = "The Output Console will print Value " ;
                            }
                            else if(while1StartingBRLB.BackColor==Color.Green)
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
                }
                (loopLabels[0] as Label).BackColor = Color.Green;
                (loopLabels[1] as Label).BackColor = Color.Green;
                (loopLabels[2] as Label).BackColor = Color.Green;
                Thread.Sleep(1000);
                (loopLabels[0] as Label).BackColor = Color.Red;
                (loopLabels[1] as Label).BackColor = Color.Red;
                (loopLabels[2] as Label).BackColor = Color.Red;
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
                while (n == false)
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
                }
                 (loopLabels[0] as Label).BackColor = Color.Green;
            (loopLabels[1] as Label).BackColor = Color.Green;
            (loopLabels[2] as Label).BackColor = Color.Green;
            Thread.Sleep(1000);
            (loopLabels[0] as Label).BackColor = Color.Red;
            (loopLabels[1] as Label).BackColor = Color.Red;
            (loopLabels[2] as Label).BackColor = Color.Red;
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
            animateWhile2InitiateVariableLB.Text = "Variable " + while2VariableSelectionCB.SelectedItem.ToString()+ " is initiated with " + initialVariableValueCB.SelectedItem.ToString();
            Thread.Sleep(2000);
            while2EqualsLB.BackColor = Color.White;
            animateWhile2InitiateVariableLB.Text = "";
            int nu = int.Parse(initialVariableVal);
            if (while2ConditionCB.SelectedItem.ToString() == ">")
            {
                while (nu > int.Parse(valueFromWhile2))
                {
                    closeBracketsLB.Text = "-1)) ;";
                    pictureBox1.Visible = false;
                    foreach (Label l in while2loopLabels)
                    {
                        l.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        if(whileLB2.BackColor==Color.Green)
                        {
                            animateWhile2ConditionLB.Text = "Condition is set as " + while2VariableNameSelectionFromcbLB.Text + " is " + while2ConditionCB.SelectedItem.ToString()+" "+ while2ConditionLoopLimitCB.SelectedItem.ToString()+"\n"+"Which is TRUE";
                        }
                        else if(writeInstructionsLB.BackColor==Color.Green)
                        {
                            animateWhile2PrintLB.Text = "Value of " + while2VariableNameSelectionFromcbLB.Text + " is de-creamented by 1 \n" + " Updated Value is " + (nu - 1);
                        }
                        l.BackColor = Color.White;
                    }
                    pictureBox1.Visible = true;
                    nu = nu - 1;
                    richTextBox2.Text += "Value : " + nu + "\n";
                    Thread.Sleep(1000);
            
                }
                        (while2loopLabels[0] as Label).BackColor = Color.Red;
                (while2loopLabels[1] as Label).BackColor = Color.Red;
                (while2loopLabels[2] as Label).BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";

            }
            else if (while2ConditionCB.SelectedItem.ToString() == "<")
            {
              
                while (nu < int.Parse(valueFromWhile2))
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
                   
                }
                 (while2loopLabels[0] as Label).BackColor = Color.Red;
                (while2loopLabels[1] as Label).BackColor = Color.Red;
                (while2loopLabels[2] as Label).BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";
            }
            else if (while2ConditionCB.SelectedItem.ToString() == "==")
            {
                closeBracketsLB.Text = "+1)) ;";
                while (nu == int.Parse(valueFromWhile2))
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
                   
                }
                 (while2loopLabels[0] as Label).BackColor = Color.Red;
                (while2loopLabels[1] as Label).BackColor = Color.Red;
                (while2loopLabels[2] as Label).BackColor = Color.Red;
                animateWhile2ConditionLB.Text = "Condition is False Execution Ends here !";
                animateWhile2PrintLB.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WhileLoop_Load(object sender, EventArgs e)
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
            //
            //
            loopLabels = new ArrayList();

            loopLabels.Add(whileLB1);
            loopLabels.Add(while1VariableNameLB);
            loopLabels.Add(while1CEndLB);
            loopLabels.Add(while1StartBRLB);
            loopLabels.Add(While1InnerLoopLB1);
            loopLabels.Add(While1InnerLoopLB2);
            loopLabels.Add(varianbleBoolCheckLB);
            loopLabels.Add(While1InnerLoopLB3);
            loopLabels.Add(While1InnerLoopLB4);
            loopLabels.Add(While1InnerLoopLB6);
            loopLabels.Add(While1InnerLoopLB7);
            loopLabels.Add(While1InnerLoopLB8);
            loopLabels.Add(while1StartingBRLB);
        }
        //
        //Enablig on Radio Buttons
        void RadioButtonCheck()
        {
            if (while1EnableRB.Checked == true)
            {
                while1CEndLB.Visible = true;
                while1ConditionCB.Visible = true;
                while1StartBRLB.Visible = true;
                while1StartingBRLB.Visible = true;
                whileLB1.Visible = true;
                while2CEndLB.Visible = false;
                while2ConditionCB.Visible = false;
                while2ConditionLoopLimitCB.Visible = false;
                while2StartBRLB.Visible = false;
                while2VariableSelectionCB.Visible = false;
                whileLB2.Visible = false;
                whileStartBRLB.Visible = false;
                label5.Visible = false;
                while2VariableSelectionCB.Visible = false;
                while2EqualsLB.Visible = false;
                initialVariableValueCB.Visible = false;
                while2initalValueLB.Visible = false;
                while1EqualsLB.Visible = true;
                while1VariableSelectionCB.Visible = true;
                boolLB.Visible = true;
                label12.Visible = true;
                //
                animateWhile2InitiateVariableLB.Visible = false;
                animateWhile2ConditionLB.Visible = false;
                animateWhile2PrintLB.Visible = false;
                pictureBox1.Visible = false;
                richTextBox2.Visible = false;
                label5.Visible = false;
                //
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Visible = true;
                AnimateintWhile1NOLB.Visible = true;
                animateWhile1ConditionLB.Visible = true;
                animateWhile1IfConditionLB.Visible = true;
                animateInnerIfWhile1LB.Visible = true;
                animateWhile1IncreamentLB.Visible = true;
                animateWhile1PrintLB.Visible = true;

            }
            else if (while2EnableRB.Checked == true)
            {
                while1CEndLB.Visible = false;
                while1ConditionCB.Visible = false;
                while1StartBRLB.Visible = false;
                while1StartingBRLB.Visible = false;
                whileLB1.Visible = false;
                while2CEndLB.Visible = true;
                while2ConditionCB.Visible = true;
                while2ConditionLoopLimitCB.Visible = true;
                while2StartBRLB.Visible = true;
                while2VariableSelectionCB.Visible = true;
                whileLB2.Visible = true;
                whileStartBRLB.Visible = true;
                label5.Visible = true;
                while2VariableSelectionCB.Visible = true;
                while2EqualsLB.Visible = true;
                initialVariableValueCB.Visible = true;
                while2initalValueLB.Visible = true;

                while1EqualsLB.Visible = false;
                while1VariableSelectionCB.Visible = false;
                boolLB.Visible = false;
                label12.Visible = false;
                //
                animateWhile2InitiateVariableLB.Visible = true;
                animateWhile2ConditionLB.Visible = true;
                animateWhile2PrintLB.Visible = true;
                pictureBox1.Visible = true;
                richTextBox2.Visible = true;
                label5.Visible = true;
                //
                animateWhile1BOOL_VARIABLE_WITH_VALUE.Visible = false;
                AnimateintWhile1NOLB.Visible = false;
                animateWhile1ConditionLB.Visible = false;
                animateWhile1IfConditionLB.Visible = false;
                animateInnerIfWhile1LB.Visible = false;
                animateWhile1IncreamentLB.Visible = false;
                animateWhile1PrintLB.Visible = false;


            }
        }

        private void while1EnableRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void while2EnableRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void closeBracketsLB_Click(object sender, EventArgs e)
        {

        }

        private void while2VariableSelectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVariableChange3.Text = while2VariableSelectionCB.SelectedItem.ToString();
            while2VariableNameSelectionFromcbLB.Text = while2VariableSelectionCB.SelectedItem.ToString();
        }
        //
        //While 2 Condition (FOR VALUES !)
        void while2Condition()
        {
            while2loopLabels = new ArrayList();
            while2loopLabels.Add(whileLB2);
            while2loopLabels.Add(while2VariableNameSelectionFromcbLB);
            while2loopLabels.Add(while2CEndLB);
            while2loopLabels.Add(whileStartBRLB);
            while2loopLabels.Add(writeInstructionsLB);
            while2loopLabels.Add(selectedVariableChange3);
            while2loopLabels.Add(closeBracketsLB);
            while2loopLabels.Add(while2StartBRLB);
            backgroundWorker2.RunWorkerAsync();
           
        }

        private void while2ConditionLoopLimitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            valueFromWhile2 = while2ConditionLoopLimitCB.SelectedItem.ToString();
        }

        private void executeBT_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            if (while1EnableRB.Checked==true)
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
                if(while1VariableSelectionCB.SelectedItem==null|| while1ConditionCB.SelectedItem==null)
                {
                    MessageBox.Show("Please Fill all the specified Fields !");

                }
                else { while1(); }
               
            }
            else if(while2EnableRB.Checked==true)
            {
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
                if(while2VariableSelectionCB.SelectedItem==null|| initialVariableValueCB.SelectedItem==null|| while2ConditionCB.SelectedItem==null|| while2ConditionLoopLimitCB.SelectedItem==null)
                {
                    MessageBox.Show("Please Fill all the specified Fields !");
                }
                else { while2Condition(); }
                
            }
            
        }
        //
        // While 1 Implementation
        void while1()
        {
            
            backgroundWorker1.RunWorkerAsync();
        }
    

        private void initialVariableValueCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialVariableVal = initialVariableValueCB.SelectedItem.ToString();
        }

        private void while1VariableSelectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            while1VariableNameLB.Text = while1VariableSelectionCB.SelectedItem.ToString();
            varianbleBoolCheckLB.Text = while1VariableSelectionCB.SelectedItem.ToString();
        }

        private void while1ConditionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(while1ConditionCB.SelectedItem.ToString()=="true")
            {
                While1InnerLoopLB4.Text = "false ;";
                while1CEndLB.Text = ")";

            }
            else if(while1ConditionCB.SelectedItem.ToString() == "false")
            {
                While1InnerLoopLB4.Text = "true ;";
                while1CEndLB.Text = "== false)";
            }
            

        }

        private void while2EqualsLB_Click(object sender, EventArgs e)
        {

        }

        private void While1InnerLoopLB1_Click(object sender, EventArgs e)
        {

        }

        private void varianbleBoolCheckLB_Click(object sender, EventArgs e)
        {

        }
    }
}