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
    public partial class FormDialog9 : Form {

        string path = "";

        public FormDialog9(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x2F, textBoxRC1.Text, 0xB14E, 0); //<Descendant of Erdrick, listen now to my words>
                backend.updateROMText(0x49, textBoxRC2.Text, 0xB17F, 0); //<It is told that in ages past Erdrick fought demons with a Ball of Light>
                backend.updateROMText(0x52, textBoxRC3.Text, 0xB1CA, 0); //<Then came the Dragonlord who stole the precious globe and hid it in the darkness>
                backend.updateROMText(0x53, textBoxRC4.Text, 0xB21E, 0); //<Now, @, thou must help us recover the Ball of Light and restore peace to our land>
                backend.updateROMText(0x21, textBoxRC5.Text, 0xB273, 0); //<The Dragonlord must be defeated>
                backend.updateROMText(0x53, textBoxRC6.Text, 0xB296, 0); //<Take now whatever thou may find in these Treasure Chests to aid thee in thy quest>
                backend.updateROMText(0x4C, textBoxRC7.Text, 0xB2EB, 0); //<Then speak with the guards, for they have much knowledge that may aid thee>
                backend.updateROMText(0x22, textBoxRC8.Text, 0xB339, 0); //<May the light shine upon thee, @>
                backend.updateROMText(0x10, textBoxRC9.Text, 0x8038, 0); //ё hath woken up.
                backend.updateROMText(0xE, textBoxRC10.Text, 0x804B, 0); //Thou art dead.
                backend.updateROMText(0x41, textBoxRC11.Text, 0x805A, 0); //<Thou art strong enough!~Why can thou not defeat the Dragonlord?'
                backend.updateROMText(0x3B, textBoxRC12.Text, 0x809D, 0); //<If thou art planning to take a rest, first see King Lorik>
                backend.updateROMText(0x27, textBoxRC13.Text, 0x80D9, 0); //@ held the Rainbow Drop toward the sky.
                backend.updateROMText(0x1D, textBoxRC14.Text, 0x8104, 0); //But no rainbow appeared here.
                backend.updateROMText(0x39, textBoxRC15.Text, 0x8122, 0); //<Good morning.~Thou hast had a good night’s sleep I hope>
                backend.updateROMText(0x18, textBoxRC16.Text, 0x815D, 0); //<I shall see thee again>
                backend.updateROMText(0x35, textBoxRC17.Text, 0x8176, 0); //<Good morning.~Thou seems to have spent a good night>
                backend.updateROMText(0xC, textBoxRC18.Text, 0x81AD, 0); //<Good night>
                backend.updateROMText(0x1A, textBoxRC19.Text, 0x81BB, 0); //<Okay.~Good-bye, traveler>
                backend.updateROMText(0x5B, textBoxRC20.Text, 0x81D6, 0); //<Welcome to the traveler's Inn.~Room and board is % GOLD per night.~Dost thou want a room?'~
                backend.updateROMText(0x16, textBoxRC21.Text, 0x8233, 0); //<All the best to thee>
                backend.updateROMText(0x1A, textBoxRC22.Text, 0x824A, 0); //<There are no stairs here>
                backend.updateROMText(0x18, textBoxRC23.Text, 0x8265, 0); //<Thou cannot enter here>
                backend.updateROMText(0x17, textBoxRC24.Text, 0x827E, 0); //<There is no one there>
                backend.updateROMText(0x2F, textBoxRC25.Text, 0x8296, 0); //<I thank thee.~Won’t thou buy one more bottle?'~
                backend.updateROMText(0x53, textBoxRC26.Text, 0x82C7, 0); //<Will thou buy some Fairy Water for 38 GOLD to keep the Dragonlord's minions away?'
                backend.updateROMText(0x17, textBoxRC27.Text, 0x831C, 0); //<I will see thee later>
                backend.updateROMText(0x1C, textBoxRC28.Text, 0x8334, 0); //<Thou hast not enough money>
                backend.updateROMText(0x2C, textBoxRC29.Text, 0x8352, 0); //<I am sorry, but I cannot sell thee anymore>
                backend.updateROMText(0x36, textBoxRC30.Text, 0x837F, 0); //<Here,take this key. Dost thou wish to purchase more?'
                backend.updateROMText(0x53, textBoxRC31.Text, 0x83B7, 0); //<Magic keys! They will unlock any door. Dost thou wish to purchase one for % GOLD?'
                backend.updateROMText(0xC, textBoxRC32.Text, 0x840C, 0); //<I am sorry>
                backend.updateROMText(0x19, textBoxRC33.Text, 0x841A, 0); //A curse is upon thy body.
                backend.updateROMText(0x1A, textBoxRC34.Text, 0x8435, 0); //<Thou hast no possessions>
                backend.updateROMText(0x20, textBoxRC35.Text, 0x8450, 0); //<Wilt thou sell anything else?'~
                backend.updateROMText(0x11, textBoxRC36.Text, 0x8471, 0); //<I cannot buy it>
                backend.updateROMText(0x42, textBoxRC37.Text, 0x8483, 0); //<Thou said the +. I will buy thy + for % GOLD.~Is that all right?'
                backend.updateROMText(0x18, textBoxRC38.Text, 0x84C7, 0); //<What art thou selling?'
                backend.updateROMText(0x26, textBoxRC39.Text, 0x84E1, 0); //<I will be waiting for thy next visit>
                backend.updateROMText(0x1F, textBoxRC40.Text, 0x8508, 0); //<Dost thou want anything else?'

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDialog9_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxRC1.Text = backend.getROMText(0x2F, 0xB14E, 0);
                textBoxRC2.Text = backend.getROMText(0x49, 0xB17F, 0);
                textBoxRC3.Text = backend.getROMText(0x52, 0xB1CA, 0);
                textBoxRC4.Text = backend.getROMText(0x53, 0xB21E, 0);
                textBoxRC5.Text = backend.getROMText(0x21, 0xB273, 0);
                textBoxRC6.Text = backend.getROMText(0x53, 0xB296, 0);
                textBoxRC7.Text = backend.getROMText(0x4C, 0xB2EB, 0);
                textBoxRC8.Text = backend.getROMText(0x22, 0xB339, 0);
                textBoxRC9.Text = backend.getROMText(0x10, 0x8038, 0);
                textBoxRC10.Text = backend.getROMText(0xE, 0x804B, 0);
                textBoxRC11.Text = backend.getROMText(0x41, 0x805A, 0);
                textBoxRC12.Text = backend.getROMText(0x3B, 0x809D, 0);
                textBoxRC13.Text = backend.getROMText(0x27, 0x80D9, 0);
                textBoxRC14.Text = backend.getROMText(0x1D, 0x8104, 0);
                textBoxRC15.Text = backend.getROMText(0x39, 0x8122, 0);
                textBoxRC16.Text = backend.getROMText(0x18, 0x815D, 0);
                textBoxRC17.Text = backend.getROMText(0x35, 0x8176, 0);
                textBoxRC18.Text = backend.getROMText(0xC, 0x81AD, 0);
                textBoxRC19.Text = backend.getROMText(0x1A, 0x81BB, 0);
                textBoxRC20.Text = backend.getROMText(0x5B, 0x81D6, 0);
                textBoxRC21.Text = backend.getROMText(0x16, 0x8233, 0);
                textBoxRC22.Text = backend.getROMText(0x1A, 0x824A, 0);
                textBoxRC23.Text = backend.getROMText(0x18, 0x8265, 0);
                textBoxRC24.Text = backend.getROMText(0x17, 0x827E, 0);
                textBoxRC25.Text = backend.getROMText(0x2F, 0x8296, 0);
                textBoxRC26.Text = backend.getROMText(0x53, 0x82C7, 0);
                textBoxRC27.Text = backend.getROMText(0x17, 0x831C, 0);
                textBoxRC28.Text = backend.getROMText(0x1C, 0x8334, 0);
                textBoxRC29.Text = backend.getROMText(0x2C, 0x8352, 0);
                textBoxRC30.Text = backend.getROMText(0x36, 0x837F, 0);
                textBoxRC31.Text = backend.getROMText(0x53, 0x83B7, 0);
                textBoxRC32.Text = backend.getROMText(0xC, 0x840C, 0);
                textBoxRC33.Text = backend.getROMText(0x19, 0x841A, 0);
                textBoxRC34.Text = backend.getROMText(0x1A, 0x8435, 0);
                textBoxRC35.Text = backend.getROMText(0x20, 0x8450, 0);
                textBoxRC36.Text = backend.getROMText(0x11, 0x8471, 0);
                textBoxRC37.Text = backend.getROMText(0x42, 0x8483, 0);
                textBoxRC38.Text = backend.getROMText(0x18, 0x84C7, 0);
                textBoxRC39.Text = backend.getROMText(0x26, 0x84E1, 0);
                textBoxRC40.Text = backend.getROMText(0x1F, 0x8508, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRC1.MaxLength =  0x2F;
            textBoxRC2.MaxLength =  0x49;
            textBoxRC3.MaxLength =  0x52;
            textBoxRC4.MaxLength =  0x53;
            textBoxRC5.MaxLength =  0x21;
            textBoxRC6.MaxLength =  0x53;
            textBoxRC7.MaxLength =  0x4C;
            textBoxRC8.MaxLength =  0x22;
            textBoxRC9.MaxLength =  0x10;
            textBoxRC10.MaxLength = 0xE;
            textBoxRC11.MaxLength = 0x41;
            textBoxRC12.MaxLength = 0x3B;
            textBoxRC13.MaxLength = 0x27;
            textBoxRC14.MaxLength = 0x1D;
            textBoxRC15.MaxLength = 0x39;
            textBoxRC16.MaxLength = 0x18;
            textBoxRC17.MaxLength = 0x35;
            textBoxRC18.MaxLength = 0xC;
            textBoxRC19.MaxLength = 0x1A;
            textBoxRC20.MaxLength = 0x5B;
            textBoxRC21.MaxLength = 0x16;
            textBoxRC22.MaxLength = 0x1A;
            textBoxRC23.MaxLength = 0x18;
            textBoxRC24.MaxLength = 0x17;
            textBoxRC25.MaxLength = 0x2F;
            textBoxRC26.MaxLength = 0x53;
            textBoxRC27.MaxLength = 0x17;
            textBoxRC28.MaxLength = 0x1C;
            textBoxRC29.MaxLength = 0x2C;
            textBoxRC30.MaxLength = 0x36;
            textBoxRC31.MaxLength = 0x53;
            textBoxRC32.MaxLength = 0xC;
            textBoxRC33.MaxLength = 0x19;
            textBoxRC34.MaxLength = 0x1A;
            textBoxRC35.MaxLength = 0x20;
            textBoxRC36.MaxLength = 0x11;
            textBoxRC37.MaxLength = 0x42;
            textBoxRC38.MaxLength = 0x18;
            textBoxRC39.MaxLength = 0x26;
            textBoxRC40.MaxLength = 0x1F;
        }
    }
}
