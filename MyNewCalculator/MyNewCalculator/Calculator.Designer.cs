namespace MyNewCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.err_not_valid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output_calculation = new System.Windows.Forms.TextBox();
            this.output_result = new System.Windows.Forms.TextBox();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_rightBracket = new System.Windows.Forms.Button();
            this.button_leftBracket = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_times = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_num0 = new System.Windows.Forms.Button();
            this.button_num9 = new System.Windows.Forms.Button();
            this.button_num8 = new System.Windows.Forms.Button();
            this.button_num7 = new System.Windows.Forms.Button();
            this.button_num6 = new System.Windows.Forms.Button();
            this.button_num5 = new System.Windows.Forms.Button();
            this.button_num4 = new System.Windows.Forms.Button();
            this.button_num3 = new System.Windows.Forms.Button();
            this.button_num2 = new System.Windows.Forms.Button();
            this.button_num1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // err_not_valid
            // 
            this.err_not_valid.AutoSize = true;
            this.err_not_valid.BackColor = System.Drawing.SystemColors.Control;
            this.err_not_valid.ForeColor = System.Drawing.Color.Red;
            this.err_not_valid.Location = new System.Drawing.Point(243, 882);
            this.err_not_valid.Name = "err_not_valid";
            this.err_not_valid.Size = new System.Drawing.Size(272, 32);
            this.err_not_valid.TabIndex = 45;
            this.err_not_valid.Text = "Calculation not valid";
            this.err_not_valid.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.output_calculation);
            this.panel1.Controls.Add(this.output_result);
            this.panel1.Location = new System.Drawing.Point(123, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 115);
            this.panel1.TabIndex = 44;
            // 
            // output_calculation
            // 
            this.output_calculation.BackColor = System.Drawing.Color.White;
            this.output_calculation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_calculation.Enabled = false;
            this.output_calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_calculation.Location = new System.Drawing.Point(78, 13);
            this.output_calculation.Name = "output_calculation";
            this.output_calculation.Size = new System.Drawing.Size(400, 38);
            this.output_calculation.TabIndex = 24;
            this.output_calculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // output_result
            // 
            this.output_result.BackColor = System.Drawing.Color.White;
            this.output_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_result.Enabled = false;
            this.output_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_result.Location = new System.Drawing.Point(78, 48);
            this.output_result.Name = "output_result";
            this.output_result.Size = new System.Drawing.Size(400, 54);
            this.output_result.TabIndex = 23;
            this.output_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.BackColor = System.Drawing.Color.Orange;
            this.button_ClearEntry.FlatAppearance.BorderSize = 0;
            this.button_ClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearEntry.ForeColor = System.Drawing.Color.White;
            this.button_ClearEntry.Location = new System.Drawing.Point(249, 240);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(120, 120);
            this.button_ClearEntry.TabIndex = 43;
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = false;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Orange;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(123, 240);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(120, 120);
            this.button_Clear.TabIndex = 42;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_rightBracket
            // 
            this.button_rightBracket.BackColor = System.Drawing.Color.Silver;
            this.button_rightBracket.FlatAppearance.BorderSize = 0;
            this.button_rightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rightBracket.Location = new System.Drawing.Point(501, 240);
            this.button_rightBracket.Name = "button_rightBracket";
            this.button_rightBracket.Size = new System.Drawing.Size(120, 120);
            this.button_rightBracket.TabIndex = 41;
            this.button_rightBracket.Text = ")";
            this.button_rightBracket.UseVisualStyleBackColor = false;
            this.button_rightBracket.Click += new System.EventHandler(this.button_rightBracket_Click);
            // 
            // button_leftBracket
            // 
            this.button_leftBracket.BackColor = System.Drawing.Color.Silver;
            this.button_leftBracket.FlatAppearance.BorderSize = 0;
            this.button_leftBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_leftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_leftBracket.Location = new System.Drawing.Point(375, 240);
            this.button_leftBracket.Name = "button_leftBracket";
            this.button_leftBracket.Size = new System.Drawing.Size(120, 120);
            this.button_leftBracket.TabIndex = 40;
            this.button_leftBracket.Text = "(";
            this.button_leftBracket.UseVisualStyleBackColor = false;
            this.button_leftBracket.Click += new System.EventHandler(this.button_leftBracket_Click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.Gainsboro;
            this.button_equals.FlatAppearance.BorderSize = 0;
            this.button_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equals.Location = new System.Drawing.Point(375, 744);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(120, 120);
            this.button_equals.TabIndex = 39;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.Gainsboro;
            this.button_dot.FlatAppearance.BorderSize = 0;
            this.button_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.Location = new System.Drawing.Point(249, 744);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(120, 120);
            this.button_dot.TabIndex = 38;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_divide
            // 
            this.button_divide.BackColor = System.Drawing.Color.Silver;
            this.button_divide.FlatAppearance.BorderSize = 0;
            this.button_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(501, 366);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(120, 120);
            this.button_divide.TabIndex = 37;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = false;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_times
            // 
            this.button_times.BackColor = System.Drawing.Color.Silver;
            this.button_times.FlatAppearance.BorderSize = 0;
            this.button_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_times.Location = new System.Drawing.Point(501, 492);
            this.button_times.Name = "button_times";
            this.button_times.Size = new System.Drawing.Size(120, 120);
            this.button_times.TabIndex = 36;
            this.button_times.Text = "x";
            this.button_times.UseVisualStyleBackColor = false;
            this.button_times.Click += new System.EventHandler(this.button_times_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.Silver;
            this.button_minus.FlatAppearance.BorderSize = 0;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(501, 618);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(120, 120);
            this.button_minus.TabIndex = 35;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.Silver;
            this.button_plus.FlatAppearance.BorderSize = 0;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(501, 744);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(120, 120);
            this.button_plus.TabIndex = 34;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_num0
            // 
            this.button_num0.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num0.FlatAppearance.BorderSize = 0;
            this.button_num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num0.Location = new System.Drawing.Point(123, 744);
            this.button_num0.Name = "button_num0";
            this.button_num0.Size = new System.Drawing.Size(120, 120);
            this.button_num0.TabIndex = 33;
            this.button_num0.Text = "0";
            this.button_num0.UseVisualStyleBackColor = false;
            this.button_num0.Click += new System.EventHandler(this.button_num0_Click);
            // 
            // button_num9
            // 
            this.button_num9.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num9.FlatAppearance.BorderSize = 0;
            this.button_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num9.Location = new System.Drawing.Point(375, 366);
            this.button_num9.Name = "button_num9";
            this.button_num9.Size = new System.Drawing.Size(120, 120);
            this.button_num9.TabIndex = 32;
            this.button_num9.Text = "9";
            this.button_num9.UseVisualStyleBackColor = false;
            this.button_num9.Click += new System.EventHandler(this.button_num9_Click);
            // 
            // button_num8
            // 
            this.button_num8.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num8.FlatAppearance.BorderSize = 0;
            this.button_num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num8.Location = new System.Drawing.Point(249, 366);
            this.button_num8.Name = "button_num8";
            this.button_num8.Size = new System.Drawing.Size(120, 120);
            this.button_num8.TabIndex = 31;
            this.button_num8.Text = "8";
            this.button_num8.UseVisualStyleBackColor = false;
            this.button_num8.Click += new System.EventHandler(this.button_num8_Click);
            // 
            // button_num7
            // 
            this.button_num7.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num7.FlatAppearance.BorderSize = 0;
            this.button_num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num7.Location = new System.Drawing.Point(123, 366);
            this.button_num7.Name = "button_num7";
            this.button_num7.Size = new System.Drawing.Size(120, 120);
            this.button_num7.TabIndex = 30;
            this.button_num7.Text = "7";
            this.button_num7.UseVisualStyleBackColor = false;
            this.button_num7.Click += new System.EventHandler(this.button_num7_Click);
            // 
            // button_num6
            // 
            this.button_num6.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num6.FlatAppearance.BorderSize = 0;
            this.button_num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num6.Location = new System.Drawing.Point(375, 492);
            this.button_num6.Name = "button_num6";
            this.button_num6.Size = new System.Drawing.Size(120, 120);
            this.button_num6.TabIndex = 29;
            this.button_num6.Text = "6";
            this.button_num6.UseVisualStyleBackColor = false;
            this.button_num6.Click += new System.EventHandler(this.button_num6_Click);
            // 
            // button_num5
            // 
            this.button_num5.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num5.FlatAppearance.BorderSize = 0;
            this.button_num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num5.Location = new System.Drawing.Point(249, 492);
            this.button_num5.Name = "button_num5";
            this.button_num5.Size = new System.Drawing.Size(120, 120);
            this.button_num5.TabIndex = 28;
            this.button_num5.Text = "5";
            this.button_num5.UseVisualStyleBackColor = false;
            this.button_num5.Click += new System.EventHandler(this.button_num5_Click);
            // 
            // button_num4
            // 
            this.button_num4.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num4.FlatAppearance.BorderSize = 0;
            this.button_num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num4.Location = new System.Drawing.Point(123, 492);
            this.button_num4.Name = "button_num4";
            this.button_num4.Size = new System.Drawing.Size(120, 120);
            this.button_num4.TabIndex = 27;
            this.button_num4.Text = "4";
            this.button_num4.UseVisualStyleBackColor = false;
            this.button_num4.Click += new System.EventHandler(this.button_num4_Click);
            // 
            // button_num3
            // 
            this.button_num3.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num3.FlatAppearance.BorderSize = 0;
            this.button_num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num3.Location = new System.Drawing.Point(375, 618);
            this.button_num3.Name = "button_num3";
            this.button_num3.Size = new System.Drawing.Size(120, 120);
            this.button_num3.TabIndex = 26;
            this.button_num3.Text = "3";
            this.button_num3.UseVisualStyleBackColor = false;
            this.button_num3.Click += new System.EventHandler(this.button_num3_Click);
            // 
            // button_num2
            // 
            this.button_num2.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num2.FlatAppearance.BorderSize = 0;
            this.button_num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num2.Location = new System.Drawing.Point(249, 618);
            this.button_num2.Name = "button_num2";
            this.button_num2.Size = new System.Drawing.Size(120, 120);
            this.button_num2.TabIndex = 25;
            this.button_num2.Text = "2";
            this.button_num2.UseVisualStyleBackColor = false;
            this.button_num2.Click += new System.EventHandler(this.button_num2_Click);
            // 
            // button_num1
            // 
            this.button_num1.BackColor = System.Drawing.Color.Gainsboro;
            this.button_num1.FlatAppearance.BorderSize = 0;
            this.button_num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_num1.Location = new System.Drawing.Point(123, 618);
            this.button_num1.Name = "button_num1";
            this.button_num1.Size = new System.Drawing.Size(120, 120);
            this.button_num1.TabIndex = 24;
            this.button_num1.Text = "1";
            this.button_num1.UseVisualStyleBackColor = false;
            this.button_num1.Click += new System.EventHandler(this.button_num1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1016);
            this.Controls.Add(this.err_not_valid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_ClearEntry);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_rightBracket);
            this.Controls.Add(this.button_leftBracket);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_times);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_num0);
            this.Controls.Add(this.button_num9);
            this.Controls.Add(this.button_num8);
            this.Controls.Add(this.button_num7);
            this.Controls.Add(this.button_num6);
            this.Controls.Add(this.button_num5);
            this.Controls.Add(this.button_num4);
            this.Controls.Add(this.button_num3);
            this.Controls.Add(this.button_num2);
            this.Controls.Add(this.button_num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label err_not_valid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox output_calculation;
        private System.Windows.Forms.TextBox output_result;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_rightBracket;
        private System.Windows.Forms.Button button_leftBracket;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_times;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_num0;
        private System.Windows.Forms.Button button_num9;
        private System.Windows.Forms.Button button_num8;
        private System.Windows.Forms.Button button_num7;
        private System.Windows.Forms.Button button_num6;
        private System.Windows.Forms.Button button_num5;
        private System.Windows.Forms.Button button_num4;
        private System.Windows.Forms.Button button_num3;
        private System.Windows.Forms.Button button_num2;
        private System.Windows.Forms.Button button_num1;
    }
}

