namespace VP_Project
{
    partial class FoorLoop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.forLB = new System.Windows.Forms.Label();
            this.closingBRLB = new System.Windows.Forms.Label();
            this.forStartingBRLB = new System.Windows.Forms.Label();
            this.initialingVariableCB = new System.Windows.Forms.ComboBox();
            this.intLB = new System.Windows.Forms.Label();
            this.semicolonLB = new System.Windows.Forms.Label();
            this.variableSelectedLB = new System.Windows.Forms.Label();
            this.conditionValueForVariableCB = new System.Windows.Forms.ComboBox();
            this.conditionForVariableCB = new System.Windows.Forms.ComboBox();
            this.secondsemicolonLB = new System.Windows.Forms.Label();
            this.selectedVariableChange2 = new System.Windows.Forms.Label();
            this.variableValueChangeCB = new System.Windows.Forms.ComboBox();
            this.equalsToLB = new System.Windows.Forms.Label();
            this.initalValueOfVariableCB = new System.Windows.Forms.ComboBox();
            this.openingBR = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.writeInstructionsLB = new System.Windows.Forms.Label();
            this.selectedVariableChange3 = new System.Windows.Forms.Label();
            this.closeBracketsLB = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.animateINT_VARIABLE_WITH_VALUE = new System.Windows.Forms.Label();
            this.Animate_conditionCheck = new System.Windows.Forms.Label();
            this.Animate_inLoopValueLB = new System.Windows.Forms.Label();
            this.animateOutPutLB = new System.Windows.Forms.Label();
            this.arrowPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPB)).BeginInit();
            this.SuspendLayout();
            // 
            // forLB
            // 
            this.forLB.AutoSize = true;
            this.forLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLB.Location = new System.Drawing.Point(49, 172);
            this.forLB.Name = "forLB";
            this.forLB.Size = new System.Drawing.Size(36, 24);
            this.forLB.TabIndex = 1;
            this.forLB.Text = "for";
            this.forLB.ForeColorChanged += new System.EventHandler(this.forLB_ForeColorChanged);
            // 
            // closingBRLB
            // 
            this.closingBRLB.AutoSize = true;
            this.closingBRLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closingBRLB.Location = new System.Drawing.Point(521, 172);
            this.closingBRLB.Name = "closingBRLB";
            this.closingBRLB.Size = new System.Drawing.Size(17, 24);
            this.closingBRLB.TabIndex = 2;
            this.closingBRLB.Text = ")";
            this.closingBRLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // forStartingBRLB
            // 
            this.forStartingBRLB.AutoSize = true;
            this.forStartingBRLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forStartingBRLB.Location = new System.Drawing.Point(82, 172);
            this.forStartingBRLB.Name = "forStartingBRLB";
            this.forStartingBRLB.Size = new System.Drawing.Size(17, 24);
            this.forStartingBRLB.TabIndex = 3;
            this.forStartingBRLB.Text = "(";
            // 
            // initialingVariableCB
            // 
            this.initialingVariableCB.FormattingEnabled = true;
            this.initialingVariableCB.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.initialingVariableCB.Location = new System.Drawing.Point(144, 172);
            this.initialingVariableCB.Name = "initialingVariableCB";
            this.initialingVariableCB.Size = new System.Drawing.Size(40, 24);
            this.initialingVariableCB.TabIndex = 4;
            this.initialingVariableCB.SelectedIndexChanged += new System.EventHandler(this.initialingVariableCB_SelectedIndexChanged);
            // 
            // intLB
            // 
            this.intLB.AutoSize = true;
            this.intLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intLB.Location = new System.Drawing.Point(105, 172);
            this.intLB.Name = "intLB";
            this.intLB.Size = new System.Drawing.Size(33, 24);
            this.intLB.TabIndex = 5;
            this.intLB.Text = "int";
            // 
            // semicolonLB
            // 
            this.semicolonLB.AutoSize = true;
            this.semicolonLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semicolonLB.Location = new System.Drawing.Point(261, 172);
            this.semicolonLB.Name = "semicolonLB";
            this.semicolonLB.Size = new System.Drawing.Size(15, 24);
            this.semicolonLB.TabIndex = 7;
            this.semicolonLB.Text = ";";
            // 
            // variableSelectedLB
            // 
            this.variableSelectedLB.AutoSize = true;
            this.variableSelectedLB.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableSelectedLB.Location = new System.Drawing.Point(280, 172);
            this.variableSelectedLB.Name = "variableSelectedLB";
            this.variableSelectedLB.Size = new System.Drawing.Size(17, 28);
            this.variableSelectedLB.TabIndex = 8;
            this.variableSelectedLB.Text = ".";
            // 
            // conditionValueForVariableCB
            // 
            this.conditionValueForVariableCB.FormattingEnabled = true;
            this.conditionValueForVariableCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.conditionValueForVariableCB.Location = new System.Drawing.Point(366, 172);
            this.conditionValueForVariableCB.Name = "conditionValueForVariableCB";
            this.conditionValueForVariableCB.Size = new System.Drawing.Size(40, 24);
            this.conditionValueForVariableCB.TabIndex = 9;
            this.conditionValueForVariableCB.SelectedIndexChanged += new System.EventHandler(this.conditionValueForVariableCB_SelectedIndexChanged);
            // 
            // conditionForVariableCB
            // 
            this.conditionForVariableCB.FormattingEnabled = true;
            this.conditionForVariableCB.Items.AddRange(new object[] {
            "==",
            ">=",
            "<="});
            this.conditionForVariableCB.Location = new System.Drawing.Point(309, 172);
            this.conditionForVariableCB.Name = "conditionForVariableCB";
            this.conditionForVariableCB.Size = new System.Drawing.Size(51, 24);
            this.conditionForVariableCB.TabIndex = 10;
            this.conditionForVariableCB.SelectedIndexChanged += new System.EventHandler(this.conditionForVariableCB_SelectedIndexChanged);
            // 
            // secondsemicolonLB
            // 
            this.secondsemicolonLB.AutoSize = true;
            this.secondsemicolonLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsemicolonLB.Location = new System.Drawing.Point(412, 172);
            this.secondsemicolonLB.Name = "secondsemicolonLB";
            this.secondsemicolonLB.Size = new System.Drawing.Size(15, 24);
            this.secondsemicolonLB.TabIndex = 11;
            this.secondsemicolonLB.Text = ";";
            // 
            // selectedVariableChange2
            // 
            this.selectedVariableChange2.AutoSize = true;
            this.selectedVariableChange2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedVariableChange2.Location = new System.Drawing.Point(433, 172);
            this.selectedVariableChange2.Name = "selectedVariableChange2";
            this.selectedVariableChange2.Size = new System.Drawing.Size(17, 28);
            this.selectedVariableChange2.TabIndex = 12;
            this.selectedVariableChange2.Text = ".";
            // 
            // variableValueChangeCB
            // 
            this.variableValueChangeCB.FormattingEnabled = true;
            this.variableValueChangeCB.Items.AddRange(new object[] {
            "++",
            "--"});
            this.variableValueChangeCB.Location = new System.Drawing.Point(465, 172);
            this.variableValueChangeCB.Name = "variableValueChangeCB";
            this.variableValueChangeCB.Size = new System.Drawing.Size(50, 24);
            this.variableValueChangeCB.TabIndex = 13;
            this.variableValueChangeCB.SelectedIndexChanged += new System.EventHandler(this.variableValueChangeCB_SelectedIndexChanged);
            // 
            // equalsToLB
            // 
            this.equalsToLB.AutoSize = true;
            this.equalsToLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsToLB.Location = new System.Drawing.Point(190, 172);
            this.equalsToLB.Name = "equalsToLB";
            this.equalsToLB.Size = new System.Drawing.Size(19, 24);
            this.equalsToLB.TabIndex = 14;
            this.equalsToLB.Text = "=";
            // 
            // initalValueOfVariableCB
            // 
            this.initalValueOfVariableCB.FormattingEnabled = true;
            this.initalValueOfVariableCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.initalValueOfVariableCB.Location = new System.Drawing.Point(215, 172);
            this.initalValueOfVariableCB.Name = "initalValueOfVariableCB";
            this.initalValueOfVariableCB.Size = new System.Drawing.Size(40, 24);
            this.initalValueOfVariableCB.TabIndex = 15;
            this.initalValueOfVariableCB.SelectedIndexChanged += new System.EventHandler(this.initalValueOfVariableCB_SelectedIndexChanged);
            // 
            // openingBR
            // 
            this.openingBR.AutoSize = true;
            this.openingBR.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openingBR.Location = new System.Drawing.Point(82, 219);
            this.openingBR.Name = "openingBR";
            this.openingBR.Size = new System.Drawing.Size(17, 24);
            this.openingBR.TabIndex = 16;
            this.openingBR.Text = "{";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "}";
            // 
            // writeInstructionsLB
            // 
            this.writeInstructionsLB.AutoSize = true;
            this.writeInstructionsLB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeInstructionsLB.Location = new System.Drawing.Point(140, 271);
            this.writeInstructionsLB.Name = "writeInstructionsLB";
            this.writeInstructionsLB.Size = new System.Drawing.Size(240, 24);
            this.writeInstructionsLB.TabIndex = 18;
            this.writeInstructionsLB.Text = "Console.Write(\"Value : \" +";
            // 
            // selectedVariableChange3
            // 
            this.selectedVariableChange3.AutoSize = true;
            this.selectedVariableChange3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedVariableChange3.Location = new System.Drawing.Point(395, 266);
            this.selectedVariableChange3.Name = "selectedVariableChange3";
            this.selectedVariableChange3.Size = new System.Drawing.Size(17, 28);
            this.selectedVariableChange3.TabIndex = 19;
            this.selectedVariableChange3.Text = ".";
            this.selectedVariableChange3.Click += new System.EventHandler(this.selectedVariableChange3_Click);
            // 
            // closeBracketsLB
            // 
            this.closeBracketsLB.AutoSize = true;
            this.closeBracketsLB.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBracketsLB.Location = new System.Drawing.Point(419, 268);
            this.closeBracketsLB.Name = "closeBracketsLB";
            this.closeBracketsLB.Size = new System.Drawing.Size(31, 28);
            this.closeBracketsLB.TabIndex = 20;
            this.closeBracketsLB.Text = ") ;";
            this.closeBracketsLB.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(80, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Output Console :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(84, 442);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 149);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(575, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // animateINT_VARIABLE_WITH_VALUE
            // 
            this.animateINT_VARIABLE_WITH_VALUE.AutoSize = true;
            this.animateINT_VARIABLE_WITH_VALUE.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animateINT_VARIABLE_WITH_VALUE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.animateINT_VARIABLE_WITH_VALUE.Location = new System.Drawing.Point(50, 132);
            this.animateINT_VARIABLE_WITH_VALUE.Name = "animateINT_VARIABLE_WITH_VALUE";
            this.animateINT_VARIABLE_WITH_VALUE.Size = new System.Drawing.Size(13, 20);
            this.animateINT_VARIABLE_WITH_VALUE.TabIndex = 24;
            this.animateINT_VARIABLE_WITH_VALUE.Text = ".";
            // 
            // Animate_conditionCheck
            // 
            this.Animate_conditionCheck.AutoSize = true;
            this.Animate_conditionCheck.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animate_conditionCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Animate_conditionCheck.Location = new System.Drawing.Point(306, 132);
            this.Animate_conditionCheck.Name = "Animate_conditionCheck";
            this.Animate_conditionCheck.Size = new System.Drawing.Size(13, 20);
            this.Animate_conditionCheck.TabIndex = 25;
            this.Animate_conditionCheck.Text = ".";
            // 
            // Animate_inLoopValueLB
            // 
            this.Animate_inLoopValueLB.AutoSize = true;
            this.Animate_inLoopValueLB.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Animate_inLoopValueLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Animate_inLoopValueLB.Location = new System.Drawing.Point(457, 277);
            this.Animate_inLoopValueLB.Name = "Animate_inLoopValueLB";
            this.Animate_inLoopValueLB.Size = new System.Drawing.Size(13, 20);
            this.Animate_inLoopValueLB.TabIndex = 26;
            this.Animate_inLoopValueLB.Text = ".";
            // 
            // animateOutPutLB
            // 
            this.animateOutPutLB.AutoSize = true;
            this.animateOutPutLB.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animateOutPutLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.animateOutPutLB.Location = new System.Drawing.Point(522, 462);
            this.animateOutPutLB.Name = "animateOutPutLB";
            this.animateOutPutLB.Size = new System.Drawing.Size(13, 20);
            this.animateOutPutLB.TabIndex = 27;
            this.animateOutPutLB.Text = ".";
            // 
            // arrowPB
            // 
            this.arrowPB.Image = global::VP_Project.Properties.Resources._80215_square_symbol_wallpaper_desktop_computer_arrow_thumb;
            this.arrowPB.Location = new System.Drawing.Point(265, 304);
            this.arrowPB.Name = "arrowPB";
            this.arrowPB.Size = new System.Drawing.Size(191, 132);
            this.arrowPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowPB.TabIndex = 28;
            this.arrowPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "For Loop :";
            // 
            // FoorLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 622);
            this.Controls.Add(this.arrowPB);
            this.Controls.Add(this.animateOutPutLB);
            this.Controls.Add(this.Animate_inLoopValueLB);
            this.Controls.Add(this.Animate_conditionCheck);
            this.Controls.Add(this.animateINT_VARIABLE_WITH_VALUE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.closeBracketsLB);
            this.Controls.Add(this.selectedVariableChange3);
            this.Controls.Add(this.writeInstructionsLB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.openingBR);
            this.Controls.Add(this.initalValueOfVariableCB);
            this.Controls.Add(this.equalsToLB);
            this.Controls.Add(this.variableValueChangeCB);
            this.Controls.Add(this.selectedVariableChange2);
            this.Controls.Add(this.secondsemicolonLB);
            this.Controls.Add(this.conditionForVariableCB);
            this.Controls.Add(this.conditionValueForVariableCB);
            this.Controls.Add(this.variableSelectedLB);
            this.Controls.Add(this.semicolonLB);
            this.Controls.Add(this.intLB);
            this.Controls.Add(this.initialingVariableCB);
            this.Controls.Add(this.forStartingBRLB);
            this.Controls.Add(this.closingBRLB);
            this.Controls.Add(this.forLB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoorLoop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label forLB;
        private System.Windows.Forms.Label closingBRLB;
        private System.Windows.Forms.Label forStartingBRLB;
        private System.Windows.Forms.ComboBox initialingVariableCB;
        private System.Windows.Forms.Label intLB;
        private System.Windows.Forms.Label semicolonLB;
        private System.Windows.Forms.Label variableSelectedLB;
        private System.Windows.Forms.ComboBox conditionValueForVariableCB;
        private System.Windows.Forms.ComboBox conditionForVariableCB;
        private System.Windows.Forms.Label secondsemicolonLB;
        private System.Windows.Forms.Label selectedVariableChange2;
        private System.Windows.Forms.ComboBox variableValueChangeCB;
        private System.Windows.Forms.Label equalsToLB;
        private System.Windows.Forms.ComboBox initalValueOfVariableCB;
        private System.Windows.Forms.Label openingBR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label writeInstructionsLB;
        private System.Windows.Forms.Label selectedVariableChange3;
        private System.Windows.Forms.Label closeBracketsLB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label animateINT_VARIABLE_WITH_VALUE;
        private System.Windows.Forms.Label Animate_conditionCheck;
        private System.Windows.Forms.Label Animate_inLoopValueLB;
        private System.Windows.Forms.Label animateOutPutLB;
        private System.Windows.Forms.PictureBox arrowPB;
        private System.Windows.Forms.Label label1;
    }
}

