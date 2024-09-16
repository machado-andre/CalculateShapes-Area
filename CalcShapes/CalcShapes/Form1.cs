using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCircleArea_Click(object sender, EventArgs e)
        {
            calcCircleArea();
        }

        private void buttonRectangleCalc_Click(object sender, EventArgs e)
        {
            calcRectangleArea();
        }

        private void buttonTriangleCalc_Click(object sender, EventArgs e)
        {
            calcTriangleArea();
        }

        private double CalculateCircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }

        private double CalculateRectangleArea(double side1, double side2)
        {
            return side1 * side2;
        }

        private double CalculateTriangleArea(double side1,double side2,double side3)
        {
            return 0.25 * Math.Sqrt((side1 + side2 + side3) * (-side1 + side2 + side3) * (side1 - side2 + side3) * (side1 + side2 - side3));
        }

        private void buttonCalcAll_Click(object sender, EventArgs e)
        {
            calcCircleArea();
            calcRectangleArea();
            calcTriangleArea();
        }

        private void calcCircleArea()
        {
            if (textBoxCircle.Text == null)
            {
                labelError.Text = "Radius must not be null";
                return;
            }
            double radius = double.Parse(textBoxCircle.Text);
            if (radius <= 0)
            {
                labelError.Text = "Can't calculate negative distances, can you?";
                return;
            }

            labelCircleAreaResult.Text = CalculateCircleArea(radius).ToString();
            labelError.Text = "";
        }

        private void calcRectangleArea()
        {
            if (textBoxRectangle1.Text == null || textBoxRectangle2.Text == null)
            {
                labelError.Text = "Every side must have a value";
                return;
            }
            double side1 = double.Parse(textBoxRectangle1.Text);
            double side2 = double.Parse(textBoxRectangle2.Text);

            if (side1 <= 0 || side2 <= 0)
            {
                labelError.Text = "Can't calculate negative distances, can you?";
                return;
            }

            labelRectangleAreaResult.Text = CalculateRectangleArea(side1, side2).ToString();
            labelError.Text = "";
        }

        private void calcTriangleArea()
        {
            if(textBoxTriangle1.Text == null || textBoxTriangle2.Text == null || textBoxTriangle3.Text == null)
            {
                labelError.Text = "Every side must have a value";
                return;
            }
            double side1 = double.Parse(textBoxTriangle1.Text);
            double side2 = double.Parse(textBoxTriangle2.Text);
            double side3 = double.Parse(textBoxTriangle3.Text);

            if (side1 <= 0 || side2 <= 0 || side3 <= 0){
                labelError.Text = "No side can be 0 or less";
                return;
            }

            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                labelError.Text = "There's a side which has a higher value than the sum of the other two.";
                return;
            }

            labelTriangleAreaResult.Text = CalculateTriangleArea(side1, side2, side3).ToString();
            labelError.Text = "";
        }
    }
}
