using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_Ex01_FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Application Loaded");
            function1();
        }

        public void function1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            btn_clickMe.Size = new Size(10, 10);
        }
    }
}
