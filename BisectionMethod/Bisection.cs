//Created by: Patrick Nulla
// June 01, 2017

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
        //Reference
        public Menu MenuRef;

        //Input Coefficients
        double Constant;
        double Order1;
        double Order2;
        double Order3;

        //Bracketing Function
        double output;
        double negative;
        double positive;
        double i_neg;
        double i_pos;
        int Round;

        public Bisection()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MenuRef.Close();
        }

        private void B_FindRoot_Click(object sender, EventArgs e)
        {
            Constant = Double.Parse(TB_Order0.Text);
            Order1 = Double.Parse(TB_Order1.Text);
            Order2 = Double.Parse(TB_Order2.Text);
            Order3 = Double.Parse(TB_Order3.Text);

            CheckTerminate();
            FindBracket();
            PopulateTables();

        }

        private void FindBracket()
        {
            negative = 0.0D;
            positive = 0.0D;
            output = 0.0D;
            i_neg = 0.0D;
            i_pos = 0.0D;
            for (int i = -10000; !(negative <= 0) || !(positive > 0); i++)
            {
                output = (Order3 * Math.Pow((Double)i, 3.0)) + (Order2 * Math.Pow((Double)i, 2.0)) + (Order1 * (Double)i) + Constant;
                if (output <= 0)
                {
                    negative = output;
                    i_neg = i;
                }

                else if (output > 0)
                {
                    positive = output;
                    i_pos = i;
                }
            }

            L_ValueX0.Text = i_neg.ToString();
            L_ValueX1.Text = i_pos.ToString();
            L_ValueFX0.Text = negative.ToString();
            L_ValueFX1.Text = positive.ToString();
            LB_ValueX0.Items.Add(Math.Round(i_neg, Round));
            LB_ValueFX0.Items.Add(Math.Round(negative, Round));
            LB_ValueX1.Items.Add(Math.Round(i_pos, Round));
            LB_ValueFX1.Items.Add(Math.Round(positive, Round));
        }

        private void PopulateTables()
        {
            double NewX2 = 0.0D;
            double NewFX2 = 0.0D;
            double PrevX2 = 0.0D;
            double TerminatingCond = 0.0D;
            do
            {
                PrevX2 = NewX2;
                NewX2 = (Math.Abs(i_neg) + Math.Abs(i_pos)) / 2.0D;
                NewFX2 = (Order3 * Math.Pow(NewX2, 3.0)) + (Order2 * Math.Pow(NewX2, 2.0)) + (Order1 * NewX2) + Constant;

                if (NewFX2 < 0)
                {
                    i_neg = NewX2;
                    negative = NewFX2;
                }

                else if (NewFX2 > 0)
                {
                    i_pos = NewX2;
                    positive = NewFX2;
                }

                LB_ValueX0.Items.Add(Math.Round(i_neg, Round));
                LB_ValueFX0.Items.Add(Math.Round(negative, Round));
                LB_ValueX1.Items.Add(Math.Round(i_pos, Round));
                LB_ValueFX1.Items.Add(Math.Round(positive, Round));
                LB_ValueX2.Items.Add(Math.Round(NewX2, Round));
                LB_ValueFX2.Items.Add(Math.Round(NewFX2, Round));

                double.TryParse(TB_Terminating.Text, out TerminatingCond);
            } while (!(Math.Abs((PrevX2) - (NewX2)) <= TerminatingCond));
            L_ValueRoot.Text = Math.Round(NewX2, Round).ToString();
            

        }
        
        private void ClearAll()
        {
            TB_Terminating.Clear();
            TB_Order3.Clear();
            TB_Order2.Clear();
            TB_Order1.Clear();
            TB_Order0.Clear();
            LB_ValueFX0.Items.Clear();
            LB_ValueFX1.Items.Clear();
            LB_ValueFX2.Items.Clear();
            LB_ValueX0.Items.Clear();
            LB_ValueX1.Items.Clear();
            LB_ValueX2.Items.Clear();
            L_ValueFX0.Text = "0";
            L_ValueFX1.Text = "0";
            L_ValueX0.Text = "0";
            L_ValueX1.Text = "0";
            L_ValueRoot.Text = "0";
        }

        private void CheckTerminate()
        {
            double TerminatingCond = 0.0D;
            Round = 0;
            double.TryParse(TB_Terminating.Text, out TerminatingCond);
            do
            {
                TerminatingCond = TerminatingCond * 10;
                Round++;
            } while (TerminatingCond > 0 && TerminatingCond < 1);
        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}

//Created by: Patrick Nulla
// June 01, 2017