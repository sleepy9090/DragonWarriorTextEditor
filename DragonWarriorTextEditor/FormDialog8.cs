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
    public partial class FormDialog8 : Form
    {

        string path = "";

        public FormDialog8(string romPath)
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

                backend.updateROMText(0x10, textBoxGG1.Text, 0xB756, 0); //‘Leave at once!'
                backend.updateROMText(0x4, textBoxGG2.Text, 0xB767, 0); //‘..'
                backend.updateROMText(0x9, textBoxGG3.Text, 0xB76C, 0); //‘Really?'
                backend.updateROMText(0x40, textBoxGG4.Text, 0xB777, 0); //‘I am glad thou hast returned.~All our hopes are riding on thee’
                backend.updateROMText(0x2B, textBoxGG5.Text, 0xB7B9, 0); //‘See me again when thy level has increased’
                backend.updateROMText(0x26, textBoxGG6.Text, 0xB7E6, 0); //The Dragonlord revealed his true self!
                backend.updateROMText(0x22, textBoxGG7.Text, 0xB80E, 0); //Thou hast found the Ball of Light.
                backend.updateROMText(0x47, textBoxGG8.Text, 0xB832, 0); //Radiance streams forth as thy hands touch the object and hold it aloft.
                backend.updateROMText(0x5C, textBoxGG9.Text, 0xB87B, 0); //Across the land spreads the brilliance until all shadows are banished and peace is restored.
                backend.updateROMText(0x1E, textBoxGG10.Text, 0xB8D8, 0); //‘The legends have proven true’
                backend.updateROMText(0x28, textBoxGG11.Text, 0xB8F8, 0); //‘Thou art indeed of the line of Erdrick’
                backend.updateROMText(0x28, textBoxGG12.Text, 0xB922, 0); //‘It is thy right to rule over this land’
                backend.updateROMText(0x1A, textBoxGG13.Text, 0xB94C, 0); //‘Will thou take my place?'
                backend.updateROMText(0x25, textBoxGG14.Text, 0xB968, 0); //ь thought carefully before answering.
                backend.updateROMText(0x12, textBoxGG15.Text, 0xB98F, 0); //I cannot,'said ь.
                backend.updateROMText(0x46, textBoxGG16.Text, 0xB9A4, 0); //‘If ever I am to rule a country, it must be a land that I myself find’
                backend.updateROMText(0x1C, textBoxGG17.Text, 0xB9EC, 0); //Gwaelin said: ‘Please, wait’
                backend.updateROMText(0x27, textBoxGG18.Text, 0xBA0A, 0); //‘I wish to go with thee on thy journey’
                backend.updateROMText(0x21, textBoxGG19.Text, 0xBA33, 0); //‘May I travel as thy companion?'
                backend.updateROMText(0x1F, textBoxGG20.Text, 0xBA55, 0); //‘Hurrah! Hurrah! Long live ь!'
                backend.updateROMText(0x23, textBoxGG21.Text, 0xBA75, 0); //‘Thou hast brought us peace, again’
                backend.updateROMText(0x1D, textBoxGG22.Text, 0xBA99, 0); //‘Come now, King Lorik awaits’
                backend.updateROMText(0x44, textBoxGG23.Text, 0xBAC5, 0); //And thus the tale comes to an end...unless the dragons return again.
                backend.updateROMText(0x40, textBoxGG24.Text, 0xBB11, 0); //‘Will thou tell me now of thy deeds so they won't be forgotten?'
                backend.updateROMText(0x3F, textBoxGG25.Text, 0xBB53, 0); //‘Thy deeds have been recorded on the Imperial Scrolls of Honor’
                backend.updateROMText(0x27, textBoxGG26.Text, 0xBB94, 0); //‘Dost thou wish to continue thy quest?'
                backend.updateROMText(0x16, textBoxGG27.Text, 0xBBBD, 0); //‘Rest then for awhile’
                backend.updateROMText(0x7, textBoxGG28.Text, 0xBBD5, 0); //‘Go ь!'
                backend.updateROMText(0x37, textBoxGG29.Text, 0xBBDD, 0); //Please push RESET, hold it in, then turn off the POWER.
                backend.updateROMText(0x60, textBoxGG30.Text, 0xBC16, 0); //If you turn the power off first, the Imperial Scroll of Honor containing your deeds may be lost.
                backend.updateROMText(0x42, textBoxGG31.Text, 0xBC7C, 0); //Unfortunately, NO deeds were recorded on Imperial Scroll number Ɠ.

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDialog8_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend(path);

                textBoxGG1.Text = backend.getROMText(0x10, 0xB756, 0);
                textBoxGG2.Text = backend.getROMText(0x4, 0xB767, 0);
                textBoxGG3.Text = backend.getROMText(0x9, 0xB76C, 0);
                textBoxGG4.Text = backend.getROMText(0x40, 0xB777, 0);
                textBoxGG5.Text = backend.getROMText(0x2B, 0xB7B9, 0);
                textBoxGG6.Text = backend.getROMText(0x26, 0xB7E6, 0);
                textBoxGG7.Text = backend.getROMText(0x22, 0xB80E, 0);
                textBoxGG8.Text = backend.getROMText(0x47, 0xB832, 0);
                textBoxGG9.Text = backend.getROMText(0x5C, 0xB87B, 0);
                textBoxGG10.Text = backend.getROMText(0x1E, 0xB8D8, 0);
                textBoxGG11.Text = backend.getROMText(0x28, 0xB8F8, 0);
                textBoxGG12.Text = backend.getROMText(0x28, 0xB922, 0);
                textBoxGG13.Text = backend.getROMText(0x1A, 0xB94C, 0);
                textBoxGG14.Text = backend.getROMText(0x25, 0xB968, 0);
                textBoxGG15.Text = backend.getROMText(0x12, 0xB98F, 0);
                textBoxGG16.Text = backend.getROMText(0x46, 0xB9A4, 0);
                textBoxGG17.Text = backend.getROMText(0x1C, 0xB9EC, 0);
                textBoxGG18.Text = backend.getROMText(0x27, 0xBA0A, 0);
                textBoxGG19.Text = backend.getROMText(0x21, 0xBA33, 0);
                textBoxGG20.Text = backend.getROMText(0x1F, 0xBA55, 0);
                textBoxGG21.Text = backend.getROMText(0x23, 0xBA75, 0);
                textBoxGG22.Text = backend.getROMText(0x1D, 0xBA99, 0);
                textBoxGG23.Text = backend.getROMText(0x44, 0xBAC5, 0);
                textBoxGG24.Text = backend.getROMText(0x40, 0xBB11, 0);
                textBoxGG25.Text = backend.getROMText(0x3F, 0xBB53, 0);
                textBoxGG26.Text = backend.getROMText(0x27, 0xBB94, 0);
                textBoxGG27.Text = backend.getROMText(0x16, 0xBBBD, 0);
                textBoxGG28.Text = backend.getROMText(0x7, 0xBBD5, 0);
                textBoxGG29.Text = backend.getROMText(0x37, 0xBBDD, 0);
                textBoxGG30.Text = backend.getROMText(0x60, 0xBC16, 0);
                textBoxGG31.Text = backend.getROMText(0x42, 0xBC7C, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxGG1.MaxLength =  0x10;
            textBoxGG2.MaxLength =  0x4;
            textBoxGG3.MaxLength = 0x9;
            textBoxGG4.MaxLength =  0x40;
            textBoxGG5.MaxLength =  0x2B;
            textBoxGG6.MaxLength =  0x26;
            textBoxGG7.MaxLength =  0x22;
            textBoxGG8.MaxLength =  0x47;
            textBoxGG9.MaxLength =  0x5C;
            textBoxGG10.MaxLength = 0x1E;
            textBoxGG11.MaxLength = 0x28;
            textBoxGG12.MaxLength = 0x28;
            textBoxGG13.MaxLength = 0x1A;
            textBoxGG14.MaxLength = 0x25;
            textBoxGG15.MaxLength = 0x12;
            textBoxGG16.MaxLength = 0x46;
            textBoxGG17.MaxLength = 0x1C;
            textBoxGG18.MaxLength = 0x27;
            textBoxGG19.MaxLength = 0x21;
            textBoxGG20.MaxLength = 0x1F;
            textBoxGG21.MaxLength = 0x23;
            textBoxGG22.MaxLength = 0x1D;
            textBoxGG23.MaxLength = 0x44;
            textBoxGG24.MaxLength = 0x40;
            textBoxGG25.MaxLength = 0x3F;
            textBoxGG26.MaxLength = 0x27;
            textBoxGG27.MaxLength = 0x16;
            textBoxGG28.MaxLength = 0x7;
            textBoxGG29.MaxLength = 0x37;
            textBoxGG30.MaxLength = 0x60;
            textBoxGG31.MaxLength = 0x42;
        }
    }
}
