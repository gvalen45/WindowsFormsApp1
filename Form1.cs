using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			myServiceRef.Service1Client pxy = new myServiceRef.Service1Client();
			this.label1.Text = pxy.Hello();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			myServiceRef.Service1Client myPxy = new myServiceRef.Service1Client();
			this.label2.Text = myPxy.PiValue().ToString();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			myServiceRef.Service1Client myPxy = new myServiceRef.Service1Client(); 
			int number = Convert.ToInt32(this.textBox1.Text); 
			int result = myPxy.absValue(number);
			this.label3.Text = result.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			myServiceRef.Service1Client myPxy = new myServiceRef.Service1Client(); 
			int number = Convert.ToInt32(this.textBox2.Text); 
			double result = myPxy.absValue(number) + myPxy.PiValue(); 
			this.label4.Text = result.ToString();

		}
	}
}
