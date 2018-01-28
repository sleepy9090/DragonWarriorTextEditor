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
    public partial class FormDialog5 : Form
    {

        string path = "";

        public FormDialog5(string romPath)
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

                backend.updateROMText(0x40, textBoxDD1.Text, 0xA32D, 0); //<Bring this to me and I will reward thee with the Staff of Rain>
                backend.updateROMText(0x22, textBoxDD2.Text, 0xA36E, 0); //<Thou hast brought the harp. Good>
                backend.updateROMText(0x61, textBoxDD3.Text, 0xA392, 0); //<In thy task thou hast failed. Alas, I fear thou art not the one Erdrick predicted would save us>
                backend.updateROMText(0x9, textBoxDD4.Text, 0xA3F5, 0); //<Go now!'
                backend.updateROMText(0x4C, textBoxDD5.Text, 0xA3FF, 0); //<Now the sun and rain shall meet and the Rainbow Drop passes to thy keeping>
                backend.updateROMText(0x27, textBoxDD6.Text, 0xA44C, 0); //<Thou art brave indeed to rescue me, ь>
                backend.updateROMText(0x21, textBoxDD7.Text, 0xA475, 0); //<I am Gwaelin, daughter of Lorik>
                backend.updateROMText(0xF, textBoxDD8.Text, 0xA498, 0); //<But thou must>
                backend.updateROMText(0x20, textBoxDD9.Text, 0xA4A9, 0); //Princess Gwaelin embraces thee.~
                backend.updateROMText(0xF, textBoxDD10.Text, 0xA4CB, 0); //<I゜m so happy!'
                backend.updateROMText(0x63, textBoxDD11.Text, 0xA4DB, 0); //<Forever shall I be grateful for the gift of my daughter returned to her home, ь.~Accept my thanks>
                backend.updateROMText(0x1F, textBoxDD12.Text, 0xA540, 0); //<Now, Gwaelin, come to my side>
                backend.updateROMText(0x4A, textBoxDD13.Text, 0xA561, 0); //Gwaelin then whispers:~<Wait a moment,please.~I would give a present to ь>
                backend.updateROMText(0x1A, textBoxDD14.Text, 0xA5AD, 0); //<Please accept my love, ь>
                backend.updateROMText(0x36, textBoxDD15.Text, 0xA5C9, 0); //<And I would like to have something of thine--a token>
                backend.updateROMText(0x16, textBoxDD16.Text, 0xA601, 0); //<Please give me thy ϊ>
                backend.updateROMText(0x46, textBoxDD17.Text, 0xA618, 0); //<Even when we two are parted by great distances, I shall be with thee>
                backend.updateROMText(0xD, textBoxDD18.Text, 0xA660, 0); //<Farewell, ь>
                backend.updateROMText(0x11, textBoxDD19.Text, 0xA66F, 0); //<I love thee, ь>~
                backend.updateROMText(0x18, textBoxDD20.Text, 0xA681, 0); //<Dost thou love me, ь?'~
                backend.updateROMText(0x51, textBoxDD21.Text, 0xA69A, 0); //<When thou art finished preparing for thy departure, please see me.~I shall wait>
                backend.updateROMText(0x31, textBoxDD22.Text, 0xA6EC, 0); //<I am greatly pleased that thou hast returned, ь>
                backend.updateROMText(0x3F, textBoxDD23.Text, 0xA71F, 0); //<Before reaching thy next level of experience thou must gain Ě>
                backend.updateROMText(0x5A, textBoxDD24.Text, 0xA760, 0); //<If thou dies I can bring thee back for another attempt without loss of thy deeds to date>
                backend.updateROMText(0x33, textBoxDD25.Text, 0xA7BD, 0); //<Goodbye now, ь.~Take care and tempt not the Fates>
                backend.updateROMText(0x23, textBoxDD26.Text, 0xA7F1, 0); //<Will thou take me to the castle?'~
                backend.updateROMText(0x19, textBoxDD27.Text, 0xA815, 0); //<Take the Treasure Chest>
                backend.updateROMText(0x30, textBoxDD28.Text, 0xA82F, 0); //<Welcome, ь.~I am the Dragonlord--King of Kings>
                backend.updateROMText(0x66, textBoxDD29.Text, 0xA861, 0); //<I give thee now a chance to share this world and to rule half of it if thou will now stand beside me>
                backend.updateROMText(0x3A, textBoxDD30.Text, 0xA8C9, 0); //<What sayest thou?~Will the great warrior stand with me?'~
                backend.updateROMText(0x14, textBoxDD31.Text, 0xA904, 0); //<Thou art a fool!®¢~
                backend.updateROMText(0x3F, textBoxDD32.Text, 0xA918, 0); //<Then half of this world is thine, half of the darkness, and$$'
                backend.updateROMText(0x3B, textBoxDD33.Text, 0xA959, 0); //Thy journey is over.~Take now a long, long rest.~Hahahaha$$
                backend.updateROMText(0x5E, textBoxDD34.Text, 0xA996, 0); //If thou would take the ϊ, thou must now discard some other item.~Dost thou wish to have the ϊ?
                backend.updateROMText(0x19, textBoxDD35.Text, 0xA9F5, 0); //Thou hast given up thy ϊ.
                backend.updateROMText(0x15, textBoxDD36.Text, 0xAA0F, 0); //What shall thou drop?
                backend.updateROMText(0x18, textBoxDD37.Text, 0xAA25, 0); //Thou hast dropped thy ϊ.
                backend.updateROMText(0x13, textBoxDD38.Text, 0xAA3E, 0); //And obtained the ϊ.
                backend.updateROMText(0x29, textBoxDD39.Text, 0xAA52, 0); //That is much too important to throw away.
                backend.updateROMText(0x20, textBoxDD40.Text, 0xAA7C, 0); //ь searched the ground all about.

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDialog6_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);

                textBoxDD1.Text = backend.getROMText(0x40, 0xA32D, 0);
                textBoxDD2.Text = backend.getROMText(0x22, 0xA36E, 0);
                textBoxDD3.Text = backend.getROMText(0x61, 0xA392, 0);
                textBoxDD4.Text = backend.getROMText(0x9, 0xA3F5, 0);
                textBoxDD5.Text = backend.getROMText(0x4C, 0xA3FF, 0);
                textBoxDD6.Text = backend.getROMText(0x27, 0xA44C, 0);
                textBoxDD7.Text = backend.getROMText(0x21, 0xA475, 0);
                textBoxDD8.Text = backend.getROMText(0xF, 0xA498, 0);
                textBoxDD9.Text = backend.getROMText(0x20, 0xA4A9, 0);
                textBoxDD10.Text = backend.getROMText(0xF, 0xA4CB, 0);
                textBoxDD11.Text = backend.getROMText(0x63, 0xA4DB, 0);
                textBoxDD12.Text = backend.getROMText(0x1F, 0xA540, 0);
                textBoxDD13.Text = backend.getROMText(0x4A, 0xA561, 0);
                textBoxDD14.Text = backend.getROMText(0x1A, 0xA5AD, 0);
                textBoxDD15.Text = backend.getROMText(0x36, 0xA5C9, 0);
                textBoxDD16.Text = backend.getROMText(0x16, 0xA601, 0);
                textBoxDD17.Text = backend.getROMText(0x46, 0xA618, 0);
                textBoxDD18.Text = backend.getROMText(0xD, 0xA660, 0);
                textBoxDD19.Text = backend.getROMText(0x11, 0xA66F, 0);
                textBoxDD20.Text = backend.getROMText(0x18, 0xA681, 0);
                textBoxDD21.Text = backend.getROMText(0x51, 0xA69A, 0);
                textBoxDD22.Text = backend.getROMText(0x31, 0xA6EC, 0);
                textBoxDD23.Text = backend.getROMText(0x3F, 0xA71F, 0);
                textBoxDD24.Text = backend.getROMText(0x5A, 0xA760, 0);
                textBoxDD25.Text = backend.getROMText(0x33, 0xA7BD, 0);
                textBoxDD26.Text = backend.getROMText(0x23, 0xA7F1, 0);
                textBoxDD27.Text = backend.getROMText(0x19, 0xA815, 0);
                textBoxDD28.Text = backend.getROMText(0x30, 0xA82F, 0);
                textBoxDD29.Text = backend.getROMText(0x66, 0xA861, 0);
                textBoxDD30.Text = backend.getROMText(0x3A, 0xA8C9, 0);
                textBoxDD31.Text = backend.getROMText(0x14, 0xA904, 0);
                textBoxDD32.Text = backend.getROMText(0x3F, 0xA918, 0);
                textBoxDD33.Text = backend.getROMText(0x3B, 0xA959, 0);
                textBoxDD34.Text = backend.getROMText(0x5E, 0xA996, 0);
                textBoxDD35.Text = backend.getROMText(0x19, 0xA9F5, 0);
                textBoxDD36.Text = backend.getROMText(0x15, 0xAA0F, 0);
                textBoxDD37.Text = backend.getROMText(0x18, 0xAA25, 0);
                textBoxDD38.Text = backend.getROMText(0x13, 0xAA3E, 0);
                textBoxDD39.Text = backend.getROMText(0x29, 0xAA52, 0);
                textBoxDD40.Text = backend.getROMText(0x20, 0xAA7C, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxDD1.MaxLength =  0x40;
            textBoxDD2.MaxLength =  0x22;
            textBoxDD3.MaxLength =  0x61;
            textBoxDD4.MaxLength =  0x9;
            textBoxDD5.MaxLength =  0x4C;
            textBoxDD6.MaxLength =  0x27;
            textBoxDD7.MaxLength =  0x21;
            textBoxDD8.MaxLength =  0xF;
            textBoxDD9.MaxLength =  0x20;
            textBoxDD10.MaxLength = 0xF;
            textBoxDD11.MaxLength = 0x63;
            textBoxDD12.MaxLength = 0x1F;
            textBoxDD13.MaxLength = 0x4A;
            textBoxDD14.MaxLength = 0x1A;
            textBoxDD15.MaxLength = 0x36;
            textBoxDD16.MaxLength = 0x16;
            textBoxDD17.MaxLength = 0x46;
            textBoxDD18.MaxLength = 0xD;
            textBoxDD19.MaxLength = 0x11;
            textBoxDD20.MaxLength = 0x18;
            textBoxDD21.MaxLength = 0x51;
            textBoxDD22.MaxLength = 0x31;
            textBoxDD23.MaxLength = 0x3F;
            textBoxDD24.MaxLength = 0x5A;
            textBoxDD25.MaxLength = 0x33;
            textBoxDD26.MaxLength = 0x23;
            textBoxDD27.MaxLength = 0x19;
            textBoxDD28.MaxLength = 0x30;
            textBoxDD29.MaxLength = 0x66;
            textBoxDD30.MaxLength = 0x3A;
            textBoxDD31.MaxLength = 0x14;
            textBoxDD32.MaxLength = 0x3F;
            textBoxDD33.MaxLength = 0x3B;
            textBoxDD34.MaxLength = 0x5E;
            textBoxDD35.MaxLength = 0x19;
            textBoxDD36.MaxLength = 0x15;
            textBoxDD37.MaxLength = 0x18;
            textBoxDD38.MaxLength = 0x13;
            textBoxDD39.MaxLength = 0x29;
            textBoxDD40.MaxLength = 0x20;
        }
    }
}
