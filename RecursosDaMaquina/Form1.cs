using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RecursosDaMaquina
{
    public partial class Form1 : Form
    {
        protected PerformanceCounter cpuCounter; 
        protected PerformanceCounter ramCounter; 

        public Form1()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter();

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            getCurrentCpuUsage();

            ramCounter = new PerformanceCounter("Memory", "Available MBytes"); 
        }

        public string getCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }

        /* 
        Call this method every time you need to get 
        the amount of the available RAM in Mb 
        */
        public string getAvailableRAM()
        {
            return ramCounter.NextValue() + "Mb";
        }
    }
}
