using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Overload x = new Overload();

            double triangle = x.CalculateArea(10, 15, 0.5);
            listBox1.Items.Add("Triangle Area: " + triangle);
            textBox1.Text = triangle.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overload x = new Overload();

            int rectangle = x.CalculateArea(25, 50);
            listBox1.Items.Add("Rectangle Area: " + rectangle);
            textBox1.Text = rectangle.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Overload x = new Overload();

            double circle = x.CalculateArea(20);
            listBox1.Items.Add("Circle Area: " + circle);
            textBox1.Text = circle.ToString();
        }
    }
}
