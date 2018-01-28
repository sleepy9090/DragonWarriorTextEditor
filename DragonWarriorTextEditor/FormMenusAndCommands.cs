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

                backend.updateROMText(0x7, textBoxDL1.Text, 0x706B, 1); //COMMAND
                backend.updateROMText(0x4, textBoxDL2.Text, 0x7074, 1); //TALK
                backend.updateROMText(0x5, textBoxDL3.Text, 0x7079, 1); //SPELL
                backend.updateROMText(0x6, textBoxDL4.Text, 0x707F, 1); //STATUS
                backend.updateROMText(0x4, textBoxDL5.Text, 0x7086, 1); //ITEM
                backend.updateROMText(0x6, textBoxDL6.Text, 0x708C, 1); //STAIRS
                backend.updateROMText(0x4, textBoxDL7.Text, 0x7093, 1); //DOOR
                backend.updateROMText(0x6, textBoxDL8.Text, 0x7099, 1); //SEARCH
                backend.updateROMText(0x4, textBoxDL9.Text, 0x70A0, 1); //TAKE
                backend.updateROMText(0x4, textBoxDL10.Text, 0x6FDD, 1); //NAME
                backend.updateROMText(0x8, textBoxDL11.Text, 0x6FE5, 1); //STRENGTH
                backend.updateROMText(0x7, textBoxDL12.Text, 0x6FF1, 1); //AGILITY
                backend.updateROMText(0x7, textBoxDL13.Text, 0x6FFC, 1); //MAXIMUM
                backend.updateROMText(0x2, textBoxDL14.Text, 0x7004, 1); //HP
                backend.updateROMText(0x7, textBoxDL15.Text, 0x700A, 1); //MAXIMUM
                backend.updateROMText(0x2, textBoxDL16.Text, 0x7012, 1); //MP
                backend.updateROMText(0x6, textBoxDL17.Text, 0x7018, 1); //ATTACK
                backend.updateROMText(0x5, textBoxDL18.Text, 0x701F, 1); //POWER
                backend.updateROMText(0x7, textBoxDL19.Text, 0x7028, 1); //DEFENSE
                backend.updateROMText(0x5, textBoxDL20.Text, 0x7030, 1); //POWER
                backend.updateROMText(0x6, textBoxDL21.Text, 0x7039, 1); //WEAPON
                backend.updateROMText(0x5, textBoxDL22.Text, 0x7045, 1); //ARMOR
                backend.updateROMText(0x6, textBoxDL23.Text, 0x7050, 1); //SHIELD
                backend.updateROMText(0x7, textBoxDL24.Text, 0x70AC, 1); //COMMAND
                backend.updateROMText(0x5, textBoxDL25.Text, 0x70B5, 1); //FIGHT
                backend.updateROMText(0x5, textBoxDL26.Text, 0x70BB, 1); //SPELL
                backend.updateROMText(0x3, textBoxDL27.Text, 0x70C1, 1); //RUN
                backend.updateROMText(0x4, textBoxDL28.Text, 0x70C5, 1); //ITEM
                backend.updateROMText(0x3, textBoxDL29.Text, 0x7103, 1); //YES
                backend.updateROMText(0x2, textBoxDL30.Text, 0x7108, 1); //NO
                backend.updateROMText(0x3, textBoxDL31.Text, 0x7113, 1); //BUY
                backend.updateROMText(0x4, textBoxDL32.Text, 0x7118, 1); //SELL
                backend.updateROMText(0x5, textBoxDL33.Text, 0x70D1, 1); //SPELL

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

                textBoxDL1.Text = backend.getROMText(0x7, 0x706B, 1);
                textBoxDL2.Text = backend.getROMText(0x4, 0x7074, 1);
                textBoxDL3.Text = backend.getROMText(0x5, 0x7079, 1);
                textBoxDL4.Text = backend.getROMText(0x6, 0x707F, 1);
                textBoxDL5.Text = backend.getROMText(0x4, 0x7086, 1);
                textBoxDL6.Text = backend.getROMText(0x6, 0x708C, 1);
                textBoxDL7.Text = backend.getROMText(0x4, 0x7093, 1);
                textBoxDL8.Text = backend.getROMText(0x6, 0x7099, 1);
                textBoxDL9.Text = backend.getROMText(0x4, 0x70A0, 1);
                textBoxDL10.Text = backend.getROMText(0x4, 0x6FDD, 1);
                textBoxDL11.Text = backend.getROMText(0x8, 0x6FE5, 1);
                textBoxDL12.Text = backend.getROMText(0x7, 0x6FF1, 1);
                textBoxDL13.Text = backend.getROMText(0x7, 0x6FFC, 1);
                textBoxDL14.Text = backend.getROMText(0x2, 0x7004, 1);
                textBoxDL15.Text = backend.getROMText(0x7, 0x700A, 1);
                textBoxDL16.Text = backend.getROMText(0x2, 0x7012, 1);
                textBoxDL17.Text = backend.getROMText(0x6, 0x7018, 1);
                textBoxDL18.Text = backend.getROMText(0x5, 0x701F, 1);
                textBoxDL19.Text = backend.getROMText(0x7, 0x7028, 1);
                textBoxDL20.Text = backend.getROMText(0x5, 0x7030, 1);
                textBoxDL21.Text = backend.getROMText(0x6, 0x7039, 1);
                textBoxDL22.Text = backend.getROMText(0x5, 0x7045, 1);
                textBoxDL23.Text = backend.getROMText(0x6, 0x7050, 1);
                textBoxDL24.Text = backend.getROMText(0x7, 0x70AC, 1);
                textBoxDL25.Text = backend.getROMText(0x5, 0x70B5, 1);
                textBoxDL26.Text = backend.getROMText(0x5, 0x70BB, 1);
                textBoxDL27.Text = backend.getROMText(0x3, 0x70C1, 1);
                textBoxDL28.Text = backend.getROMText(0x4, 0x70C5, 1);
                textBoxDL29.Text = backend.getROMText(0x3, 0x7103, 1);
                textBoxDL30.Text = backend.getROMText(0x2, 0x7108, 1);
                textBoxDL31.Text = backend.getROMText(0x3, 0x7113, 1);
                textBoxDL32.Text = backend.getROMText(0x4, 0x7118, 1);
                textBoxDL33.Text = backend.getROMText(0x5, 0x70D1, 1);
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
