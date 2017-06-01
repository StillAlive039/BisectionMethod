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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Order3
            // 
            this.TB_Order3.Location = new System.Drawing.Point(278, 34);
            this.TB_Order3.Name = "TB_Order3";
            this.TB_Order3.Size = new System.Drawing.Size(43, 22);
            this.TB_Order3.TabIndex = 0;
            // 
            // L_Order3
            // 
            this.L_Order3.AutoSize = true;
            this.L_Order3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order3.Location = new System.Drawing.Point(327, 34);
            this.L_Order3.Name = "L_Order3";
            this.L_Order3.Size = new System.Drawing.Size(32, 17);
            this.L_Order3.TabIndex = 1;
            this.L_Order3.Text = "x^3";
            // 
            // L_Order2
            // 
            this.L_Order2.AutoSize = true;
            this.L_Order2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order2.Location = new System.Drawing.Point(433, 34);
            this.L_Order2.Name = "L_Order2";
            this.L_Order2.Size = new System.Drawing.Size(32, 17);
            this.L_Order2.TabIndex = 3;
            this.L_Order2.Text = "x^2";
            // 
            // TB_Order2
            // 
            this.TB_Order2.Location = new System.Drawing.Point(384, 34);
            this.TB_Order2.Name = "TB_Order2";
            this.TB_Order2.Size = new System.Drawing.Size(43, 22);
            this.TB_Order2.TabIndex = 2;
            // 
            // L_Order1
            // 
            this.L_Order1.AutoSize = true;
            this.L_Order1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order1.Location = new System.Drawing.Point(539, 34);
            this.L_Order1.Name = "L_Order1";
            this.L_Order1.Size = new System.Drawing.Size(15, 17);
            this.L_Order1.TabIndex = 5;
            this.L_Order1.Text = "x";
            // 
            // TB_Order1
            // 
            this.TB_Order1.Location = new System.Drawing.Point(490, 34);
            this.TB_Order1.Name = "TB_Order1";
            this.TB_Order1.Size = new System.Drawing.Size(43, 22);
            this.TB_Order1.TabIndex = 4;
            // 
            // L_Order0
            // 
            this.L_Order0.AutoSize = true;
            this.L_Order0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Order0.Location = new System.Drawing.Point(588, 34);
            this.L_Order0.Name = "L_Order0";
            this.L_Order0.Size = new System.Drawing.Size(0, 17);
            this.L_Order0.TabIndex = 7;
            // 
            // TB_Order0
            // 
            this.TB_Order0.Location = new System.Drawing.Point(591, 34);
            this.TB_Order0.Name = "TB_Order0";
            this.TB_Order0.Size = new System.Drawing.Size(43, 22);
            this.TB_Order0.TabIndex = 6;
            // 
            // L_Fx
            // 
            this.L_Fx.AutoSize = true;
            this.L_Fx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fx.Location = new System.Drawing.Point(220, 34);
            this.L_Fx.Name = "L_Fx";
            this.L_Fx.Size = new System.Drawing.Size(50, 17);
            this.L_Fx.TabIndex = 8;
            this.L_Fx.Text = "F(x) =";
            // 
            // B_FindRoot
            // 
            this.B_FindRoot.Location = new System.Drawing.Point(591, 399);
            this.B_FindRoot.Name = "B_FindRoot";
            this.B_FindRoot.Size = new System.Drawing.Size(91, 23);
            this.B_FindRoot.TabIndex = 9;
            this.B_FindRoot.Text = "Find Root";
            this.B_FindRoot.UseVisualStyleBackColor = true;
            this.B_FindRoot.Click += new System.EventHandler(this.B_FindRoot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // Bisection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}