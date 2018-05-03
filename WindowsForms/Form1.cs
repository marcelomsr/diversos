using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        // Floor( 0.5 * Power * Atk / Def* STAB * Effective ) + 1
        // Attack = ( BaseAttack + AttackIV ) * CpM
        // Defense = (BaseDefense + DefenseIV) * CpM
        public Form1()
        {
            InitializeComponent();

            populate_levels();
            //populate_
        }

        private void populate_levels()
        {
            var values = Enum.GetValues(typeof(CpM.LevelCpM));

            foreach(CpM.LevelCpM value in values)
                cbo_level.Items.Add(value);
        }

        private void btn_calc_damage_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(SimpleFunctions.GetEnumDescription<CpM.LevelCpM>((CpM.LevelCpM)cbo_level.SelectedItem));

            MessageBox.Show(value.ToString());
        }
    }
}
