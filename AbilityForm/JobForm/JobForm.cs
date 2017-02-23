using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobForm
{
    public partial class JobForm : Form
    {
        public RaceForm previousForm;

        private int _warriorHealth = 12;
        private int _thiefHealth = 8;
        private int _mageHealth = 4;
        private int _priestHealth = 6;
        private string _raceSelect;

        private int _constitutionHealthMod = Convert.ToInt32(Program.character.Constitution);

        
        public JobForm()
        {
            InitializeComponent();
        }

        private void JobForm_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Health = healthTextBox.Text;
            character.Job = _raceSelect.ToString();

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }

        //Adds Constitution Mod to Base Health pool based on Class/Job
        private void warriorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            healthTextBox.Text = (_warriorHealth + _constitutionHealthMod).ToString;
            RadioButton RaceSelect = (RadioButton)sender;

            this._raceSelect = RaceSelect.Text;
        }

        private void thiefRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            healthTextBox.Text = (_thiefHealth + _constitutionHealthMod).ToString;
            RadioButton RaceSelect = (RadioButton)sender;

            this._raceSelect = RaceSelect.Text;
        }

        private void mageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            healthTextBox.Text = (_mageHealth + _constitutionHealthMod).ToString;
            RadioButton RaceSelect = (RadioButton)sender;

            this._raceSelect = RaceSelect.Text;
        }

        private void priestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            healthTextBox.Text = (_priestHealth + _constitutionHealthMod).ToString;
            RadioButton RaceSelect = (RadioButton)sender;

            this._raceSelect = RaceSelect.Text;
        }
    }
}
