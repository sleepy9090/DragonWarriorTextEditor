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
    public partial class FormMonsters : Form {

        string path = "";

        public FormMonsters(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x5, textBoxC1.Text, 0x7C80, 0); //Slime
                backend.updateROMText(0x3, textBoxC2.Text, 0x7C86, 0); //Red
                backend.updateROMText(0x6, textBoxC3.Text, 0x7C8A, 0); //Drakee
                backend.updateROMText(0x5, textBoxC4.Text, 0x7C91, 0); //Ghost
                backend.updateROMText(0x8, textBoxC5.Text, 0x7C97, 0); //Magician
                backend.updateROMText(0xA, textBoxC6.Text, 0x7CA0, 0); //Magidrakee
                backend.updateROMText(0x8, textBoxC7.Text, 0x7CAB, 0); //Scorpion
                backend.updateROMText(0x5, textBoxC8.Text, 0x7CB4, 0); //Druin
                backend.updateROMText(0xB, textBoxC9.Text, 0x7CBA, 0); //Poltergeist
                backend.updateROMText(0x5, textBoxC10.Text, 0x7CC6, 0); //Droll
                backend.updateROMText(0x8, textBoxC11.Text, 0x7CCC, 0); //Drakeema
                backend.updateROMText(0x8, textBoxC12.Text, 0x7CD5, 0); //Skeleton
                backend.updateROMText(0x7, textBoxC13.Text, 0x7CDE, 0); //Warlock
                backend.updateROMText(0x5, textBoxC14.Text, 0x7CE6, 0); //Metal
                backend.updateROMText(0x4, textBoxC15.Text, 0x7CEC, 0); //Wolf
                backend.updateROMText(0x6, textBoxC16.Text, 0x7CF1, 0); //Wraith
                backend.updateROMText(0x5, textBoxC17.Text, 0x7CF8, 0); //Metal
                backend.updateROMText(0x7, textBoxC18.Text, 0x7CFE, 0); //Specter
                backend.updateROMText(0x8, textBoxC19.Text, 0x7D06, 0); //Wolflord
                backend.updateROMText(0x9, textBoxC20.Text, 0x7D0F, 0); //Druinlord
                backend.updateROMText(0x9, textBoxC21.Text, 0x7D19, 0); //Drollmagi
                backend.updateROMText(0x6, textBoxC22.Text, 0x7D23, 0); //Wyvern
                backend.updateROMText(0x5, textBoxC23.Text, 0x7D2A, 0); //Rogue
                backend.updateROMText(0x6, textBoxC24.Text, 0x7D30, 0); //Wraith
                backend.updateROMText(0x5, textBoxC25.Text, 0x7D37, 0); //Golem
                backend.updateROMText(0x7, textBoxC26.Text, 0x7D3D, 0); //Goldman
                backend.updateROMText(0x6, textBoxC27.Text, 0x7D45, 0); //Knight
                backend.updateROMText(0xA, textBoxC28.Text, 0x7D4C, 0); //Magiwyvern
                backend.updateROMText(0x5, textBoxC29.Text, 0x7D57, 0); //Demon
                backend.updateROMText(0x8, textBoxC30.Text, 0x7D5D, 0); //Werewolf
                backend.updateROMText(0x5, textBoxC31.Text, 0x7D66, 0); //Green
                backend.updateROMText(0xA, textBoxC32.Text, 0x7D6C, 0); //Starwyvern
                backend.updateROMText(0x6, textBoxC33.Text, 0x7D77, 0); //Wizard
                backend.updateROMText(0x3, textBoxC34.Text, 0x7D7E, 0); //Axe
                backend.updateROMText(0x4, textBoxC35.Text, 0x7D82, 0); //Blue
                backend.updateROMText(0x8, textBoxC36.Text, 0x7D87, 0); //Stoneman
                backend.updateROMText(0x6, textBoxC37.Text, 0x7D90, 0); //Armored
                backend.updateROMText(0x3, textBoxC38.Text, 0x7D98, 0); //Red
                backend.updateROMText(0xA, textBoxC39.Text, 0x7D9C, 0); //Dragonlord
                backend.updateROMText(0xA, textBoxC40.Text, 0x7DA7, 0); //Dragonlord
                backend.updateROMText(0x5, textBoxC41.Text, 0x7DB3, 0); //Slime
                backend.updateROMText(0x8, textBoxC42.Text, 0x7DC4, 0); //Scorpion
                backend.updateROMText(0x5, textBoxC43.Text, 0x7DCF, 0); //Slime
                backend.updateROMText(0x8, textBoxC44.Text, 0x7DDA, 0); //Scorpion
                backend.updateROMText(0x6, textBoxC45.Text, 0x7DE3, 0); //Knight
                backend.updateROMText(0x6, textBoxC46.Text, 0x7DEE, 0); //Knight
                backend.updateROMText(0x6, textBoxC47.Text, 0x7DF6, 0); //Dragon
                backend.updateROMText(0x6, textBoxC48.Text, 0x7DFF, 0); //Knight
                backend.updateROMText(0x6, textBoxC49.Text, 0x7E06, 0); //Dragon
                backend.updateROMText(0x6, textBoxC50.Text, 0x7E0E, 0); //Knight
                backend.updateROMText(0x6, textBoxC51.Text, 0x7E15, 0); //Dragon

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMonsters_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxC1.Text = backend.getROMText(0x5, 0x7C80, 0);
                textBoxC2.Text = backend.getROMText(0x3, 0x7C86, 0);
                textBoxC3.Text = backend.getROMText(0x6, 0x7C8A, 0);
                textBoxC4.Text = backend.getROMText(0x5, 0x7C91, 0);
                textBoxC5.Text = backend.getROMText(0x8, 0x7C97, 0);
                textBoxC6.Text = backend.getROMText(0xA, 0x7CA0, 0);
                textBoxC7.Text = backend.getROMText(0x8, 0x7CAB, 0);
                textBoxC8.Text = backend.getROMText(0x5, 0x7CB4, 0);
                textBoxC9.Text = backend.getROMText(0xB, 0x7CBA, 0);
                textBoxC10.Text = backend.getROMText(0x5, 0x7CC6, 0);
                textBoxC11.Text = backend.getROMText(0x8, 0x7CCC, 0);
                textBoxC12.Text = backend.getROMText(0x8, 0x7CD5, 0);
                textBoxC13.Text = backend.getROMText(0x7, 0x7CDE, 0);
                textBoxC14.Text = backend.getROMText(0x5, 0x7CE6, 0);
                textBoxC15.Text = backend.getROMText(0x4, 0x7CEC, 0);
                textBoxC16.Text = backend.getROMText(0x6, 0x7CF1, 0);
                textBoxC17.Text = backend.getROMText(0x5, 0x7CF8, 0);
                textBoxC18.Text = backend.getROMText(0x7, 0x7CFE, 0);
                textBoxC19.Text = backend.getROMText(0x8, 0x7D06, 0);
                textBoxC20.Text = backend.getROMText(0x9, 0x7D0F, 0);
                textBoxC21.Text = backend.getROMText(0x9, 0x7D19, 0);
                textBoxC22.Text = backend.getROMText(0x6, 0x7D23, 0);
                textBoxC23.Text = backend.getROMText(0x5, 0x7D2A, 0);
                textBoxC24.Text = backend.getROMText(0x6, 0x7D30, 0);
                textBoxC25.Text = backend.getROMText(0x5, 0x7D37, 0);
                textBoxC26.Text = backend.getROMText(0x7, 0x7D3D, 0);
                textBoxC27.Text = backend.getROMText(0x6, 0x7D45, 0);
                textBoxC28.Text = backend.getROMText(0xA, 0x7D4C, 0);
                textBoxC29.Text = backend.getROMText(0x5, 0x7D57, 0);
                textBoxC30.Text = backend.getROMText(0x8, 0x7D5D, 0);
                textBoxC31.Text = backend.getROMText(0x5, 0x7D66, 0);
                textBoxC32.Text = backend.getROMText(0xA, 0x7D6C, 0);
                textBoxC33.Text = backend.getROMText(0x6, 0x7D77, 0);
                textBoxC34.Text = backend.getROMText(0x3, 0x7D7E, 0);
                textBoxC35.Text = backend.getROMText(0x4, 0x7D82, 0);
                textBoxC36.Text = backend.getROMText(0x8, 0x7D87, 0);
                textBoxC37.Text = backend.getROMText(0x6, 0x7D90, 0);
                textBoxC38.Text = backend.getROMText(0x3, 0x7D98, 0);
                textBoxC39.Text = backend.getROMText(0xA, 0x7D9C, 0);
                textBoxC40.Text = backend.getROMText(0xA, 0x7DA7, 0);
                textBoxC41.Text = backend.getROMText(0x5, 0x7DB3, 0);
                textBoxC42.Text = backend.getROMText(0x8, 0x7DC4, 0);
                textBoxC43.Text = backend.getROMText(0x5, 0x7DCF, 0);
                textBoxC44.Text = backend.getROMText(0x8, 0x7DDA, 0);
                textBoxC45.Text = backend.getROMText(0x6, 0x7DE3, 0);
                textBoxC46.Text = backend.getROMText(0x6, 0x7DEE, 0);
                textBoxC47.Text = backend.getROMText(0x6, 0x7DF6, 0);
                textBoxC48.Text = backend.getROMText(0x6, 0x7DFF, 0);
                textBoxC49.Text = backend.getROMText(0x6, 0x7E06, 0);
                textBoxC50.Text = backend.getROMText(0x6, 0x7E0E, 0);
                textBoxC51.Text = backend.getROMText(0x6, 0x7E15, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxC1.MaxLength =  0x5;
            textBoxC2.MaxLength =  0x3;
            textBoxC3.MaxLength =  0x6;
            textBoxC4.MaxLength =  0x5;
            textBoxC5.MaxLength =  0x8;
            textBoxC6.MaxLength =  0xA;
            textBoxC7.MaxLength =  0x8;
            textBoxC8.MaxLength =  0x5;
            textBoxC9.MaxLength =  0xB;
            textBoxC10.MaxLength = 0x5;
            textBoxC11.MaxLength = 0x8;
            textBoxC12.MaxLength = 0x8;
            textBoxC13.MaxLength = 0x7;
            textBoxC14.MaxLength = 0x5;
            textBoxC15.MaxLength = 0x4;
            textBoxC16.MaxLength = 0x6;
            textBoxC17.MaxLength = 0x5;
            textBoxC18.MaxLength = 0x7;
            textBoxC19.MaxLength = 0x8;
            textBoxC20.MaxLength = 0x9;
            textBoxC21.MaxLength = 0x9;
            textBoxC22.MaxLength = 0x6;
            textBoxC23.MaxLength = 0x5;
            textBoxC24.MaxLength = 0x6;
            textBoxC25.MaxLength = 0x5;
            textBoxC26.MaxLength = 0x7;
            textBoxC27.MaxLength = 0x6;
            textBoxC28.MaxLength = 0xA;
            textBoxC29.MaxLength = 0x5;
            textBoxC30.MaxLength = 0x8;
            textBoxC31.MaxLength = 0x5;
            textBoxC32.MaxLength = 0xA;
            textBoxC33.MaxLength = 0x6;
            textBoxC34.MaxLength = 0x3;
            textBoxC35.MaxLength = 0x4;
            textBoxC36.MaxLength = 0x8;
            textBoxC37.MaxLength = 0x6;
            textBoxC38.MaxLength = 0x3;
            textBoxC39.MaxLength = 0xA;
            textBoxC40.MaxLength = 0xA;
            textBoxC41.MaxLength = 0x5;
            textBoxC42.MaxLength = 0x8;
            textBoxC43.MaxLength = 0x5;
            textBoxC44.MaxLength = 0x8;
            textBoxC45.MaxLength = 0x6;
            textBoxC46.MaxLength = 0x6;
            textBoxC47.MaxLength = 0x6;
            textBoxC48.MaxLength = 0x6;
            textBoxC49.MaxLength = 0x6;
            textBoxC50.MaxLength = 0x6;
            textBoxC51.MaxLength = 0x6;
        }
    }
}
