using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceForm
{
    public partial class RaceForm : Form
    {
        public AbilityForm previousForm { get; set; }

        //Private Variables
        private string _selectedRace;

        private int _strengthMod = Convert.ToInt32(Program.character.Strength);
        private int _dexterityMod = Convert.ToInt32(Program.character.Dexterity);
        private int _constitutionMod = Convert.ToInt32(Program.character.Constitution);
        private int _intelligenceMod = Convert.ToInt32(Program.character.Intelligence);
        private int _wisdomMod = Convert.ToInt32(Program.character.Wisdom);
        private int _charismaMod = Convert.ToInt32(Program.character.Charisma);

        public RaceForm()
        {
            InitializeComponent();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = _selectedRace;

            character.Strength = _strengthMod.ToString();
            character.Dexterity = _dexterityMod.ToString();
            character.Constitution = _constitutionMod.ToString();
            character.Intelligence = _intelligenceMod.ToString();
            character.Wisdom = _wisdomMod.ToString();
            character.Charisma = _charismaMod.ToString();

            JobForm jobform = new JobForm();
            jobform.previousForm = this;

            jobform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Radio Button for Human
        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.M_Human1;
            RadioButton selectedRace = (RadioButton)sender;

            racialBonusTextBox.Text = "Increase all ability scores by 1";

            _strengthMod = _strengthMod + 1;
            _dexterityMod = _dexterityMod + 1;
            _constitutionMod = _constitutionMod + 1;
            _intelligenceMod = _intelligenceMod + 1;
            _wisdomMod = _wisdomMod + 1;
            _charismaMod = _charismaMod + 1;

            this._selectedRace = selectedRace.Text;
        }

        //Radio Button for Dwarf
        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RadioButton selectedRace = (RadioButton)sender;
            racialBonusTextBox.Text = "Increase Constitution by 2, Strength by 1, and Wisdom by 1";

            _strengthMod = _strengthMod + 1;
            _constitutionMod = _constitutionMod + 2;
            _wisdomMod = _wisdomMod + 1;

            this._selectedRace = selectedRace.Text;
        }

        //Radio Button for Tiefling (Half-Fiend, Half-Human)
        private void tieflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.M_Tiefling1;
            RadioButton selectedRace = (RadioButton)sender;
            racialBonusTextBox.Text = "Increase Charisma by 2, Dexterity and Intelligence by 1";

            _dexterityMod = _dexterityMod + 1;
            _intelligenceMod = _intelligenceMod + 1;
            _charismaMod = _charismaMod + 2;

            this._selectedRace = selectedRace.Text;
        }

        //Radio Button for Halfling
        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.M_Halfling2;
            RadioButton selectedRace = (RadioButton)sender;
            racialBonusTextBox.Text = "Increase Dexterity and Intelligence by 2, Strength is decreased by 1";

            _strengthMod = _strengthMod - 1;
            _dexterityMod = _dexterityMod + 2;
            _intelligenceMod = _intelligenceMod + 2;

            this._selectedRace = selectedRace.Text;
        }

        //Radio Button for Elf
        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton selectedRace = (RadioButton)sender;
            racialBonusTextBox.Text = "Increase Dexterity by 2, Charisma and Intelligence by 1";

            _dexterityMod = _dexterityMod + 2;
            _intelligenceMod = _intelligenceMod + 1;
            _charismaMod = _charismaMod + 1;

            this._selectedRace = selectedRace.Text;
        }
        /*
        //Radio Button for Aasimar (Half-Angel, Half-Human)
        private void aasimarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            characterPictureBox.Image = Properties.Resources.[aasimar picture name];
            RadioButton selectedRace = (RadioButton)sender;
            racialBonusTextBox.Text = "Increase Charisma by 2, Wisdom and Constitution by 1";

            _consitutionMod = _constitutionMod +1;
            _wisdomMod = _wisdomMod +1;
            _charismaMod = _charismaMod + 2;

            this._selectedRace = selectedRace.Text;
        }
        */

    }
}
