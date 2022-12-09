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

namespace prog4._2form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static string decTwo(int n)
		{
			return (n == 0) ? "0" : decTwo2(n);
		}
		static string decTwo2(int n)
		{
			if (n >= 0)
			{
				return (n > 0) ? decTwo2(n / 2) + ((n % 2 == 0) ? "0" : "1") : "";
			}
			else
			{
				return (n < 0) ? decTwo2(n / 2) + ((n % 2 == 0) ? "0" : "1") : "";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int n = int.Parse(numericUpDown1.Text, NumberStyles.Float);

			textBox1.Text = "Результат перевода:\r\n" + (n > 0 ? "" : "-") + decTwo(n);
		}
	}
}
