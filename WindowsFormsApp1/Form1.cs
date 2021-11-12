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
        Double deger = 0;
        String islem = " ";
        bool islem_hareketi = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (islem_hareketi))
                result.Clear();
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            islem = b.Text;
            deger = Double.Parse(result.Text);
            islem_hareketi = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    result.Text = (deger + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (deger - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (deger * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (deger / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            islem_hareketi = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Clear();
            deger = 0;
        }
    }
}
