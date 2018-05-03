using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        private const int _QTD_MINUTOS = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                SendKeys.Send("%{SCROLLLOCK}");
                Thread.Sleep(1000);
                SendKeys.Send("%{SCROLLLOCK}");
                Thread.Sleep(_QTD_MINUTOS * 1000 * 60);
            }
        }
    }
}
