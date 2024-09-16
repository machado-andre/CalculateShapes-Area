namespace CalcShapes
{
    partial class Form1
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
            this.textBoxCircle = new System.Windows.Forms.TextBox();
            this.labelCircleRadius = new System.Windows.Forms.Label();
            this.labelRectangle = new System.Windows.Forms.Label();
            this.labelTriangle = new System.Windows.Forms.Label();
            this.textBoxRectangle1 = new System.Windows.Forms.TextBox();
            this.textBoxRectangle2 = new System.Windows.Forms.TextBox();
            this.textBoxTriangle1 = new System.Windows.Forms.TextBox();
            this.textBoxTriangle2 = new System.Windows.Forms.TextBox();
            this.textBoxTriangle3 = new System.Windows.Forms.TextBox();
            this.buttonTriangleCalc = new System.Windows.Forms.Button();
            this.buttonCircleArea = new System.Windows.Forms.Button();
            this.buttonRectangleCalc = new System.Windows.Forms.Button();
            this.buttonCalcAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelCircleAreaResult = new System.Windows.Forms.Label();
            this.labelRectangleAreaResult = new System.Windows.Forms.Label();
            this.labelTriangleAreaResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCircle
            // 
            this.textBoxCircle.Location = new System.Drawing.Point(12, 63);
            this.textBoxCircle.Name = "textBoxCircle";
            this.textBoxCircle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCircle.TabIndex = 0;
            // 
            // labelCircleRadius
            // 
            this.labelCircleRadius.AutoSize = true;
            this.labelCircleRadius.Location = new System.Drawing.Point(13, 47);
            this.labelCircleRadius.Name = "labelCircleRadius";
            this.labelCircleRadius.Size = new System.Drawing.Size(69, 13);
            this.labelCircleRadius.TabIndex = 1;
            this.labelCircleRadius.Text = "Circle Radius";
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Location = new System.Drawing.Point(13, 125);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(85, 13);
            this.labelRectangle.TabIndex = 2;
            this.labelRectangle.Text = "Rectangle Sides";
            // 
            // labelTriangle
            // 
            this.labelTriangle.AutoSize = true;
            this.labelTriangle.Location = new System.Drawing.Point(13, 215);
            this.labelTriangle.Name = "labelTriangle";
            this.labelTriangle.Size = new System.Drawing.Size(74, 13);
            this.labelTriangle.TabIndex = 3;
            this.labelTriangle.Text = "Triangle Sides";
            // 
            // textBoxRectangle1
            // 
            this.textBoxRectangle1.Location = new System.Drawing.Point(12, 141);
            this.textBoxRectangle1.Name = "textBoxRectangle1";
            this.textBoxRectangle1.Size = new System.Drawing.Size(40, 20);
            this.textBoxRectangle1.TabIndex = 4;
            // 
            // textBoxRectangle2
            // 
            this.textBoxRectangle2.Location = new System.Drawing.Point(58, 141);
            this.textBoxRectangle2.Name = "textBoxRectangle2";
            this.textBoxRectangle2.Size = new System.Drawing.Size(40, 20);
            this.textBoxRectangle2.TabIndex = 5;
            // 
            // textBoxTriangle1
            // 
            this.textBoxTriangle1.Location = new System.Drawing.Point(12, 231);
            this.textBoxTriangle1.Name = "textBoxTriangle1";
            this.textBoxTriangle1.Size = new System.Drawing.Size(40, 20);
            this.textBoxTriangle1.TabIndex = 6;
            // 
            // textBoxTriangle2
            // 
            this.textBoxTriangle2.Location = new System.Drawing.Point(58, 231);
            this.textBoxTriangle2.Name = "textBoxTriangle2";
            this.textBoxTriangle2.Size = new System.Drawing.Size(40, 20);
            this.textBoxTriangle2.TabIndex = 7;
            // 
            // textBoxTriangle3
            // 
            this.textBoxTriangle3.Location = new System.Drawing.Point(104, 231);
            this.textBoxTriangle3.Name = "textBoxTriangle3";
            this.textBoxTriangle3.Size = new System.Drawing.Size(40, 20);
            this.textBoxTriangle3.TabIndex = 8;
            // 
            // buttonTriangleCalc
            // 
            this.buttonTriangleCalc.Location = new System.Drawing.Point(12, 257);
            this.buttonTriangleCalc.Name = "buttonTriangleCalc";
            this.buttonTriangleCalc.Size = new System.Drawing.Size(95, 23);
            this.buttonTriangleCalc.TabIndex = 9;
            this.buttonTriangleCalc.Text = "Triangle Area";
            this.buttonTriangleCalc.UseVisualStyleBackColor = true;
            this.buttonTriangleCalc.Click += new System.EventHandler(this.buttonTriangleCalc_Click);
            // 
            // buttonCircleArea
            // 
            this.buttonCircleArea.Location = new System.Drawing.Point(12, 89);
            this.buttonCircleArea.Name = "buttonCircleArea";
            this.buttonCircleArea.Size = new System.Drawing.Size(95, 23);
            this.buttonCircleArea.TabIndex = 10;
            this.buttonCircleArea.Text = "Circle Area";
            this.buttonCircleArea.UseVisualStyleBackColor = true;
            this.buttonCircleArea.Click += new System.EventHandler(this.buttonCircleArea_Click);
            // 
            // buttonRectangleCalc
            // 
            this.buttonRectangleCalc.Location = new System.Drawing.Point(12, 167);
            this.buttonRectangleCalc.Name = "buttonRectangleCalc";
            this.buttonRectangleCalc.Size = new System.Drawing.Size(95, 23);
            this.buttonRectangleCalc.TabIndex = 11;
            this.buttonRectangleCalc.Text = "Rectangle Area";
            this.buttonRectangleCalc.UseVisualStyleBackColor = true;
            this.buttonRectangleCalc.Click += new System.EventHandler(this.buttonRectangleCalc_Click);
            // 
            // buttonCalcAll
            // 
            this.buttonCalcAll.Location = new System.Drawing.Point(269, 125);
            this.buttonCalcAll.Name = "buttonCalcAll";
            this.buttonCalcAll.Size = new System.Drawing.Size(108, 76);
            this.buttonCalcAll.TabIndex = 12;
            this.buttonCalcAll.Text = "Calculate All Areas";
            this.buttonCalcAll.UseVisualStyleBackColor = true;
            this.buttonCalcAll.Click += new System.EventHandler(this.buttonCalcAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "=";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(13, 325);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(13, 13);
            this.labelError.TabIndex = 16;
            this.labelError.Text = "0";
            // 
            // labelCircleAreaResult
            // 
            this.labelCircleAreaResult.AutoSize = true;
            this.labelCircleAreaResult.Location = new System.Drawing.Point(137, 66);
            this.labelCircleAreaResult.Name = "labelCircleAreaResult";
            this.labelCircleAreaResult.Size = new System.Drawing.Size(13, 13);
            this.labelCircleAreaResult.TabIndex = 17;
            this.labelCircleAreaResult.Text = "0";
            // 
            // labelRectangleAreaResult
            // 
            this.labelRectangleAreaResult.AutoSize = true;
            this.labelRectangleAreaResult.Location = new System.Drawing.Point(123, 144);
            this.labelRectangleAreaResult.Name = "labelRectangleAreaResult";
            this.labelRectangleAreaResult.Size = new System.Drawing.Size(13, 13);
            this.labelRectangleAreaResult.TabIndex = 18;
            this.labelRectangleAreaResult.Text = "0";
            // 
            // labelTriangleAreaResult
            // 
            this.labelTriangleAreaResult.AutoSize = true;
            this.labelTriangleAreaResult.Location = new System.Drawing.Point(169, 234);
            this.labelTriangleAreaResult.Name = "labelTriangleAreaResult";
            this.labelTriangleAreaResult.Size = new System.Drawing.Size(13, 13);
            this.labelTriangleAreaResult.TabIndex = 19;
            this.labelTriangleAreaResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 365);
            this.Controls.Add(this.labelTriangleAreaResult);
            this.Controls.Add(this.labelRectangleAreaResult);
            this.Controls.Add(this.labelCircleAreaResult);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalcAll);
            this.Controls.Add(this.buttonRectangleCalc);
            this.Controls.Add(this.buttonCircleArea);
            this.Controls.Add(this.buttonTriangleCalc);
            this.Controls.Add(this.textBoxTriangle3);
            this.Controls.Add(this.textBoxTriangle2);
            this.Controls.Add(this.textBoxTriangle1);
            this.Controls.Add(this.textBoxRectangle2);
            this.Controls.Add(this.textBoxRectangle1);
            this.Controls.Add(this.labelTriangle);
            this.Controls.Add(this.labelRectangle);
            this.Controls.Add(this.labelCircleRadius);
            this.Controls.Add(this.textBoxCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCircle;
        private System.Windows.Forms.Label labelCircleRadius;
        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.Label labelTriangle;
        private System.Windows.Forms.TextBox textBoxRectangle1;
        private System.Windows.Forms.TextBox textBoxRectangle2;
        private System.Windows.Forms.TextBox textBoxTriangle1;
        private System.Windows.Forms.TextBox textBoxTriangle2;
        private System.Windows.Forms.TextBox textBoxTriangle3;
        private System.Windows.Forms.Button buttonTriangleCalc;
        private System.Windows.Forms.Button buttonCircleArea;
        private System.Windows.Forms.Button buttonRectangleCalc;
        private System.Windows.Forms.Button buttonCalcAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelCircleAreaResult;
        private System.Windows.Forms.Label labelRectangleAreaResult;
        private System.Windows.Forms.Label labelTriangleAreaResult;
    }
}

