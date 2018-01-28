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
    public partial class FormTitleScreens : Form {

        string path = "";

        public FormTitleScreens(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x11, textBoxRL1.Text, 0x72C0, 2); //BEGIN A NEW QUEST
                backend.updateROMText(0xF, textBoxRL2.Text, 0x72DA, 2); //ADVENTURE LOG 1
                backend.updateROMText(0xF, textBoxRL3.Text, 0x72F2, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL4.Text, 0x730A, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL5.Text, 0x731B, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL6.Text, 0x7333, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL7.Text, 0x734B, 2); //ADVENTURE LOG 
                backend.updateROMText(0xF, textBoxRL8.Text, 0x735C, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL9.Text, 0x7374, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL10.Text, 0x7385, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL11.Text, 0x739D, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL12.Text, 0x73AE, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL13.Text, 0x73BF, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL14.Text, 0x73D7, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL15.Text, 0x73F1, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL16.Text, 0x740B, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL17.Text, 0x741E, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL18.Text, 0x7438, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL19.Text, 0x7452, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL20.Text, 0x7465, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL21.Text, 0x747F, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL22.Text, 0x7492, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL23.Text, 0x74AC, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL24.Text, 0x74BF, 2); //ADVENTURE LOG
                backend.updateROMText(0xF, textBoxRL25.Text, 0x74D2, 2); //ADVENTURE LOG
                backend.updateROMText(0x10, textBoxRL26.Text, 0x7223, 2); //CONTINUE A QUEST
                backend.updateROMText(0x10, textBoxRL27.Text, 0x7261, 2); //CONTINUE A QUEST
                backend.updateROMText(0x14, textBoxRL28.Text, 0x7235, 2); //CHANGE MESSAGE SPEED
                backend.updateROMText(0x14, textBoxRL29.Text, 0x7273, 2); //CHANGE MESSAGE SPEED
                backend.updateROMText(0x11, textBoxRL30.Text, 0x7289, 2); //BEGIN A NEW QUEST
                backend.updateROMText(0xC, textBoxRL31.Text, 0x729C, 2); //COPY A QUEST
                backend.updateROMText(0xD, textBoxRL32.Text, 0x724B, 2); //ERASE A QUEST
                backend.updateROMText(0xD, textBoxRL33.Text, 0x72AA, 2); //ERASE A QUEST
                backend.updateROMText(0x4, textBoxRL34.Text, 0x719C, 2); //BACK
                backend.updateROMText(0x3, textBoxRL35.Text, 0x71A1, 2); //END
                backend.updateROMText(0xD, textBoxRL36.Text, 0x71AC, 2); //Which Message
                backend.updateROMText(0xC, textBoxRL37.Text, 0x71BC, 2); //Speed Do You
                backend.updateROMText(0xC, textBoxRL38.Text, 0x71CB, 2); //Want To Use?
                backend.updateROMText(0x4, textBoxRL39.Text, 0x71DB, 2); //FAST
                backend.updateROMText(0x6, textBoxRL40.Text, 0x71E2, 2); //NORMAL
                backend.updateROMText(0x4, textBoxRL41.Text, 0x71EB, 2); //SLOW
                backend.updateROMText(0x5, textBoxRL42.Text, 0x74ED, 2); //LEVEL
                backend.updateROMText(0xE, textBoxRL43.Text, 0x74F6, 2); //Do You Want To
                backend.updateROMText(0xA, textBoxRL44.Text, 0x7506, 2); //Erase This
                backend.updateROMText(0xA, textBoxRL45.Text, 0x7512, 2); //Character?
                backend.updateROMText(0x3, textBoxRL46.Text, 0x7525, 2); //YES
                backend.updateROMText(0x2, textBoxRL47.Text, 0x752A, 2); //NO

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTitleScreens_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxRL1.Text = backend.getROMText(0x11, 0x72C0, 2);
                textBoxRL2.Text = backend.getROMText(0xF, 0x72DA, 2);
                textBoxRL3.Text = backend.getROMText(0xF, 0x72F2, 2);
                textBoxRL4.Text = backend.getROMText(0xF, 0x730A, 2);
                textBoxRL5.Text = backend.getROMText(0xF, 0x731B, 2);
                textBoxRL6.Text = backend.getROMText(0xF, 0x7333, 2);
                textBoxRL7.Text = backend.getROMText(0xF, 0x734B, 2);
                textBoxRL8.Text = backend.getROMText(0xF, 0x735C, 2);
                textBoxRL9.Text = backend.getROMText(0xF, 0x7374, 2);
                textBoxRL10.Text = backend.getROMText(0xF, 0x7385, 2);
                textBoxRL11.Text = backend.getROMText(0xF, 0x739D, 2);
                textBoxRL12.Text = backend.getROMText(0xF, 0x73AE, 2);
                textBoxRL13.Text = backend.getROMText(0xF, 0x73BF, 2);
                textBoxRL14.Text = backend.getROMText(0xF, 0x73D7, 2);
                textBoxRL15.Text = backend.getROMText(0xF, 0x73F1, 2);
                textBoxRL16.Text = backend.getROMText(0xF, 0x740B, 2);
                textBoxRL17.Text = backend.getROMText(0xF, 0x741E, 2);
                textBoxRL18.Text = backend.getROMText(0xF, 0x7438, 2);
                textBoxRL19.Text = backend.getROMText(0xF, 0x7452, 2);
                textBoxRL20.Text = backend.getROMText(0xF, 0x7465, 2);
                textBoxRL21.Text = backend.getROMText(0xF, 0x747F, 2);
                textBoxRL22.Text = backend.getROMText(0xF, 0x7492, 2);
                textBoxRL23.Text = backend.getROMText(0xF, 0x74AC, 2);
                textBoxRL24.Text = backend.getROMText(0xF, 0x74BF, 2);
                textBoxRL25.Text = backend.getROMText(0xF, 0x74D2, 2);
                textBoxRL26.Text = backend.getROMText(0x10, 0x7223, 2);
                textBoxRL27.Text = backend.getROMText(0x10, 0x7261, 2);
                textBoxRL28.Text = backend.getROMText(0x14, 0x7235, 2);
                textBoxRL29.Text = backend.getROMText(0x14, 0x7273, 2);
                textBoxRL30.Text = backend.getROMText(0x11, 0x7289, 2);
                textBoxRL31.Text = backend.getROMText(0xC, 0x729C, 2);
                textBoxRL32.Text = backend.getROMText(0xD, 0x724B, 2);
                textBoxRL33.Text = backend.getROMText(0xD, 0x72AA, 2);
                textBoxRL34.Text = backend.getROMText(0x4, 0x719C, 2);
                textBoxRL35.Text = backend.getROMText(0x3, 0x71A1, 2);
                textBoxRL36.Text = backend.getROMText(0xD, 0x71AC, 2);
                textBoxRL37.Text = backend.getROMText(0xC, 0x71BC, 2);
                textBoxRL38.Text = backend.getROMText(0xC, 0x71CB, 2);
                textBoxRL39.Text = backend.getROMText(0x4, 0x71DB, 2);
                textBoxRL40.Text = backend.getROMText(0x6, 0x71E2, 2);
                textBoxRL41.Text = backend.getROMText(0x4, 0x71EB, 2);
                textBoxRL42.Text = backend.getROMText(0x5, 0x74ED, 2);
                textBoxRL43.Text = backend.getROMText(0xE, 0x74F6, 2);
                textBoxRL44.Text = backend.getROMText(0xA, 0x7506, 2);
                textBoxRL45.Text = backend.getROMText(0xA, 0x7512, 2);
                textBoxRL46.Text = backend.getROMText(0x3, 0x7525, 2);
                textBoxRL47.Text = backend.getROMText(0x2, 0x752A, 2);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRL1.MaxLength =  0x11;
            textBoxRL2.MaxLength =  0xF;
            textBoxRL3.MaxLength =  0xF;
            textBoxRL4.MaxLength =  0xF;
            textBoxRL5.MaxLength =  0xF;
            textBoxRL6.MaxLength =  0xF;
            textBoxRL7.MaxLength =  0xF;
            textBoxRL8.MaxLength =  0xF;
            textBoxRL9.MaxLength =  0xF;
            textBoxRL10.MaxLength = 0xF;
            textBoxRL11.MaxLength = 0xF;
            textBoxRL12.MaxLength = 0xF;
            textBoxRL13.MaxLength = 0xF;
            textBoxRL14.MaxLength = 0xF;
            textBoxRL15.MaxLength = 0xF;
            textBoxRL16.MaxLength = 0xF;
            textBoxRL17.MaxLength = 0xF;
            textBoxRL18.MaxLength = 0xF;
            textBoxRL19.MaxLength = 0xF;
            textBoxRL20.MaxLength = 0xF;
            textBoxRL21.MaxLength = 0xF;
            textBoxRL22.MaxLength = 0xF;
            textBoxRL23.MaxLength = 0xF;
            textBoxRL24.MaxLength = 0xF;
            textBoxRL25.MaxLength = 0xF;
            textBoxRL26.MaxLength = 0x10;
            textBoxRL27.MaxLength = 0x10;
            textBoxRL28.MaxLength = 0x14;
            textBoxRL29.MaxLength = 0x14;
            textBoxRL30.MaxLength = 0x11;
            textBoxRL31.MaxLength = 0xC;
            textBoxRL32.MaxLength = 0xD;
            textBoxRL33.MaxLength = 0xD;
            textBoxRL34.MaxLength = 0x4;
            textBoxRL35.MaxLength = 0x3;
            textBoxRL36.MaxLength = 0xD;
            textBoxRL37.MaxLength = 0xC;
            textBoxRL38.MaxLength = 0xC;
            textBoxRL39.MaxLength = 0x4;
            textBoxRL40.MaxLength = 0x6;
            textBoxRL41.MaxLength = 0x4;
            textBoxRL42.MaxLength = 0x5;
            textBoxRL43.MaxLength = 0xE;
            textBoxRL44.MaxLength = 0xA;
            textBoxRL45.MaxLength = 0xA;
            textBoxRL46.MaxLength = 0x3;
            textBoxRL47.MaxLength = 0x2;
        }
    }
}
