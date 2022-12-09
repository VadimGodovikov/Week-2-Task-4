using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog4._1form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private static double rec(int i, int N)
		{
			if (i == N) return Math.Sqrt(N);
			else return Math.Sqrt(i + rec(i + 1, N));
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int N = int.Parse(numericUpDown1.Text, NumberStyles.Float);

			if(N <= 0)
			{
				MessageBox.Show("Данное число не может быть меньше или равно 0");
				return;
			}

			ResultTextBox.Text = $"Результат вычисления данной функции: \r\n{N/rec(1, N):f4}";
		}
	}
}
