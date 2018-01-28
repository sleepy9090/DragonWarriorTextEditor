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
    public partial class FormDialog6 : Form
    {

        string path = "";

        public FormDialog6(string romPath)
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

                backend.updateROMText(0x18, textBoxEE1.Text, 0xAA9F, 0); //But there found nothing.
                backend.updateROMText(0x18, textBoxEE2.Text, 0xAAB8, 0); //There is a treasure box.
                backend.updateROMText(0x12, textBoxEE3.Text, 0xAAD1, 0); //ь discovers the ϊ.
                backend.updateROMText(0x2D, textBoxEE4.Text, 0xAAE4, 0); //Feel the wind blowing from behind the throne.
                backend.updateROMText(0x21, textBoxEE5.Text, 0xAB12, 0); //There is nothing to take here, ь.
                backend.updateROMText(0x1A, textBoxEE6.Text, 0xAB34, 0); //Of GOLD thou hast gained Ɠ
                backend.updateROMText(0x33, textBoxEE7.Text, 0xAB4F, 0); //Fortune smiles upon thee, ь.~Thou hast found the ϊ.
                backend.updateROMText(0x1B, textBoxEE8.Text, 0xAB83, 0); //Unfortunately, it is empty.
                backend.updateROMText(0x7B, textBoxEE9.Text, 0xAB9F, 0); //Heed my voice,~<ь, for this is Gwaelin.~To reach the next level thou must raise thy Experienceϋ × by Ɠ.~My hope is with thee>
                backend.updateROMText(0x29, textBoxEE10.Text, 0xAC1C, 0); //<From where thou art now, my castle lies$
                backend.updateROMText(0x13, textBoxEE11.Text, 0xAC48, 0); //Ɠ to the north and$
                backend.updateROMText(0x13, textBoxEE12.Text, 0xAC5D, 0); //Ɠ to the south and$
                backend.updateROMText(0xE, textBoxEE13.Text, 0xAC72, 0); //Ɠ to the east>
                backend.updateROMText(0xE, textBoxEE14.Text, 0xAC83, 0); //Ɠ to the west>
                backend.updateROMText(0xE, textBoxEE15.Text, 0xAC93, 0); //Aш draws near!
                backend.updateROMText(0x16, textBoxEE16.Text, 0xACA4, 0); //The ё is running away.
                backend.updateROMText(0x22, textBoxEE17.Text, 0xACBD, 0); //The ё attacked before ь was ready.
                backend.updateROMText(0xA, textBoxEE18.Text, 0xACE0, 0); //ь attacks!
                backend.updateROMText(0x24, textBoxEE19.Text, 0xACEB, 0); //The ё゜s Hitϋ have been reduced by Ɠ.
                backend.updateROMText(0x36, textBoxEE20.Text, 0xAD10, 0); //The attack failed and there was no loss of Hit Points!
                backend.updateROMText(0x8, textBoxEE21.Text, 0xAD49, 0); //Command?
                backend.updateROMText(0x1E, textBoxEE22.Text, 0xAD52, 0); //That cannot be used in battle.
                backend.updateROMText(0x21, textBoxEE23.Text, 0xAD73, 0); //But that spell hath been blocked.
                backend.updateROMText(0x18, textBoxEE24.Text, 0xAD95, 0); //The spell will not work.
                backend.updateROMText(0x1D, textBoxEE25.Text, 0xADAE, 0); //Thou hast put the ё to sleep.
                backend.updateROMText(0x20, textBoxEE26.Text, 0xADCC, 0); //The ё゜s spell hath been blocked.
                backend.updateROMText(0x28, textBoxEE27.Text, 0xADEF, 0); //Thou hast done well in defeating the ё.~
                backend.updateROMText(0x1E, textBoxEE28.Text, 0xAE19, 0); //Thy Experience~increases by Ɠ.
                backend.updateROMText(0x18, textBoxEE29.Text, 0xAE38, 0); //Thy GOLD~increases by Ɠ.
                backend.updateROMText(0x51, textBoxEE30.Text, 0xAE54, 0); //Courage and wit have served thee well.~Thou hast been promoted to the next level.
                backend.updateROMText(0x1E, textBoxEE31.Text, 0xAEA9, 0); //Thou hast learned a new spell.
                backend.updateROMText(0x35, textBoxEE32.Text, 0xAEC8, 0); //Quietly Golem closes his eyes and settles into sleep.
                backend.updateROMText(0xE, textBoxEE33.Text, 0xAEFE, 0); //ё looks happy.
                backend.updateROMText(0x16, textBoxEE34.Text, 0xAF0F, 0); //ь started to run away.
                backend.updateROMText(0x19, textBoxEE35.Text, 0xAF26, 0); //But was blocked in front.
                backend.updateROMText(0x10, textBoxEE36.Text, 0xAF40, 0); //ь used the Herb.
                backend.updateROMText(0x10, textBoxEE37.Text, 0xAF53, 0); //The ё is asleep.
                backend.updateROMText(0xE, textBoxEE38.Text, 0xAF66, 0); //The ё attacks!
                backend.updateROMText(0x18, textBoxEE39.Text, 0xAF75, 0); //Thy Hitś decreased by Ɠ.
                backend.updateROMText(0x28, textBoxEE40.Text, 0xAF8E, 0); //A miss! No damage hath been scored!

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

                textBoxEE1.Text = backend.getROMText(0x18, 0xAA9F, 0);
                textBoxEE2.Text = backend.getROMText(0x18, 0xAAB8, 0);
                textBoxEE3.Text = backend.getROMText(0x12, 0xAAD1, 0);
                textBoxEE4.Text = backend.getROMText(0x2D, 0xAAE4, 0);
                textBoxEE5.Text = backend.getROMText(0x21, 0xAB12, 0);
                textBoxEE6.Text = backend.getROMText(0x1A, 0xAB34, 0);
                textBoxEE7.Text = backend.getROMText(0x33, 0xAB4F, 0);
                textBoxEE8.Text = backend.getROMText(0x1B, 0xAB83, 0);
                textBoxEE9.Text = backend.getROMText(0x7B, 0xAB9F, 0);
                textBoxEE10.Text = backend.getROMText(0x29, 0xAC1C, 0);
                textBoxEE11.Text = backend.getROMText(0x13, 0xAC48, 0);
                textBoxEE12.Text = backend.getROMText(0x13, 0xAC5D, 0);
                textBoxEE13.Text = backend.getROMText(0xE, 0xAC72, 0);
                textBoxEE14.Text = backend.getROMText(0xE, 0xAC83, 0);
                textBoxEE15.Text = backend.getROMText(0xE, 0xAC93, 0);
                textBoxEE16.Text = backend.getROMText(0x16, 0xACA4, 0);
                textBoxEE17.Text = backend.getROMText(0x22, 0xACBD, 0);
                textBoxEE18.Text = backend.getROMText(0xA, 0xACE0, 0);
                textBoxEE19.Text = backend.getROMText(0x24, 0xACEB, 0);
                textBoxEE20.Text = backend.getROMText(0x36, 0xAD10, 0);
                textBoxEE21.Text = backend.getROMText(0x8, 0xAD49, 0);
                textBoxEE22.Text = backend.getROMText(0x1E, 0xAD52, 0);
                textBoxEE23.Text = backend.getROMText(0x21, 0xAD73, 0);
                textBoxEE24.Text = backend.getROMText(0x18, 0xAD95, 0);
                textBoxEE25.Text = backend.getROMText(0x1D, 0xADAE, 0);
                textBoxEE26.Text = backend.getROMText(0x20, 0xADCC, 0);
                textBoxEE27.Text = backend.getROMText(0x28, 0xADEF, 0);
                textBoxEE28.Text = backend.getROMText(0x1E, 0xAE19, 0);
                textBoxEE29.Text = backend.getROMText(0x18, 0xAE38, 0);
                textBoxEE30.Text = backend.getROMText(0x51, 0xAE54, 0);
                textBoxEE31.Text = backend.getROMText(0x1E, 0xAEA9, 0);
                textBoxEE32.Text = backend.getROMText(0x35, 0xAEC8, 0);
                textBoxEE33.Text = backend.getROMText(0xE, 0xAEFE, 0);
                textBoxEE34.Text = backend.getROMText(0x16, 0xAF0F, 0);
                textBoxEE35.Text = backend.getROMText(0x19, 0xAF26, 0);
                textBoxEE36.Text = backend.getROMText(0x10, 0xAF40, 0);
                textBoxEE37.Text = backend.getROMText(0x10, 0xAF53, 0);
                textBoxEE38.Text = backend.getROMText(0xE, 0xAF66, 0);
                textBoxEE39.Text = backend.getROMText(0x18, 0xAF75, 0);
                textBoxEE40.Text = backend.getROMText(0x28, 0xAF8E, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxEE1.MaxLength =  0x18;
            textBoxEE2.MaxLength =  0x18;
            textBoxEE3.MaxLength =  0x12;
            textBoxEE4.MaxLength =  0x2D;
            textBoxEE5.MaxLength =  0x21;
            textBoxEE6.MaxLength =  0x1A;
            textBoxEE7.MaxLength =  0x33;
            textBoxEE8.MaxLength =  0x1B;
            textBoxEE9.MaxLength =  0x7B;
            textBoxEE10.MaxLength = 0x29;
            textBoxEE11.MaxLength = 0x13;
            textBoxEE12.MaxLength = 0x13;
            textBoxEE13.MaxLength = 0xE;
            textBoxEE14.MaxLength = 0xE;
            textBoxEE15.MaxLength = 0xE;
            textBoxEE16.MaxLength = 0x16;
            textBoxEE17.MaxLength = 0x22;
            textBoxEE18.MaxLength = 0xA;
            textBoxEE19.MaxLength = 0x24;
            textBoxEE20.MaxLength = 0x36;
            textBoxEE21.MaxLength = 0x8;
            textBoxEE22.MaxLength = 0x1E;
            textBoxEE23.MaxLength = 0x21;
            textBoxEE24.MaxLength = 0x18;
            textBoxEE25.MaxLength = 0x1D;
            textBoxEE26.MaxLength = 0x20;
            textBoxEE27.MaxLength = 0x28;
            textBoxEE28.MaxLength = 0x1E;
            textBoxEE29.MaxLength = 0x18;
            textBoxEE30.MaxLength = 0x51;
            textBoxEE31.MaxLength = 0x1E;
            textBoxEE32.MaxLength = 0x35;
            textBoxEE33.MaxLength = 0xE;
            textBoxEE34.MaxLength = 0x16;
            textBoxEE35.MaxLength = 0x19;
            textBoxEE36.MaxLength = 0x10;
            textBoxEE37.MaxLength = 0x10;
            textBoxEE38.MaxLength = 0xE;
            textBoxEE39.MaxLength = 0x18;
            textBoxEE40.MaxLength = 0x28;
        }
    }
}
