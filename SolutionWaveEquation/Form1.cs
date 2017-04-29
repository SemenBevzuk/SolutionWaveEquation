using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionWaveEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Solution sol;
            try
            {
                double l = Convert.ToDouble(textBox_l.Text);
                double T = Convert.ToDouble(textBox_T.Text);
                int n = Convert.ToInt32(textBox_n.Text);
                int m = Convert.ToInt32(textBox_m.Text);
                double a = Convert.ToDouble(textBox_a.Text);
                sol = new Solution(l, T, n, m, a);

                if (radioButton_TE.Checked)
                {
                    if (sol.CheckСonvergenceTE())
                    {
                        richTextBox_Out.AppendText("Метод для теплопроводности сходитится.\n");
                        sol.RunTE();
                        sol.PrintGrid();
                        richTextBox_Out.AppendText("Файл сохранён.\n");
                    }
                    else
                    {
                        richTextBox_Out.AppendText("Метод для теплопроводности не сходитится.\n");
                        MessageBox.Show("С данными параметрами метод не является устойчивым.");
                    }
                }
                if (radioButton_WE.Checked)
                {
                    if (sol.CheckСonvergenceWE())
                    {
                        richTextBox_Out.AppendText("Метод для волнового сходитится.\n");
                        sol.RunWE();
                        sol.PrintGrid();
                        richTextBox_Out.AppendText("Файл сохранён.\n");
                    }
                    else
                    {
                        richTextBox_Out.AppendText("Метод для волнового     не сходитится.\n");
                        MessageBox.Show("С данными параметрами метод не является устойчивым.");
                    }
                }

                richTextBox_Out.SelectionStart = richTextBox_Out.Text.Length;
                richTextBox_Out.ScrollToCaret();
            }
            catch
            {
                MessageBox.Show("Введите данные корректно.");
            }
        }
    }
}
