using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr_Project
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            LonelinessNumericUpDown.Value = Game.GetLonelinessThreshold();
            OverpopulationNumericUpDown.Value = Game.GetOverpopulation();
            BirthConditionNumericUpDown.Value = Game.GetBirthCondition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.SetLonelinessThreshold(Convert.ToInt32(LonelinessNumericUpDown.Value));
            Game.SetOverpopulationThreshold(Convert.ToInt32(OverpopulationNumericUpDown.Value));
            Game.SetBirthCondition(Convert.ToInt32(BirthConditionNumericUpDown.Value));
            this.Close();
        }
    }
}
