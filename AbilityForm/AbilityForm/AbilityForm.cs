using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbilityForm
{
    /// <summary>
    /// Program: RAD Midterm - D&D Character Creation
    /// Name: Drew Bywater
    /// Student ID: 200261234
    /// Date: Feb 2017
    /// App Description:
    /// Creates a basic character legal with Pathfinder, D20, and D&D versions 3.0 through to 5e
    /// These editions all use either 1d20 for ability scores or 3d6, with 20 being the absolute maximum
    /// </summary>
    public partial class AbilityForm : Form
    {
        //Random number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method "rolls" the 3d6 - three, six-sided die
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        
        private int _roll3d6()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 7);
            }
            return result;
        } 

        //Rolls 3d6 and inputs the string value into associated text box
        private void _rollAbilities()
        {
            strengthTextBox.Text = this._roll3d6().ToString();
            dexterityTextBox.Text = this._roll3d6().ToString();
            constitutionTextBox.Text = this._roll3d6().ToString();
            intelligenceTextBox.Text = this._roll3d6().ToString();
            wisdomTextBox.Text = this._roll3d6().ToString();
            charismaTextBox.Text = this._roll3d6().ToString();

        }

        

        private void rollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(_roll3d6().ToString());
            _rollAbilities();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            try
            {
                character.Strength = strengthTextBox.Text;
                character.Dexterity = dexterityTextBox.Text;
                character.Constitution = constitutionTextBox.Text;
                character.Intelligence = intelligenceTextBox.Text;
                character.Wisdom = wisdomTextBox.Text;
                character.Charisma = charismaTextBox.Text;

                if(strengthTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (strengthTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (dexterityTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (constitutionTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (wisdomTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (charismaTextBox.Text == "")
                {
                    throw new Exception();
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Please fill in a valid response or press the Roll button");
                return;
            }

            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }
    }
}
