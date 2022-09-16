using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private bool CheckParse(string a)
		{
			double s;
			bool flag;
			flag = double.TryParse(a, out s);
			return flag;
		}

		private double Parse(string a)
		{
			double s;
			double.TryParse(a, out s);
			return s;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string density = textBoxDensity.Text;
			if (CheckParse(density) == false || Parse(density) == 0)
			{
				MessageBox.Show("Некорректные данные в строке {Плотность}  ");
				return;
			}
			string radius = textBoxRadius.Text;
			if (CheckParse(radius) == false || Parse(radius) == 0)
			{
				MessageBox.Show("Некорректные данные в строке {Радиус}  ");
				return;
			}
			string weight = textBoxWeight.Text;
			if (CheckParse(weight) == false || Parse(weight) == 0)
			{
				MessageBox.Show("Некорректные данные в строке {Масса}  ");
				return;
			}

			double width = Parse(weight) / (Math.PI * Math.Pow(Parse(radius), 2) * Parse(density));
			MessageBox.Show("Толщина (м) равна " +
				Convert.ToString(width));
		}
	}
}
