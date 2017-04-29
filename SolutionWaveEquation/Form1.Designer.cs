namespace SolutionWaveEquation
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
            this.Start = new System.Windows.Forms.Button();
            this.textBox_l = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.radioButton_WE = new System.Windows.Forms.RadioButton();
            this.radioButton_TE = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(248, 192);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(202, 112);
            this.Start.TabIndex = 0;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox_l
            // 
            this.textBox_l.Location = new System.Drawing.Point(72, 46);
            this.textBox_l.Name = "textBox_l";
            this.textBox_l.Size = new System.Drawing.Size(149, 26);
            this.textBox_l.TabIndex = 1;
            this.textBox_l.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "l = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "T = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "n = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "m = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "a = ";
            // 
            // textBox_T
            // 
            this.textBox_T.Location = new System.Drawing.Point(72, 84);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.Size = new System.Drawing.Size(149, 26);
            this.textBox_T.TabIndex = 7;
            this.textBox_T.Text = "5";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(72, 122);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(149, 26);
            this.textBox_n.TabIndex = 8;
            this.textBox_n.Text = "10";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(72, 156);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(149, 26);
            this.textBox_m.TabIndex = 9;
            this.textBox_m.Text = "100";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(72, 189);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(149, 26);
            this.textBox_a.TabIndex = 10;
            this.textBox_a.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(248, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(202, 136);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "l - длина струны по x\nT - промежуток по t\nn - число отрезков по x\nm - число отрез" +
    "ков по t\na - скорость волны";
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Location = new System.Drawing.Point(481, 36);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.Size = new System.Drawing.Size(405, 268);
            this.richTextBox_Out.TabIndex = 13;
            this.richTextBox_Out.Text = "";
            // 
            // radioButton_WE
            // 
            this.radioButton_WE.AutoSize = true;
            this.radioButton_WE.Location = new System.Drawing.Point(35, 236);
            this.radioButton_WE.Name = "radioButton_WE";
            this.radioButton_WE.Size = new System.Drawing.Size(109, 24);
            this.radioButton_WE.TabIndex = 14;
            this.radioButton_WE.Text = "Волновое";
            this.radioButton_WE.UseVisualStyleBackColor = true;
            // 
            // radioButton_TE
            // 
            this.radioButton_TE.AutoSize = true;
            this.radioButton_TE.Location = new System.Drawing.Point(35, 280);
            this.radioButton_TE.Name = "radioButton_TE";
            this.radioButton_TE.Size = new System.Drawing.Size(180, 24);
            this.radioButton_TE.TabIndex = 15;
            this.radioButton_TE.Text = "Теплопроводности";
            this.radioButton_TE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 341);
            this.Controls.Add(this.radioButton_TE);
            this.Controls.Add(this.radioButton_WE);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_l);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.RadioButton radioButton_WE;
        private System.Windows.Forms.RadioButton radioButton_TE;
    }
}

