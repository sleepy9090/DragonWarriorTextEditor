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
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x11, textBoxRL1,  0x72C0, 0); //BEGIN A NEW QUEST
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL2,  0x72DA, 0); //ADVENTURE LOG 1
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL3,  0x72F2, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL4,  0x730A, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL5,  0x731B, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL6,  0x7333, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL7,  0x734B, 0); //ADVENTURE LOG 
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL8,  0x735C, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL9,  0x7374, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL10, 0x7385, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL11, 0x739D, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL12, 0x73AE, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL13, 0x73BF, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL14, 0x73D7, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL15, 0x73F1, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL16, 0x740B, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL17, 0x741E, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL18, 0x7438, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL19, 0x7452, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL20, 0x7465, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL21, 0x747F, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL22, 0x7492, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL23, 0x74AC, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL24, 0x74BF, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRL25, 0x74D2, 0); //ADVENTURE LOG
                backend.updateROMText(absoluteFilename, 0x10, textBoxRL26, 0x7223, 0); //CONTINUE A QUEST
                backend.updateROMText(absoluteFilename, 0x10, textBoxRL27, 0x7261, 0); //CONTINUE A QUEST
                backend.updateROMText(absoluteFilename, 0x14, textBoxRL28, 0x7235, 0); //CHANGE MESSAGE SPEED
                backend.updateROMText(absoluteFilename, 0x14, textBoxRL29, 0x7273, 0); //CHANGE MESSAGE SPEED
                backend.updateROMText(absoluteFilename, 0x11, textBoxRL30, 0x7289, 0); //BEGIN A NEW QUEST
                backend.updateROMText(absoluteFilename, 0xC,  textBoxRL31, 0x729C, 0); //COPY A QUEST
                backend.updateROMText(absoluteFilename, 0xD,  textBoxRL32, 0x724B, 0); //ERASE A QUEST
                backend.updateROMText(absoluteFilename, 0xD,  textBoxRL33, 0x72AA, 0); //ERASE A QUEST
                backend.updateROMText(absoluteFilename, 0x4,  textBoxRL34, 0x719C, 0); //BACK
                backend.updateROMText(absoluteFilename, 0x3,  textBoxRL35, 0x71A1, 0); //END
                backend.updateROMText(absoluteFilename, 0xD,  textBoxRL36, 0x71AC, 0); //Which Message
                backend.updateROMText(absoluteFilename, 0xC,  textBoxRL37, 0x71BC, 0); //Speed Do You
                backend.updateROMText(absoluteFilename, 0xC,  textBoxRL38, 0x71CB, 0); //Want To Use?
                backend.updateROMText(absoluteFilename, 0x4,  textBoxRL39, 0x71DB, 0); //FAST
                backend.updateROMText(absoluteFilename, 0x6,  textBoxRL40, 0x71E2, 0); //NORMAL
                backend.updateROMText(absoluteFilename, 0x4,  textBoxRL41, 0x71EB, 0); //SLOW
                backend.updateROMText(absoluteFilename, 0x5,  textBoxRL42, 0x74ED, 0); //LEVEL
                backend.updateROMText(absoluteFilename, 0xE,  textBoxRL43, 0x74F6, 0); //Do You Want To
                backend.updateROMText(absoluteFilename, 0xA,  textBoxRL44, 0x7506, 0); //Erase This
                backend.updateROMText(absoluteFilename, 0xA,  textBoxRL45, 0x7512, 0); //Character?
                backend.updateROMText(absoluteFilename, 0x3,  textBoxRL46, 0x7525, 0); //YES
                backend.updateROMText(absoluteFilename, 0x2,  textBoxRL47, 0x752A, 0); //NO

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
                Backend backend = new Backend();

                backend.getText(path, textBoxRL1,  0x11, 0x72C0, 0);
                backend.getText(path, textBoxRL2,  0xF,  0x72DA, 0);
                backend.getText(path, textBoxRL3,  0xF,  0x72F2, 0);
                backend.getText(path, textBoxRL4,  0xF,  0x730A, 0);
                backend.getText(path, textBoxRL5,  0xF,  0x731B, 0);
                backend.getText(path, textBoxRL6,  0xF,  0x7333, 0);
                backend.getText(path, textBoxRL7,  0xF,  0x734B, 0);
                backend.getText(path, textBoxRL8,  0xF,  0x735C, 0);
                backend.getText(path, textBoxRL9,  0xF,  0x7374, 0);
                backend.getText(path, textBoxRL10, 0xF,  0x7385, 0);
                backend.getText(path, textBoxRL11, 0xF,  0x739D, 0);
                backend.getText(path, textBoxRL12, 0xF,  0x73AE, 0);
                backend.getText(path, textBoxRL13, 0xF,  0x73BF, 0);
                backend.getText(path, textBoxRL14, 0xF,  0x73D7, 0);
                backend.getText(path, textBoxRL15, 0xF,  0x73F1, 0);
                backend.getText(path, textBoxRL16, 0xF,  0x740B, 0);
                backend.getText(path, textBoxRL17, 0xF,  0x741E, 0);
                backend.getText(path, textBoxRL18, 0xF,  0x7438, 0);
                backend.getText(path, textBoxRL19, 0xF,  0x7452, 0);
                backend.getText(path, textBoxRL20, 0xF,  0x7465, 0);
                backend.getText(path, textBoxRL21, 0xF,  0x747F, 0);
                backend.getText(path, textBoxRL22, 0xF,  0x7492, 0);
                backend.getText(path, textBoxRL23, 0xF,  0x74AC, 0);
                backend.getText(path, textBoxRL24, 0xF,  0x74BF, 0);
                backend.getText(path, textBoxRL25, 0xF,  0x74D2, 0);
                backend.getText(path, textBoxRL26, 0x10, 0x7223, 0);
                backend.getText(path, textBoxRL27, 0x10, 0x7261, 0);
                backend.getText(path, textBoxRL28, 0x14, 0x7235, 0);
                backend.getText(path, textBoxRL29, 0x14, 0x7273, 0);
                backend.getText(path, textBoxRL30, 0x11, 0x7289, 0);
                backend.getText(path, textBoxRL31, 0xC,  0x729C, 0);
                backend.getText(path, textBoxRL32, 0xD,  0x724B, 0);
                backend.getText(path, textBoxRL33, 0xD,  0x72AA, 0);
                backend.getText(path, textBoxRL34, 0x4,  0x719C, 0);
                backend.getText(path, textBoxRL35, 0x3,  0x71A1, 0);
                backend.getText(path, textBoxRL36, 0xD,  0x71AC, 0);
                backend.getText(path, textBoxRL37, 0xC,  0x71BC, 0);
                backend.getText(path, textBoxRL38, 0xC,  0x71CB, 0);
                backend.getText(path, textBoxRL39, 0x4,  0x71DB, 0);
                backend.getText(path, textBoxRL40, 0x6,  0x71E2, 0);
                backend.getText(path, textBoxRL41, 0x4,  0x71EB, 0);
                backend.getText(path, textBoxRL42, 0x5,  0x74ED, 0);
                backend.getText(path, textBoxRL43, 0xE,  0x74F6, 0);
                backend.getText(path, textBoxRL44, 0xA,  0x7506, 0);
                backend.getText(path, textBoxRL45, 0xA,  0x7512, 0);
                backend.getText(path, textBoxRL46, 0x3,  0x7525, 0);
                backend.getText(path, textBoxRL47, 0x2,  0x752A, 0);

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
