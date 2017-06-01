using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BisectionMethod
{
    public partial class Bisection : Form
    {
        //Input Coefficients
        double Constant;
        double Order1;
        double Order2;
        double Order3;

        //Bracketing Function
        double output;
        double negative;
        double positive;

        public Bisection()
        {
            InitializeComponent();
        }

        private void B_FindRoot_Click(object sender, EventArgs e)
        {
            Constant = Double.Parse(TB_Order0.Text);
            Order1 = Double.Parse(TB_Order1.Text);
            Order2 = Double.Parse(TB_Order2.Text);
            Order3 = Double.Parse(TB_Order3.Text);

            FindBracket();
            
        }

        private void FindBracket()
        {
            negative = 0.0D;
            positive = 0.0D;
            output = 0.0D;
            for(int i = 0; negative != -6 && positive != 20; i++)
            {
                output = (Order3 * Math.Pow((Double)i, 3.0)) + (Order2 * Math.Pow((Double)i, 2.0)) + (Order1 * (Double)i) + Constant;
                if (output < 0)
                {
                    negative = output;
                }

                else if(output > 0)
                {
                    positive = output;
                }
            }

            label1.Text = negative.ToString();
            label2.Text = positive.ToString();
        }
    }
}
