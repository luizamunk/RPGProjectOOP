using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RpgProject.CharacterClasses;

namespace RpgProject
{
    public partial class FormCharacterCreator : Form
    {
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void FormCharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            //Create a mage object
            Mage magePlayer = new Mage();
            MessageBox.Show("You have a new Mage with strencth of " + magePlayer.Strenght.ToString());

            //string output = string.Empty;
            //output += $"Name {txtCharacterName.Text}\n";
            //output += $"Gender {comboCharacterGender.Text}\n";
            //output += $"Gender {comboCharacterClasses.Text}\n";
            //MessageBox.Show(output);


        }

        private void comboCharacterClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
