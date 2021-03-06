﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Unlock : System.Windows.Forms.Form
    {
        private const int _QTD_MINUTOS = 3;

        public Unlock()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manager_Scroll();
        }

        private void Manager_Scroll()
        {
            do
            {
                try
                {
                    SendKeys.Send("%{SCROLLLOCK}");
                    Thread.Sleep(1000);
                    SendKeys.Send("%{SCROLLLOCK}");
                    Thread.Sleep(_QTD_MINUTOS * 1000 * 60);
                }
                catch (Exception) { }
            } while (true);
        }
    }
}
