using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SolutionWaveEquation
{
    class Solution
    {
        private double[,] u_grid;
        private double step_x;
        private double step_t;
        private int n;
        private int m;
        private double a;

        private double L;

        private double u_0_t() // фикс => 0
        {
            return 0;
        }

        private double u_l_t() // фикс => 0
        {
            return 0;
        }

        private double u_x_0(int i)
        {
            double x = i * step_x;
            return 0; // фи(x)
        }

        private double u_x_0_derivative_t(int i)
        {
            double x = i * step_x;
            return 0; // пси(x)
        }

        private double func_i_j(int i, int j)
        {
            double x = i * step_x;
            double t = j * step_t;
            return Math.Sin(x / 2); // f(x,t)
        }

        public Solution(double l, double T, int _n, int _m, double _a)
        {
            a = _a;
            n = _n;
            m = _m;
            step_x = l / n;
            step_t = T / m;
            L = (a * a) * (step_t * step_t) / (step_x * step_x);
            u_grid = new double[n + 1, m + 1];
            for (int j = 0; j <= m; j++)
            {
                u_grid[0, j] = 0;
                u_grid[n, j] = 0;
            }
            for (int i = 0; i <= n; i++)
            {
                u_grid[i, 0] = u_x_0(i);
                u_grid[i, 1] = u_grid[i, 0] + step_t * u_x_0_derivative_t(i);
            }
        }

        public void RunWE() // волновое
        {
            for (int j = 1; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    u_grid[i, j + 1] = 2 * (1 - L) * u_grid[i, j] + L * (u_grid[i + 1, j] + u_grid[i - 1, j]) -
                                       u_grid[i, j - 1] + step_t * step_t * func_i_j(i, j);
                }
            }
        }

        public void RunTE() // теплопроводности
        {
            double p = (a * step_t) / (step_x * step_x);

            for (int j = 0; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    u_grid[i, j + 1] = u_grid[i, j] + p * (u_grid[i + 1, j] - 2 * u_grid[i, j] + u_grid[i - 1, j])
                                       + step_t * func_i_j(i, j);
                }
            }
        }

        public void PrintGrid()
        {
            string fileName = "../../../out.csv";

            using (var file = new FileStream(fileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(file))
                {
                    double x;
                    double t;
                    string s;
                    s = (n + 1).ToString() + ';' + (m + 1).ToString();
                    sw.WriteLine(s);
                    for (int j = 0; j <= m; j++)
                    {
                        t = step_t * j;
                        for (int i = 0; i <= n; i++)
                        {
                            x = step_x * i;
                            s = x.ToString().Replace(",", ".") + ';' + t.ToString().Replace(",", ".") + ';' + u_grid[i, j].ToString().Replace(",", ".");
                            sw.WriteLine(s);
                        }
                    }
                }
            }
        }

        public bool CheckСonvergenceWE() //проверка сходимости волнового
        {
            double p = (a * step_t) / step_x;
            if (p < 1)
            {
                return true;
            }
            return false;
        }
        public bool CheckСonvergenceTE() //проверка сходимости теплопроводности
        {
            double p = (a * step_t) / (step_x * step_x);
            if (p <= 0.5)
            {
                return true;
            }
            return false;
        }
    }
}
