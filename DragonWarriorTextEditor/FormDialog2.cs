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
namespace DragonWarriorTextEditor
{
    public partial class FormDialog2 : Form
    {

        string path = "";

        public FormDialog2(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x50, textBoxCC1.Text, 0x8A72, 0); //<To become strong enough to face future trials thou must first battle many foes>
                backend.updateROMText(0x5F, textBoxCC2.Text, 0x8AC3, 0); //<King Lorik will record thy deeds in his Imperial Scroll so thou may return to thy quest later>
                backend.updateROMText(0x3B, textBoxCC3.Text, 0x8B23, 0); //<When the sun and rain meet, a Rainbow Bridge shall appear>
                backend.updateROMText(0x21, textBoxCC4.Text, 0x8B5F, 0); //<Never does a brave person steal>
                backend.updateROMText(0x55, textBoxCC5.Text, 0x8B81, 0); //<There was a time when Brecconary was a paradise.~Then the Dragonlord’s minions came>
                backend.updateROMText(0x1F, textBoxCC6.Text, 0x8BD7, 0); //<Let us wish the warrior well!'
                backend.updateROMText(0x20, textBoxCC7.Text, 0x8BF8, 0); //<May the light be thy strength!'
                backend.updateROMText(0x38, textBoxCC8.Text, 0x8C19, 0); //<If thy Hit Points are high enough, by all means, enter>
                backend.updateROMText(0x7D, textBoxCC9.Text, 0x8C52, 0); //<We are merchants who have traveled much in this land.~Many of our colleagues have been killed by servants of the Dragonlord>
                backend.updateROMText(0x51, textBoxCC10.Text, 0x8CD0, 0); //<Rumor has it that entire towns have been destroyed by the Dragonlord’s servants>
                backend.updateROMText(0x1C, textBoxCC11.Text, 0x8D22, 0); //<Welcome to Tantegel Castle>
                backend.updateROMText(0x55, textBoxCC12.Text, 0x8D3F, 0); //<In Garinham,look for the grave of Garin.~Thou must push on a wall of darkness there>
                backend.updateROMText(0x12, textBoxCC13.Text, 0x8D95, 0); //<A word of advice>
                backend.updateROMText(0x29, textBoxCC14.Text, 0x8DA9, 0); //<Save thy money for more expensive armor>
                backend.updateROMText(0x34, textBoxCC15.Text, 0x8DD3, 0); //<Listen to what people say.~It can be of great help>
                backend.updateROMText(0x15, textBoxCC16.Text, 0x8E08, 0); //<Beware the bridges!'
                backend.updateROMText(0x20, textBoxCC17.Text, 0x8E1F, 0); //<Danger grows when thou crosses>
                backend.updateROMText(0x33, textBoxCC18.Text, 0x8E40, 0); //<There is a town where magic keys can be purchased>
                backend.updateROMText(0x36, textBoxCC19.Text, 0x8E74, 0); //<Some say that Garin’s grave is home to a Silver Harp>
                backend.updateROMText(0x16, textBoxCC20.Text, 0x8EAB, 0); //<Enter where thou can>
                backend.updateROMText(0x41, textBoxCC21.Text, 0x8EC2, 0); //<Welcome!~Enter the shop and speak to its keeper across the desk>
                backend.updateROMText(0x25, textBoxCC22.Text, 0x8F04, 0); //<Thou art most welcome in Brecconary>
                backend.updateROMText(0x32, textBoxCC23.Text, 0x8F2A, 0); //<Watch thy Hit Points when in the Poisonous Marsh>
                backend.updateROMText(0x5B, textBoxCC24.Text, 0x8F5D, 0); //<Go north to the seashore, then follow the coastline west until thou hath reached Garinham>
                backend.updateROMText(0x1E, textBoxCC25.Text, 0x8FB9, 0); //<No,I am not Princess Gwaelin>
                backend.updateROMText(0x33, textBoxCC26.Text, 0x8FD8, 0); //<Please,save us from the minions of the Dragonlord>
                backend.updateROMText(0x36, textBoxCC27.Text, 0x900C, 0); //<See King Lorik when thy experience levels are raised>
                backend.updateROMText(0x3A, textBoxCC28.Text, 0x9043, 0); //<Art thou the descendant of Erdrick?~Hast thou any proof?'
                backend.updateROMText(0x3B, textBoxCC29.Text, 0x907E, 0); //<Within sight of Tantegel Castle to the south is Charlock,'
                backend.updateROMText(0x20, textBoxCC30.Text, 0x90BB, 0); //<The fortress of the Dragonlord>
                backend.updateROMText(0x1C, textBoxCC31.Text, 0x90DC, 0); //<This bath cures rheumatism>
                backend.updateROMText(0x67, textBoxCC32.Text, 0x90F9, 0); //<East of Hauksness there is a town, ﾟtis said, where one may purchase weapons of extraordinary quality>
                backend.updateROMText(0x23, textBoxCC33.Text, 0x9161, 0); //<Rimuldar is the place to buy keys>
                backend.updateROMText(0x31, textBoxCC34.Text, 0x9185, 0); //<Hast thou seen Nester?~I think he may need help>
                backend.updateROMText(0x1E, textBoxCC35.Text, 0x91B7, 0); //<Dreadful is the South Island>
                backend.updateROMText(0x4C, textBoxCC36.Text, 0x91D7, 0); //<Great strength and skill and wit only will bring thee back from that place>
                backend.updateROMText(0x39, textBoxCC37.Text, 0x9224, 0); //<Golem is afraid of the music of the flute, so ﾟtis said>
                backend.updateROMText(0x1C, textBoxCC38.Text, 0x925E, 0); //<This is the village of Kol>
                backend.updateROMText(0x43, textBoxCC39.Text, 0x927B, 0); //<In legends it is said that fairies know how to put Golem to sleep>
                backend.updateROMText(0x41, textBoxCC40.Text, 0x92BF, 0); //<The harp attracts enemies.~Stay away from the grave in Garinham>

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDialog2_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);

