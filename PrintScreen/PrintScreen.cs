using MyLibrary;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Diversos
{
    public partial class PrintScreen : Form
    {
        public PrintScreen()
        {
            InitializeComponent();
        }

        private void btn_print_screen_Click(object sender, EventArgs e)
        {
            SimpleFunctions.PrintScreen(Screen.AllScreens, @"C:\Users\marcelosr\Desktop\printscreen.png", ImageFormat.Png);
        }
    }
}
