using System.Diagnostics;
using System.Windows.Forms;

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
