using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
            button1.Click += unique_Button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            Debug.WriteLine("Handling button click: {0}, {1}", sender.ToString(), mouseEventArgs.X);
        }
        
        void unique_Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("New test");
        }

    }
}
