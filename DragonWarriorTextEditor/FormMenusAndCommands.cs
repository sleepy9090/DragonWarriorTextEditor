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
    public partial class FormMenusAndCommands : Form {

        string path = "";

        public FormMenusAndCommands(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x7, textBoxDL1.Text, 0x706B, 0); //COMMAND
                backend.updateROMText(0x4, textBoxDL2.Text, 0x7074, 0); //TALK
                backend.updateROMText(0x5, textBoxDL3.Text, 0x7079, 0); //SPELL
                backend.updateROMText(0x6, textBoxDL4.Text, 0x707F, 0); //STATUS
                backend.updateROMText(0x4, textBoxDL5.Text, 0x7086, 0); //ITEM
                backend.updateROMText(0x6, textBoxDL6.Text, 0x708C, 0); //STAIRS
                backend.updateROMText(0x4, textBoxDL7.Text, 0x7093, 0); //DOOR
                backend.updateROMText(0x6, textBoxDL8.Text, 0x7099, 0); //SEARCH
                backend.updateROMText(0x4, textBoxDL9.Text, 0x70A0, 0); //TAKE
                backend.updateROMText(0x4, textBoxDL10.Text, 0x6FDD, 0); //NAME
                backend.updateROMText(0x8, textBoxDL11.Text, 0x6FE5, 0); //STRENGTH
                backend.updateROMText(0x7, textBoxDL12.Text, 0x6FF1, 0); //AGILITY
                backend.updateROMText(0x7, textBoxDL13.Text, 0x6FFC, 0); //MAXIMUM
                backend.updateROMText(0x2, textBoxDL14.Text, 0x7004, 0); //HP
                backend.updateROMText(0x7, textBoxDL15.Text, 0x700A, 0); //MAXIMUM
                backend.updateROMText(0x2, textBoxDL16.Text, 0x7012, 0); //MP
                backend.updateROMText(0x6, textBoxDL17.Text, 0x7018, 0); //ATTACK
                backend.updateROMText(0x5, textBoxDL18.Text, 0x701F, 0); //POWER
                backend.updateROMText(0x7, textBoxDL19.Text, 0x7028, 0); //DEFENSE
                backend.updateROMText(0x5, textBoxDL20.Text, 0x7030, 0); //POWER
                backend.updateROMText(0x6, textBoxDL21.Text, 0x7039, 0); //WEAPON
                backend.updateROMText(0x5, textBoxDL22.Text, 0x7045, 0); //ARMOR
                backend.updateROMText(0x6, textBoxDL23.Text, 0x7050, 0); //SHIELD
                backend.updateROMText(0x7, textBoxDL24.Text, 0x70AC, 0); //COMMAND
                backend.updateROMText(0x5, textBoxDL25.Text, 0x70B5, 0); //FIGHT
                backend.updateROMText(0x5, textBoxDL26.Text, 0x70BB, 0); //SPELL
                backend.updateROMText(0x3, textBoxDL27.Text, 0x70C1, 0); //RUN
                backend.updateROMText(0x4, textBoxDL28.Text, 0x70C5, 0); //ITEM
                backend.updateROMText(0x3, textBoxDL29.Text, 0x7103, 0); //YES
                backend.updateROMText(0x2, textBoxDL30.Text, 0x7108, 0); //NO
                backend.updateROMText(0x3, textBoxDL31.Text, 0x7113, 0); //BUY
                backend.updateROMText(0x4, textBoxDL32.Text, 0x7118, 0); //SELL
                backend.updateROMText(0x5, textBoxDL33.Text, 0x70D1, 0); //SPELL

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMenusAndCommands_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxDL1.Text = backend.getROMText(0x7, 0x706B, 0);
                textBoxDL2.Text = backend.getROMText(0x4, 0x7074, 0);
                textBoxDL3.Text = backend.getROMText(0x5, 0x7079, 0);
                textBoxDL4.Text = backend.getROMText(0x6, 0x707F, 0);
                textBoxDL5.Text = backend.getROMText(0x4, 0x7086, 0);
                textBoxDL6.Text = backend.getROMText(0x6, 0x708C, 0);
                textBoxDL7.Text = backend.getROMText(0x4, 0x7093, 0);
                textBoxDL8.Text = backend.getROMText(0x6, 0x7099, 0);
                textBoxDL9.Text = backend.getROMText(0x4, 0x70A0, 0);
                textBoxDL10.Text = backend.getROMText(0x4, 0x6FDD, 0);
                textBoxDL11.Text = backend.getROMText(0x8, 0x6FE5, 0);
                textBoxDL12.Text = backend.getROMText(0x7, 0x6FF1, 0);
                textBoxDL13.Text = backend.getROMText(0x7, 0x6FFC, 0);
                textBoxDL14.Text = backend.getROMText(0x2, 0x7004, 0);
                textBoxDL15.Text = backend.getROMText(0x7, 0x700A, 0);
                textBoxDL16.Text = backend.getROMText(0x2, 0x7012, 0);
                textBoxDL17.Text = backend.getROMText(0x6, 0x7018, 0);
                textBoxDL18.Text = backend.getROMText(0x5, 0x701F, 0);
                textBoxDL19.Text = backend.getROMText(0x7, 0x7028, 0);
                textBoxDL20.Text = backend.getROMText(0x5, 0x7030, 0);
                textBoxDL21.Text = backend.getROMText(0x6, 0x7039, 0);
                textBoxDL22.Text = backend.getROMText(0x5, 0x7045, 0);
                textBoxDL23.Text = backend.getROMText(0x6, 0x7050, 0);
                textBoxDL24.Text = backend.getROMText(0x7, 0x70AC, 0);
                textBoxDL25.Text = backend.getROMText(0x5, 0x70B5, 0);
                textBoxDL26.Text = backend.getROMText(0x5, 0x70BB, 0);
                textBoxDL27.Text = backend.getROMText(0x3, 0x70C1, 0);
                textBoxDL28.Text = backend.getROMText(0x4, 0x70C5, 0);
                textBoxDL29.Text = backend.getROMText(0x3, 0x7103, 0);
                textBoxDL30.Text = backend.getROMText(0x2, 0x7108, 0);
                textBoxDL31.Text = backend.getROMText(0x3, 0x7113, 0);
                textBoxDL32.Text = backend.getROMText(0x4, 0x7118, 0);
                textBoxDL33.Text = backend.getROMText(0x5, 0x70D1, 0);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxDL1.MaxLength =  0x7;
            textBoxDL2.MaxLength =  0x4;
            textBoxDL3.MaxLength =  0x5;
            textBoxDL4.MaxLength =  0x6;
            textBoxDL5.MaxLength =  0x4;
            textBoxDL6.MaxLength =  0x6;
            textBoxDL7.MaxLength =  0x4;
            textBoxDL8.MaxLength =  0x6;
            textBoxDL9.MaxLength =  0x4;
            textBoxDL10.MaxLength = 0x4;
            textBoxDL11.MaxLength = 0x8;
            textBoxDL12.MaxLength = 0x7;
            textBoxDL13.MaxLength = 0x7;
            textBoxDL14.MaxLength = 0x2;
            textBoxDL15.MaxLength = 0x7;
            textBoxDL16.MaxLength = 0x2;
            textBoxDL17.MaxLength = 0x6;
            textBoxDL18.MaxLength = 0x5;
            textBoxDL19.MaxLength = 0x7;
            textBoxDL20.MaxLength = 0x5;
            textBoxDL21.MaxLength = 0x6;
            textBoxDL22.MaxLength = 0x5;
            textBoxDL23.MaxLength = 0x6;
            textBoxDL24.MaxLength = 0x7;
            textBoxDL25.MaxLength = 0x5;
            textBoxDL26.MaxLength = 0x5;
            textBoxDL27.MaxLength = 0x3;
            textBoxDL28.MaxLength = 0x4;
            textBoxDL29.MaxLength = 0x3;
            textBoxDL30.MaxLength = 0x2;
            textBoxDL31.MaxLength = 0x3;
            textBoxDL32.MaxLength = 0x4;
            textBoxDL33.MaxLength = 0x5;
        }
    }
}
