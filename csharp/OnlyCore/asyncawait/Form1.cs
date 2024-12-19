using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncawait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = await CalculateAsync(100, 10000000);
        }
        public static async Task<string> CalculateAsync(int a, int d)
        {
            BigInteger bigInteger = 1;

            await Task.Run(() =>
            {
                for (int i = 0; i < d; i++)
                {
                    bigInteger *= a;
                }
            });
            return bigInteger.ToString();
        }
    }
}
