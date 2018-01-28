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
    public partial class FormDialog7 : Form
    {

        string path = "";

        public FormDialog7(string romPath)
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

                backend.updateROMText(0x16, textBoxFF1.Text, 0xAFB6, 0); //chants the spell of Σ.
                backend.updateROMText(0x15, textBoxFF2.Text, 0xAFCD, 0); //ь゜s spell is blocked.
                backend.updateROMText(0x45, textBoxFF3.Text, 0xAFFE, 0); //<If thou hast collected all the Treasure Chests,~a key will be found>
                backend.updateROMText(0x58, textBoxFF4.Text, 0xB045, 0); //<Once used, the key will disappear, but the door will be open and thou may pass through>
                backend.updateROMText(0x5B, textBoxFF5.Text, 0xB09E, 0); //<East of this castle is a town where armor, weapons, and many other items may be purchased>
                backend.updateROMText(0x3F, textBoxFF6.Text, 0xB0FB, 0); //<Return to the Inn for a rest if thou art wounded in battle, ь>
                backend.updateROMText(0x11, textBoxFF7.Text, 0xB13C, 0); //<Sleep heals all>
                backend.updateROMText(0x2F, textBoxFF8.Text, 0xB14E, 0); //<Descendant of Erdrick, listen now to my words>
                backend.updateROMText(0x49, textBoxFF9.Text, 0xB17F, 0); //<It is told that in ages past Erdrick fought demons with a Ball of Light>
                backend.updateROMText(0x52, textBoxFF10.Text, 0xB1CA, 0); //<Then came the Dragonlord who stole the precious globe and hid it in the darkness>
                backend.updateROMText(0x53, textBoxFF11.Text, 0xB21E, 0); //<Now, ь, thou must help us recover the Ball of Light and restore peace to our land>
                backend.updateROMText(0x21, textBoxFF12.Text, 0xB273, 0); //<The Dragonlord must be defeated>
                backend.updateROMText(0x53, textBoxFF13.Text, 0xB296, 0); //<Take now whatever thou may find in these Treasure Chests to aid thee in thy quest>
                backend.updateROMText(0x4C, textBoxFF14.Text, 0xB2EB, 0); //<Then speak with the guards, for they have much knowledge that may aid thee>
                backend.updateROMText(0x22, textBoxFF15.Text, 0xB339, 0); //<May the light shine upon thee, ь>
                backend.updateROMText(0x1C, textBoxFF16.Text, 0xB35D, 0); //The tablet reads as follows:
                backend.updateROMText(0x2A, textBoxFF17.Text, 0xB37D, 0); // <I am Erdrick and thou art my descendant>
                backend.updateROMText(0x55, textBoxFF18.Text, 0xB3A9, 0); // <Three items were needed to reach the Isle of Dragons, which is south of Brecconary>
                backend.updateROMText(0x5A, textBoxFF19.Text, 0xB400, 0); // <I gathered these items, reached the island, and there defeated a creature of great evil>
                backend.updateROMText(0x3F, textBoxFF20.Text, 0xB45C, 0); // <Now I have entrusted the three items to three worthy keepers>
                backend.updateROMText(0x57, textBoxFF21.Text, 0xB49D, 0); // <Their descendants will protect the items until thy quest leads thee to seek them out>
                backend.updateROMText(0x3C, textBoxFF22.Text, 0xB4F6, 0); // <When a new evil arises, find the three items, then fight!'
                backend.updateROMText(0xF, textBoxFF23.Text, 0xB533, 0); //Excellent move!
                backend.updateROMText(0x41, textBoxFF24.Text, 0xB543, 0); //<ь?~This is Gwaelin.~Know that thou hath reached the final level>
                backend.updateROMText(0x10, textBoxFF25.Text, 0xB586, 0); //Thou art asleep.
                backend.updateROMText(0x16, textBoxFF26.Text, 0xB599, 0); //Thou art still asleep.
                backend.updateROMText(0x9, textBoxFF27.Text, 0xB5B2, 0); //ь awakes.
                backend.updateROMText(0x15, textBoxFF28.Text, 0xB5BC, 0); //The ё hath recovered.
                backend.updateROMText(0xE, textBoxFF29.Text, 0xB5D2, 0); //It is dodging!
                backend.updateROMText(0x16, textBoxFF30.Text, 0xB5E1, 0); //There is no door here.
                backend.updateROMText(0x1B, textBoxFF31.Text, 0xB5F8, 0); //Thou hast not a key to use.
                backend.updateROMText(0x25, textBoxFF32.Text, 0xB614, 0); //<Death should not have taken thee, ь>
                backend.updateROMText(0x21, textBoxFF33.Text, 0xB63B, 0); //<I will give thee another chance>
                backend.updateROMText(0x19, textBoxFF34.Text, 0xB65E, 0); //Thy power increases by Ɠ.
                backend.updateROMText(0x22, textBoxFF35.Text, 0xB678, 0); //Thy Response Speed increases by Ɠ.
                backend.updateROMText(0x20, textBoxFF36.Text, 0xB69C, 0); // Thy Maximum Hitϋ increase by Ɠ.
                backend.updateROMText(0x22, textBoxFF37.Text, 0xB6BE, 0); // Thy Maximum Magicϋ increase by Ɠ.
                backend.updateROMText(0x3D, textBoxFF38.Text, 0xB6E1, 0); //<To reach the next level, thy Experienceϋ must increase by Ɠ>
                backend.updateROMText(0xD, textBoxFF39.Text, 0xB720, 0); //<Now, go, ь!'
                backend.updateROMText(0x26, textBoxFF40.Text, 0xB72E, 0); //<Thou hast failed and thou art cursed>

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form9_rc_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);

                textBoxFF1.Text = backend.getROMText(0x16, 0xAFB6, 0);
                textBoxFF2.Text = backend.getROMText(0x15, 0xAFCD, 0);
                textBoxFF3.Text = backend.getROMText(0x45, 0xAFFE, 0);
                textBoxFF4.Text = backend.getROMText(0x58, 0xB045, 0);
                textBoxFF5.Text = backend.getROMText(0x5B, 0xB09E, 0);
                textBoxFF6.Text = backend.getROMText(0x3F, 0xB0FB, 0);
                textBoxFF7.Text = backend.getROMText(0x11, 0xB13C, 0);
                textBoxFF8.Text = backend.getROMText(0x2F, 0xB14E, 0);
                textBoxFF9.Text = backend.getROMText(0x49, 0xB17F, 0);
                textBoxFF10.Text = backend.getROMText(0x52, 0xB1CA, 0);
                textBoxFF11.Text = backend.getROMText(0x53, 0xB21E, 0);
                textBoxFF12.Text = backend.getROMText(0x21, 0xB273, 0);
                textBoxFF13.Text = backend.getROMText(0x53, 0xB296, 0);
                textBoxFF14.Text = backend.getROMText(0x4C, 0xB2EB, 0);
                textBoxFF15.Text = backend.getROMText(0x22, 0xB339, 0);
                textBoxFF16.Text = backend.getROMText(0x1C, 0xB35D, 0);
                textBoxFF17.Text = backend.getROMText(0x2A, 0xB37D, 0);
                textBoxFF18.Text = backend.getROMText(0x55, 0xB3A9, 0);
                textBoxFF19.Text = backend.getROMText(0x5A, 0xB400, 0);
                textBoxFF20.Text = backend.getROMText(0x3F, 0xB45C, 0);
                textBoxFF21.Text = backend.getROMText(0x57, 0xB49D, 0);
                textBoxFF22.Text = backend.getROMText(0x3C, 0xB4F6, 0);
                textBoxFF23.Text = backend.getROMText(0xF, 0xB533, 0);
                textBoxFF24.Text = backend.getROMText(0x41, 0xB543, 0);
                textBoxFF25.Text = backend.getROMText(0x10, 0xB586, 0);
                textBoxFF26.Text = backend.getROMText(0x16, 0xB599, 0);
                textBoxFF27.Text = backend.getROMText(0x9, 0xB5B2, 0);
                textBoxFF28.Text = backend.getROMText(0x15, 0xB5BC, 0);
                textBoxFF29.Text = backend.getROMText(0xE, 0xB5D2, 0);
                textBoxFF30.Text = backend.getROMText(0x16, 0xB5E1, 0);
                textBoxFF31.Text = backend.getROMText(0x1B, 0xB5F8, 0);
                textBoxFF32.Text = backend.getROMText(0x25, 0xB614, 0);
                textBoxFF33.Text = backend.getROMText(0x21, 0xB63B, 0);
                textBoxFF34.Text = backend.getROMText(0x19, 0xB65E, 0);
                textBoxFF35.Text = backend.getROMText(0x22, 0xB678, 0);
                textBoxFF36.Text = backend.getROMText(0x20, 0xB69C, 0);
                textBoxFF37.Text = backend.getROMText(0x22, 0xB6BE, 0);
                textBoxFF38.Text = backend.getROMText(0x3D, 0xB6E1, 0);
                textBoxFF39.Text = backend.getROMText(0xD, 0xB720, 0);
                textBoxFF40.Text = backend.getROMText(0x26, 0xB72E, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxFF1.MaxLength =  0x16;
            textBoxFF2.MaxLength =  0x15;
            textBoxFF3.MaxLength =  0x45;
            textBoxFF4.MaxLength =  0x58;
            textBoxFF5.MaxLength =  0x5B;
            textBoxFF6.MaxLength =  0x3F;
            textBoxFF7.MaxLength =  0x11;
            textBoxFF8.MaxLength =  0x2F;
            textBoxFF9.MaxLength =  0x49;
            textBoxFF10.MaxLength = 0x52;
            textBoxFF11.MaxLength = 0x53;
            textBoxFF12.MaxLength = 0x21;
            textBoxFF13.MaxLength = 0x53;
            textBoxFF14.MaxLength = 0x4C;
            textBoxFF15.MaxLength = 0x22;
            textBoxFF16.MaxLength = 0x1C;
            textBoxFF17.MaxLength = 0x2A;
            textBoxFF18.MaxLength = 0x55;
            textBoxFF19.MaxLength = 0x5A;
            textBoxFF20.MaxLength = 0x3F;
            textBoxFF21.MaxLength = 0x57;
            textBoxFF22.MaxLength = 0x3C;
            textBoxFF23.MaxLength = 0xF;
            textBoxFF24.MaxLength = 0x41;
            textBoxFF25.MaxLength = 0x10;
            textBoxFF26.MaxLength = 0x16;
            textBoxFF27.MaxLength = 0x9;
            textBoxFF28.MaxLength = 0x15;
            textBoxFF29.MaxLength = 0xE;
            textBoxFF30.MaxLength = 0x16;
            textBoxFF31.MaxLength = 0x1B;
            textBoxFF32.MaxLength = 0x25;
            textBoxFF33.MaxLength = 0x21;
            textBoxFF34.MaxLength = 0x19;
            textBoxFF35.MaxLength = 0x22;
            textBoxFF36.MaxLength = 0x20;
            textBoxFF37.MaxLength = 0x22;
            textBoxFF38.MaxLength = 0x3D;
            textBoxFF39.MaxLength = 0xD;
            textBoxFF40.MaxLength = 0x26;
        }
    }
}
