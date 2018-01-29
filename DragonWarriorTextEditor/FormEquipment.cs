using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2016, 2017, 2018+
 */
namespace DragonWarriorTextEditor {
    public partial class FormEquipment : Form {

        string path = "";

        public FormEquipment(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x6, textBoxE1.Text, 0x7AC7, 0); //Bamboo --- Start Weapons
                backend.updateROMText(0x4, textBoxE2.Text, 0x7ACE, 0); //Club
                backend.updateROMText(0x6, textBoxE3.Text, 0x7AD3, 0); //Copper
                backend.updateROMText(0x4, textBoxE4.Text, 0x7ADA, 0); //Hand
                backend.updateROMText(0x5, textBoxE5.Text, 0x7ADF, 0); //Broad
                backend.updateROMText(0x5, textBoxE6.Text, 0x7AE5, 0); //Flame
                backend.updateROMText(0x9, textBoxE7.Text, 0x7AEB, 0); //Erdrick's
                backend.updateROMText(0x4, textBoxE8.Text, 0x7BC7, 0); //Pole
                backend.updateROMText(0x5, textBoxE9.Text, 0x7BCD, 0); //Sword
                backend.updateROMText(0x3, textBoxE10.Text, 0x7BD3, 0); //Axe
                backend.updateROMText(0x6, textBoxE11.Text, 0x7BD7, 0); //Sword
                backend.updateROMText(0x6, textBoxE12.Text, 0x7BDD, 0); //Sword
                backend.updateROMText(0x6, textBoxE13.Text, 0x7BE3, 0); //Sword
                backend.updateROMText(0x7, textBoxE14.Text, 0x7AF5, 0); //Clothes --- Start Armor
                backend.updateROMText(0x7, textBoxE15.Text, 0x7AFD, 0); //Leather
                backend.updateROMText(0x5, textBoxE16.Text, 0x7B05, 0); //Chain
                backend.updateROMText(0x4, textBoxE17.Text, 0x7B0B, 0); //Half
                backend.updateROMText(0x4, textBoxE18.Text, 0x7B10, 0); //Full
                backend.updateROMText(0x5, textBoxE19.Text, 0x7B15, 0); //Magic
                backend.updateROMText(0x9, textBoxE20.Text, 0x7B1B, 0); //Erdrick's
                backend.updateROMText(0x5, textBoxE21.Text, 0x7BEA, 0); //Armor
                backend.updateROMText(0x4, textBoxE22.Text, 0x7BF0, 0); //Mail
                backend.updateROMText(0x5, textBoxE23.Text, 0x7BF5, 0); //Plate
                backend.updateROMText(0x5, textBoxE24.Text, 0x7BFB, 0); //Plate
                backend.updateROMText(0x5, textBoxE25.Text, 0x7C01, 0); //Armor
                backend.updateROMText(0x5, textBoxE26.Text, 0x7C07, 0); //Armor
                backend.updateROMText(0x5, textBoxE27.Text, 0x7B25, 0); //Small --- Shields
                backend.updateROMText(0x5, textBoxE28.Text, 0x7B2B, 0); //Large
                backend.updateROMText(0x6, textBoxE29.Text, 0x7B31, 0); //Silver
                backend.updateROMText(0x6, textBoxE30.Text, 0x7C0D, 0); //Shield
                backend.updateROMText(0x6, textBoxE31.Text, 0x7C14, 0); //Shield
                backend.updateROMText(0x6, textBoxE32.Text, 0x7C1B, 0); //Shield

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormEquipment_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxE1.Text = backend.getROMText(0x6, 0x7AC7, 0);
                textBoxE2.Text = backend.getROMText(0x4, 0x7ACE, 0);
                textBoxE3.Text = backend.getROMText(0x6, 0x7AD3, 0);
                textBoxE4.Text = backend.getROMText(0x4, 0x7ADA, 0);
                textBoxE5.Text = backend.getROMText(0x5, 0x7ADF, 0);
                textBoxE6.Text = backend.getROMText(0x5, 0x7AE5, 0);
                textBoxE7.Text = backend.getROMText(0x9, 0x7AEB, 0);
                textBoxE8.Text = backend.getROMText(0x4, 0x7BC7, 0);
                textBoxE9.Text = backend.getROMText(0x5, 0x7BCD, 0);
                textBoxE10.Text = backend.getROMText(0x3, 0x7BD3, 0);
                textBoxE11.Text = backend.getROMText(0x6, 0x7BD7, 0);
                textBoxE12.Text = backend.getROMText(0x6, 0x7BDD, 0);
                textBoxE13.Text = backend.getROMText(0x6, 0x7BE3, 0);
                textBoxE14.Text = backend.getROMText(0x7, 0x7AF5, 0);
                textBoxE15.Text = backend.getROMText(0x7, 0x7AFD, 0);
                textBoxE16.Text = backend.getROMText(0x5, 0x7B05, 0);
                textBoxE17.Text = backend.getROMText(0x4, 0x7B0B, 0);
                textBoxE18.Text = backend.getROMText(0x4, 0x7B10, 0);
                textBoxE19.Text = backend.getROMText(0x5, 0x7B15, 0);
                textBoxE20.Text = backend.getROMText(0x9, 0x7B1B, 0);
                textBoxE21.Text = backend.getROMText(0x5, 0x7BEA, 0);
                textBoxE22.Text = backend.getROMText(0x4, 0x7BF0, 0);
                textBoxE23.Text = backend.getROMText(0x5, 0x7BF5, 0);
                textBoxE24.Text = backend.getROMText(0x5, 0x7BFB, 0);
                textBoxE25.Text = backend.getROMText(0x5, 0x7C01, 0);
                textBoxE26.Text = backend.getROMText(0x5, 0x7C07, 0);
                textBoxE27.Text = backend.getROMText(0x5, 0x7B25, 0);
                textBoxE28.Text = backend.getROMText(0x5, 0x7B2B, 0);
                textBoxE29.Text = backend.getROMText(0x6, 0x7B31, 0);
                textBoxE30.Text = backend.getROMText(0x6, 0x7C0D, 0);
                textBoxE31.Text = backend.getROMText(0x6, 0x7C14, 0);
                textBoxE32.Text = backend.getROMText(0x6, 0x7C1B, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxE1.MaxLength  = 0x6;
            textBoxE2.MaxLength  = 0x4;
            textBoxE3.MaxLength  = 0x6;
            textBoxE4.MaxLength  = 0x4;
            textBoxE5.MaxLength  = 0x5;
            textBoxE6.MaxLength  = 0x5;
            textBoxE7.MaxLength  = 0x9;
            textBoxE8.MaxLength  = 0x4;
            textBoxE9.MaxLength  = 0x5;
            textBoxE10.MaxLength = 0x3;
            textBoxE11.MaxLength = 0x6;
            textBoxE12.MaxLength = 0x6;
            textBoxE13.MaxLength = 0x6;
            textBoxE14.MaxLength = 0x7;
            textBoxE15.MaxLength = 0x7;
            textBoxE16.MaxLength = 0x5;
            textBoxE17.MaxLength = 0x4;
            textBoxE18.MaxLength = 0x4;
            textBoxE19.MaxLength = 0x5;
            textBoxE20.MaxLength = 0x9;
            textBoxE21.MaxLength = 0x5;
            textBoxE22.MaxLength = 0x4;
            textBoxE23.MaxLength = 0x5;
            textBoxE24.MaxLength = 0x5;
            textBoxE25.MaxLength = 0x5;
            textBoxE26.MaxLength = 0x5;
            textBoxE27.MaxLength = 0x5;
            textBoxE28.MaxLength = 0x5;
            textBoxE29.MaxLength = 0x6;
            textBoxE30.MaxLength = 0x6;
            textBoxE31.MaxLength = 0x6;
            textBoxE32.MaxLength = 0x6;
        }
    }
}
