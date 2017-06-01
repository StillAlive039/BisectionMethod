namespace BisectionMethod
{
    partial class Bisection
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
            this.TB_Order3 = new System.Windows.Forms.TextBox();
            this.L_Order3 = new System.Windows.Forms.Label();
            this.L_Order2 = new System.Windows.Forms.Label();
            this.TB_Order2 = new System.Windows.Forms.TextBox();
            this.L_Order1 = new System.Windows.Forms.Label();
            this.TB_Order1 = new System.Windows.Forms.TextBox();
            this.L_Order0 = new System.Windows.Forms.Label();
            this.TB_Order0 = new System.Windows.Forms.TextBox();
            this.L_Fx = new System.Windows.Forms.Label();
            this.B_FindRoot = new System.Windows.Forms.Button();
            this.L_X0 = new System.Windows.Forms.Label();
            this.L_X1 = new System.Windows.Forms.Label();
            this.L_ValueX0 = new System.Windows.Forms.Label();
            this.L_ValueX1 = new System.Windows.Forms.Label();
            this.L_FX1 = new System.Windows.Forms.Label();
            this.L_FX0 = new System.Windows.Forms.Label();
            this.L_ValueFX1 = new System.Windows.Forms.Label();
            this.L_ValueFX0 = new System.Windows.Forms.Label();
            this.L_Initial = new System.Windows.Forms.Label();
            this.L_TableX0 = new System.Windows.Forms.Label();
            this.L_TableX2 = new System.Windows.Forms.Label();
            this.L_TableX3 = new System.Windows.Forms.Label();
            this.L_TableFX1 = new System.Windows.Forms.Label();
            this.L_TableFX2 = new System.Windows.Forms.Label();
            this.L_TableFX0 = new System.Windows.Forms.Label();
            this.LB_ValueX0 = new System.Windows.Forms.ListBox();
            this.LB_ValueX2 = new System.Windows.Forms.ListBox();
            this.LB_ValueX1 = new System.Windows.Forms.ListBox();
            this.LB_ValueFX1 = new System.Windows.Forms.ListBox();
            this.LB_ValueFX2 = new System.Windows.Forms.ListBox();
            this.LB_ValueFX0 = new System.Windows.Forms.ListBox();
            this.TB_Terminating = new System.Windows.Forms.TextBox();
            this.L_Terminating = new System.Windows.Forms.Label();
            this.B_Reset = new System.Windows.Forms.Button();
            this.L_Root = new System.Windows.Forms.Label();
            this.L_ValueRoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Order3
            // 
            this.TB_Order3.Location = new System.Drawing.Point(455, 29);
            this.TB_Order3.Name = "TB_Order3";
            this.TB_Order3.Size = new System.Drawing.Size(48, 22);
            this.TB_Order3.TabIndex = 0;
            // 
            // L_Order3
            // 
            this.L_Order3.AutoSize = true;
            this.L_Order3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order3.Location = new System.Drawing.Point(510, 29);
            this.L_Order3.Name = "L_Order3";
            this.L_Order3.Size = new System.Drawing.Size(32, 17);
            this.L_Order3.TabIndex = 1;
            this.L_Order3.Text = "x^3";
            // 
            // L_Order2
            // 
            this.L_Order2.AutoSize = true;
            this.L_Order2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order2.Location = new System.Drawing.Point(629, 29);
            this.L_Order2.Name = "L_Order2";
            this.L_Order2.Size = new System.Drawing.Size(32, 17);
            this.L_Order2.TabIndex = 3;
            this.L_Order2.Text = "x^2";
            // 
            // TB_Order2
            // 
            this.TB_Order2.Location = new System.Drawing.Point(574, 29);
            this.TB_Order2.Name = "TB_Order2";
            this.TB_Order2.Size = new System.Drawing.Size(48, 22);
            this.TB_Order2.TabIndex = 2;
            // 
            // L_Order1
            // 
            this.L_Order1.AutoSize = true;
            this.L_Order1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order1.Location = new System.Drawing.Point(748, 29);
            this.L_Order1.Name = "L_Order1";
            this.L_Order1.Size = new System.Drawing.Size(15, 17);
            this.L_Order1.TabIndex = 5;
            this.L_Order1.Text = "x";
            // 
            // TB_Order1
            // 
            this.TB_Order1.Location = new System.Drawing.Point(693, 29);
            this.TB_Order1.Name = "TB_Order1";
            this.TB_Order1.Size = new System.Drawing.Size(48, 22);
            this.TB_Order1.TabIndex = 4;
            // 
            // L_Order0
            // 
            this.L_Order0.AutoSize = true;
            this.L_Order0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order0.Location = new System.Drawing.Point(804, 29);
            this.L_Order0.Name = "L_Order0";
            this.L_Order0.Size = new System.Drawing.Size(0, 17);
            this.L_Order0.TabIndex = 7;
            // 
            // TB_Order0
            // 
            this.TB_Order0.Location = new System.Drawing.Point(807, 29);
            this.TB_Order0.Name = "TB_Order0";
            this.TB_Order0.Size = new System.Drawing.Size(48, 22);
            this.TB_Order0.TabIndex = 6;
            // 
            // L_Fx
            // 
            this.L_Fx.AutoSize = true;
            this.L_Fx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fx.Location = new System.Drawing.Point(390, 29);
            this.L_Fx.Name = "L_Fx";
            this.L_Fx.Size = new System.Drawing.Size(50, 17);
            this.L_Fx.TabIndex = 8;
            this.L_Fx.Text = "F(x) =";
            // 
            // B_FindRoot
            // 
            this.B_FindRoot.Location = new System.Drawing.Point(15, 198);
            this.B_FindRoot.Name = "B_FindRoot";
            this.B_FindRoot.Size = new System.Drawing.Size(102, 23);
            this.B_FindRoot.TabIndex = 9;
            this.B_FindRoot.Text = "Find Root";
            this.B_FindRoot.UseVisualStyleBackColor = true;
            this.B_FindRoot.Click += new System.EventHandler(this.B_FindRoot_Click);
            // 
            // L_X0
            // 
            this.L_X0.AutoSize = true;
            this.L_X0.Location = new System.Drawing.Point(12, 34);
            this.L_X0.Name = "L_X0";
            this.L_X0.Size = new System.Drawing.Size(41, 17);
            this.L_X0.TabIndex = 11;
            this.L_X0.Text = "X0 =";
            // 
            // L_X1
            // 
            this.L_X1.AutoSize = true;
            this.L_X1.Location = new System.Drawing.Point(12, 62);
            this.L_X1.Name = "L_X1";
            this.L_X1.Size = new System.Drawing.Size(41, 17);
            this.L_X1.TabIndex = 12;
            this.L_X1.Text = "X1 =";
            // 
            // L_ValueX0
            // 
            this.L_ValueX0.AutoSize = true;
            this.L_ValueX0.Location = new System.Drawing.Point(59, 34);
            this.L_ValueX0.Name = "L_ValueX0";
            this.L_ValueX0.Size = new System.Drawing.Size(17, 17);
            this.L_ValueX0.TabIndex = 13;
            this.L_ValueX0.Text = "0";
            // 
            // L_ValueX1
            // 
            this.L_ValueX1.AutoSize = true;
            this.L_ValueX1.Location = new System.Drawing.Point(59, 62);
            this.L_ValueX1.Name = "L_ValueX1";
            this.L_ValueX1.Size = new System.Drawing.Size(17, 17);
            this.L_ValueX1.TabIndex = 14;
            this.L_ValueX1.Text = "0";
            // 
            // L_FX1
            // 
            this.L_FX1.AutoSize = true;
            this.L_FX1.Location = new System.Drawing.Point(12, 118);
            this.L_FX1.Name = "L_FX1";
            this.L_FX1.Size = new System.Drawing.Size(59, 17);
            this.L_FX1.TabIndex = 16;
            this.L_FX1.Text = "F(x1) =";
            // 
            // L_FX0
            // 
            this.L_FX0.AutoSize = true;
            this.L_FX0.Location = new System.Drawing.Point(12, 88);
            this.L_FX0.Name = "L_FX0";
            this.L_FX0.Size = new System.Drawing.Size(59, 17);
            this.L_FX0.TabIndex = 15;
            this.L_FX0.Text = "F(x0) =";
            // 
            // L_ValueFX1
            // 
            this.L_ValueFX1.AutoSize = true;
            this.L_ValueFX1.Location = new System.Drawing.Point(77, 118);
            this.L_ValueFX1.Name = "L_ValueFX1";
            this.L_ValueFX1.Size = new System.Drawing.Size(17, 17);
            this.L_ValueFX1.TabIndex = 18;
            this.L_ValueFX1.Text = "0";
            // 
            // L_ValueFX0
            // 
            this.L_ValueFX0.AutoSize = true;
            this.L_ValueFX0.Location = new System.Drawing.Point(77, 88);
            this.L_ValueFX0.Name = "L_ValueFX0";
            this.L_ValueFX0.Size = new System.Drawing.Size(17, 17);
            this.L_ValueFX0.TabIndex = 17;
            this.L_ValueFX0.Text = "0";
            // 
            // L_Initial
            // 
            this.L_Initial.AutoSize = true;
            this.L_Initial.Location = new System.Drawing.Point(12, 9);
            this.L_Initial.Name = "L_Initial";
            this.L_Initial.Size = new System.Drawing.Size(101, 17);
            this.L_Initial.TabIndex = 19;
            this.L_Initial.Text = "Initial Values";
            // 
            // L_TableX0
            // 
            this.L_TableX0.AutoSize = true;
            this.L_TableX0.Location = new System.Drawing.Point(200, 86);
            this.L_TableX0.Name = "L_TableX0";
            this.L_TableX0.Size = new System.Drawing.Size(27, 17);
            this.L_TableX0.TabIndex = 20;
            this.L_TableX0.Text = "X0";
            // 
            // L_TableX2
            // 
            this.L_TableX2.AutoSize = true;
            this.L_TableX2.Location = new System.Drawing.Point(321, 86);
            this.L_TableX2.Name = "L_TableX2";
            this.L_TableX2.Size = new System.Drawing.Size(27, 17);
            this.L_TableX2.TabIndex = 21;
            this.L_TableX2.Text = "X2";
            // 
            // L_TableX3
            // 
            this.L_TableX3.AutoSize = true;
            this.L_TableX3.Location = new System.Drawing.Point(452, 86);
            this.L_TableX3.Name = "L_TableX3";
            this.L_TableX3.Size = new System.Drawing.Size(27, 17);
            this.L_TableX3.TabIndex = 22;
            this.L_TableX3.Text = "X1";
            // 
            // L_TableFX1
            // 
            this.L_TableFX1.AutoSize = true;
            this.L_TableFX1.Location = new System.Drawing.Point(836, 86);
            this.L_TableFX1.Name = "L_TableFX1";
            this.L_TableFX1.Size = new System.Drawing.Size(45, 17);
            this.L_TableFX1.TabIndex = 25;
            this.L_TableFX1.Text = "F(x1)";
            // 
            // L_TableFX2
            // 
            this.L_TableFX2.AutoSize = true;
            this.L_TableFX2.Location = new System.Drawing.Point(707, 86);
            this.L_TableFX2.Name = "L_TableFX2";
            this.L_TableFX2.Size = new System.Drawing.Size(45, 17);
            this.L_TableFX2.TabIndex = 24;
            this.L_TableFX2.Text = "F(x2)";
            // 
            // L_TableFX0
            // 
            this.L_TableFX0.AutoSize = true;
            this.L_TableFX0.Location = new System.Drawing.Point(577, 86);
            this.L_TableFX0.Name = "L_TableFX0";
            this.L_TableFX0.Size = new System.Drawing.Size(45, 17);
            this.L_TableFX0.TabIndex = 23;
            this.L_TableFX0.Text = "F(x0)";
            // 
            // LB_ValueX0
            // 
            this.LB_ValueX0.FormattingEnabled = true;
            this.LB_ValueX0.ItemHeight = 16;
            this.LB_ValueX0.Location = new System.Drawing.Point(153, 106);
            this.LB_ValueX0.Name = "LB_ValueX0";
            this.LB_ValueX0.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueX0.TabIndex = 26;
            // 
            // LB_ValueX2
            // 
            this.LB_ValueX2.FormattingEnabled = true;
            this.LB_ValueX2.ItemHeight = 16;
            this.LB_ValueX2.Location = new System.Drawing.Point(279, 106);
            this.LB_ValueX2.Name = "LB_ValueX2";
            this.LB_ValueX2.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueX2.TabIndex = 27;
            // 
            // LB_ValueX1
            // 
            this.LB_ValueX1.FormattingEnabled = true;
            this.LB_ValueX1.ItemHeight = 16;
            this.LB_ValueX1.Location = new System.Drawing.Point(405, 106);
            this.LB_ValueX1.Name = "LB_ValueX1";
            this.LB_ValueX1.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueX1.TabIndex = 28;
            // 
            // LB_ValueFX1
            // 
            this.LB_ValueFX1.FormattingEnabled = true;
            this.LB_ValueFX1.ItemHeight = 16;
            this.LB_ValueFX1.Location = new System.Drawing.Point(797, 106);
            this.LB_ValueFX1.Name = "LB_ValueFX1";
            this.LB_ValueFX1.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueFX1.TabIndex = 31;
            // 
            // LB_ValueFX2
            // 
            this.LB_ValueFX2.FormattingEnabled = true;
            this.LB_ValueFX2.ItemHeight = 16;
            this.LB_ValueFX2.Location = new System.Drawing.Point(667, 106);
            this.LB_ValueFX2.Name = "LB_ValueFX2";
            this.LB_ValueFX2.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueFX2.TabIndex = 30;
            // 
            // LB_ValueFX0
            // 
            this.LB_ValueFX0.FormattingEnabled = true;
            this.LB_ValueFX0.ItemHeight = 16;
            this.LB_ValueFX0.Location = new System.Drawing.Point(541, 106);
            this.LB_ValueFX0.Name = "LB_ValueFX0";
            this.LB_ValueFX0.Size = new System.Drawing.Size(120, 356);
            this.LB_ValueFX0.TabIndex = 29;
            // 
            // TB_Terminating
            // 
            this.TB_Terminating.Location = new System.Drawing.Point(62, 152);
            this.TB_Terminating.Name = "TB_Terminating";
            this.TB_Terminating.Size = new System.Drawing.Size(76, 22);
            this.TB_Terminating.TabIndex = 32;
            // 
            // L_Terminating
            // 
            this.L_Terminating.AutoSize = true;
            this.L_Terminating.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Terminating.Location = new System.Drawing.Point(12, 155);
            this.L_Terminating.Name = "L_Terminating";
            this.L_Terminating.Size = new System.Drawing.Size(50, 17);
            this.L_Terminating.TabIndex = 33;
            this.L_Terminating.Text = "Ea <=";
            // 
            // B_Reset
            // 
            this.B_Reset.Location = new System.Drawing.Point(15, 227);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(102, 23);
            this.B_Reset.TabIndex = 34;
            this.B_Reset.Text = "Reset";
            this.B_Reset.UseVisualStyleBackColor = true;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // L_Root
            // 
            this.L_Root.AutoSize = true;
            this.L_Root.Location = new System.Drawing.Point(12, 280);
            this.L_Root.Name = "L_Root";
            this.L_Root.Size = new System.Drawing.Size(119, 17);
            this.L_Root.TabIndex = 35;
            this.L_Root.Text = "Computed Root";
            // 
            // L_ValueRoot
            // 
            this.L_ValueRoot.AutoSize = true;
            this.L_ValueRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ValueRoot.Location = new System.Drawing.Point(52, 309);
            this.L_ValueRoot.Name = "L_ValueRoot";
            this.L_ValueRoot.Size = new System.Drawing.Size(19, 20);
            this.L_ValueRoot.TabIndex = 36;
            this.L_ValueRoot.Text = "0";
            // 
            // Bisection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 489);
            this.Controls.Add(this.L_ValueRoot);
            this.Controls.Add(this.L_Root);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.L_Terminating);
            this.Controls.Add(this.TB_Terminating);
            this.Controls.Add(this.LB_ValueFX1);
            this.Controls.Add(this.LB_ValueFX2);
            this.Controls.Add(this.LB_ValueFX0);
            this.Controls.Add(this.LB_ValueX1);
            this.Controls.Add(this.LB_ValueX2);
            this.Controls.Add(this.LB_ValueX0);
            this.Controls.Add(this.L_TableFX1);
            this.Controls.Add(this.L_TableFX2);
            this.Controls.Add(this.L_TableFX0);
            this.Controls.Add(this.L_TableX3);
            this.Controls.Add(this.L_TableX2);
            this.Controls.Add(this.L_TableX0);
            this.Controls.Add(this.L_Initial);
            this.Controls.Add(this.L_ValueFX1);
            this.Controls.Add(this.L_ValueFX0);
            this.Controls.Add(this.L_FX1);
            this.Controls.Add(this.L_FX0);
            this.Controls.Add(this.L_ValueX1);
            this.Controls.Add(this.L_ValueX0);
            this.Controls.Add(this.L_X1);
            this.Controls.Add(this.L_X0);
            this.Controls.Add(this.B_FindRoot);
            this.Controls.Add(this.L_Fx);
            this.Controls.Add(this.L_Order0);
            this.Controls.Add(this.TB_Order0);
            this.Controls.Add(this.L_Order1);
            this.Controls.Add(this.TB_Order1);
            this.Controls.Add(this.L_Order2);
            this.Controls.Add(this.TB_Order2);
            this.Controls.Add(this.L_Order3);
            this.Controls.Add(this.TB_Order3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(947, 536);
            this.MinimumSize = new System.Drawing.Size(947, 536);
            this.Name = "Bisection";
            this.Text = "Bisection Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Order3;
        private System.Windows.Forms.Label L_Order3;
        private System.Windows.Forms.Label L_Order2;
        private System.Windows.Forms.TextBox TB_Order2;
        private System.Windows.Forms.Label L_Order1;
        private System.Windows.Forms.TextBox TB_Order1;
        private System.Windows.Forms.Label L_Order0;
        private System.Windows.Forms.TextBox TB_Order0;
        private System.Windows.Forms.Label L_Fx;
        private System.Windows.Forms.Button B_FindRoot;
        private System.Windows.Forms.Label L_X0;
        private System.Windows.Forms.Label L_X1;
        private System.Windows.Forms.Label L_ValueX0;
        private System.Windows.Forms.Label L_ValueX1;
        private System.Windows.Forms.Label L_FX1;
        private System.Windows.Forms.Label L_FX0;
        private System.Windows.Forms.Label L_ValueFX1;
        private System.Windows.Forms.Label L_ValueFX0;
        private System.Windows.Forms.Label L_Initial;
        private System.Windows.Forms.Label L_TableX0;
        private System.Windows.Forms.Label L_TableX2;
        private System.Windows.Forms.Label L_TableX3;
        private System.Windows.Forms.Label L_TableFX1;
        private System.Windows.Forms.Label L_TableFX2;
        private System.Windows.Forms.Label L_TableFX0;
        private System.Windows.Forms.ListBox LB_ValueX0;
        private System.Windows.Forms.ListBox LB_ValueX2;
        private System.Windows.Forms.ListBox LB_ValueX1;
        private System.Windows.Forms.ListBox LB_ValueFX1;
        private System.Windows.Forms.ListBox LB_ValueFX2;
        private System.Windows.Forms.ListBox LB_ValueFX0;
        private System.Windows.Forms.TextBox TB_Terminating;
        private System.Windows.Forms.Label L_Terminating;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Label L_Root;
        private System.Windows.Forms.Label L_ValueRoot;
    }
}