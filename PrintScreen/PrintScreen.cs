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

            SimpleFunctions.PrintScreen(Screen.AllScreens, @"C:\Users\marcelosr\Desktop\printscreen.png", ImageFormat.Png);
        }
    }
}
