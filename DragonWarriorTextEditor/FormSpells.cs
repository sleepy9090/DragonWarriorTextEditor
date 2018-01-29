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
    public partial class FormSpells : Form {

        string path = "";

        public FormSpells(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x4, textBoxPG1.Text, 0x7E66, 0); //HEAL
                backend.updateROMText(0x4, textBoxPG2.Text, 0x7E6B, 0); //HURT
                backend.updateROMText(0x5, textBoxPG3.Text, 0x7E70, 0); //SLEEP
                backend.updateROMText(0x7, textBoxPG4.Text, 0x7E76, 0); //RADIANT
                backend.updateROMText(0x9, textBoxPG5.Text, 0x7E7E, 0); //STOPSPELL
                backend.updateROMText(0x7, textBoxPG6.Text, 0x7E88, 0); //OUTSIDE
                backend.updateROMText(0x6, textBoxPG7.Text, 0x7E90, 0); //RETURN
                backend.updateROMText(0x5, textBoxPG8.Text, 0x7E97, 0); //REPEL
                backend.updateROMText(0x8, textBoxPG9.Text, 0x7E9D, 0); //HEALMORE
                backend.updateROMText(0x8, textBoxPG10.Text, 0x7EA6, 0); //HURTMORE

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSpells_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxPG1.Text = backend.getROMText(0x4, 0x7E66, 0);
                textBoxPG2.Text = backend.getROMText(0x4, 0x7E6B, 0);
                textBoxPG3.Text = backend.getROMText(0x5, 0x7E70, 0);
                textBoxPG4.Text = backend.getROMText(0x7, 0x7E76, 0);
                textBoxPG5.Text = backend.getROMText(0x9, 0x7E7E, 0);
                textBoxPG6.Text = backend.getROMText(0x7, 0x7E88, 0);
                textBoxPG7.Text = backend.getROMText(0x6, 0x7E90, 0);
                textBoxPG8.Text = backend.getROMText(0x5, 0x7E97, 0);
                textBoxPG9.Text = backend.getROMText(0x8, 0x7E9D, 0);
                textBoxPG10.Text = backend.getROMText(0x8, 0x7EA6, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxPG1.MaxLength  = 0x4;
            textBoxPG2.MaxLength  = 0x4;
            textBoxPG3.MaxLength  = 0x5;
            textBoxPG4.MaxLength  = 0x7;
            textBoxPG5.MaxLength  = 0x9;
            textBoxPG6.MaxLength  = 0x7;
            textBoxPG7.MaxLength  = 0x6;
            textBoxPG8.MaxLength  = 0x5;
            textBoxPG9.MaxLength  = 0x8;
            textBoxPG10.MaxLength = 0x8;
        }
    }
}
