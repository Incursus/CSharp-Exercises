using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Throw
{
    //http://forums.asp.net/t/1306211.aspx?C+Throwing+specific+error+exception+text+
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exception exception = new Exception("Test");
            throw exception;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Doing nothing");
        }
    }
}