                textBoxCC1.Text = backend.getROMText(0x50, 0x8A72, 0);
                textBoxCC2.Text = backend.getROMText(0x5F, 0x8AC3, 0);
                textBoxCC3.Text = backend.getROMText(0x3B, 0x8B23, 0);
                textBoxCC4.Text = backend.getROMText(0x21, 0x8B5F, 0);
                textBoxCC5.Text = backend.getROMText(0x55, 0x8B81, 0);
                textBoxCC6.Text = backend.getROMText(0x1F, 0x8BD7, 0);
                textBoxCC7.Text = backend.getROMText(0x20, 0x8BF8, 0);
                textBoxCC8.Text = backend.getROMText(0x38, 0x8C19, 0);
                textBoxCC9.Text = backend.getROMText(0x7D, 0x8C52, 0);
                textBoxCC10.Text = backend.getROMText(0x51, 0x8CD0, 0);
                textBoxCC11.Text = backend.getROMText(0x1C, 0x8D22, 0);
                textBoxCC12.Text = backend.getROMText(0x55, 0x8D3F, 0);
                textBoxCC13.Text = backend.getROMText(0x12, 0x8D95, 0);
                textBoxCC14.Text = backend.getROMText(0x29, 0x8DA9, 0);
                textBoxCC15.Text = backend.getROMText(0x34, 0x8DD3, 0);
                textBoxCC16.Text = backend.getROMText(0x15, 0x8E08, 0);
                textBoxCC17.Text = backend.getROMText(0x20, 0x8E1F, 0);
                textBoxCC18.Text = backend.getROMText(0x33, 0x8E40, 0);
                textBoxCC19.Text = backend.getROMText(0x36, 0x8E74, 0);
                textBoxCC20.Text = backend.getROMText(0x16, 0x8EAB, 0);
                textBoxCC21.Text = backend.getROMText(0x41, 0x8EC2, 0);
                textBoxCC22.Text = backend.getROMText(0x25, 0x8F04, 0);
                textBoxCC23.Text = backend.getROMText(0x32, 0x8F2A, 0);
                textBoxCC24.Text = backend.getROMText(0x5B, 0x8F5D, 0);
                textBoxCC25.Text = backend.getROMText(0x1E, 0x8FB9, 0);
                textBoxCC26.Text = backend.getROMText(0x33, 0x8FD8, 0);
                textBoxCC27.Text = backend.getROMText(0x36, 0x900C, 0);
                textBoxCC28.Text = backend.getROMText(0x3A, 0x9043, 0);
                textBoxCC29.Text = backend.getROMText(0x3B, 0x907E, 0);
                textBoxCC30.Text = backend.getROMText(0x20, 0x90BB, 0);
                textBoxCC31.Text = backend.getROMText(0x1C, 0x90DC, 0);
                textBoxCC32.Text = backend.getROMText(0x67, 0x90F9, 0);
                textBoxCC33.Text = backend.getROMText(0x23, 0x9161, 0);
                textBoxCC34.Text = backend.getROMText(0x31, 0x9185, 0);
                textBoxCC35.Text = backend.getROMText(0x1E, 0x91B7, 0);
                textBoxCC36.Text = backend.getROMText(0x4C, 0x91D7, 0);
                textBoxCC37.Text = backend.getROMText(0x39, 0x9224, 0);
                textBoxCC38.Text = backend.getROMText(0x1C, 0x925E, 0);
                textBoxCC39.Text = backend.getROMText(0x43, 0x927B, 0);
                textBoxCC40.Text = backend.getROMText(0x41, 0x92BF, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxCC1.MaxLength =  0x50;
            textBoxCC2.MaxLength =  0x5F;
            textBoxCC3.MaxLength =  0x3B;
            textBoxCC4.MaxLength =  0x21;
            textBoxCC5.MaxLength =  0x55;
            textBoxCC6.MaxLength =  0x1F;
            textBoxCC7.MaxLength =  0x20;
            textBoxCC8.MaxLength =  0x38;
            textBoxCC9.MaxLength =  0x7D;
            textBoxCC10.MaxLength = 0x51;
            textBoxCC11.MaxLength = 0x1C;
            textBoxCC12.MaxLength = 0x55;
            textBoxCC13.MaxLength = 0x12;
            textBoxCC14.MaxLength = 0x29;
            textBoxCC15.MaxLength = 0x34;
            textBoxCC16.MaxLength = 0x15;
            textBoxCC17.MaxLength = 0x20;
            textBoxCC18.MaxLength = 0x33;
            textBoxCC19.MaxLength = 0x36;
            textBoxCC20.MaxLength = 0x16;
            textBoxCC21.MaxLength = 0x41;
            textBoxCC22.MaxLength = 0x25;
            textBoxCC23.MaxLength = 0x32;
            textBoxCC24.MaxLength = 0x5B;
            textBoxCC25.MaxLength = 0x1E;
            textBoxCC26.MaxLength = 0x33;
            textBoxCC27.MaxLength = 0x36;
            textBoxCC28.MaxLength = 0x3A;
            textBoxCC29.MaxLength = 0x3B;
            textBoxCC30.MaxLength = 0x20;
            textBoxCC31.MaxLength = 0x1C;
            textBoxCC32.MaxLength = 0x67;
            textBoxCC33.MaxLength = 0x23;
            textBoxCC34.MaxLength = 0x31;
            textBoxCC35.MaxLength = 0x1E;
            textBoxCC36.MaxLength = 0x4C;
            textBoxCC37.MaxLength = 0x39;
            textBoxCC38.MaxLength = 0x1C;
            textBoxCC39.MaxLength = 0x43;
            textBoxCC40.MaxLength = 0x41;
        }
    }
}
