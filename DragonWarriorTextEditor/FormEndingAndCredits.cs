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
    public partial class FormEndingAndCredits : Form
    {

        string path = "";

        public FormEndingAndCredits(string romPath)
        {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                Backend backend = new Backend(path);
                backend.updateROMText(0x10, textBox1.Text, 0x549F, 2); //CONGRATULATIONS!
                backend.updateROMText(0x12, textBox2.Text, 0x54B2, 2); //THOU HAST RESTORED
                backend.updateROMText(0x16, textBox3.Text, 0x54C7, 2); //PEACE UNTO THE WORLD!
                backend.updateROMText(0x18, textBox4.Text, 0x54DF, 2); //BUT THERE ARE MANY ROADS
                backend.updateROMText(0xE, textBox5.Text, 0x54FA, 2); //YET TO TRAVEL.
                backend.updateROMText(0xD, textBox6.Text, 0x550B, 2); //MAY THE LIGHT 
                backend.updateROMText(0x10, textBox7.Text, 0x551B, 2); //SHINE UPON THEE.
                backend.updateROMText(0xE, textBox8.Text, 0x552E, 2); //DRAGON WARRIOR
                backend.updateROMText(0x5, textBox9.Text, 0x553F, 2); //STAFF
                backend.updateROMText(0x13, textBox10.Text, 0x554D, 2); //SCENARIO WRITTEN BY
                backend.updateROMText(0xA, textBox11.Text, 0x5563, 2); //YUJI HORII
                backend.updateROMText(0x15, textBox12.Text, 0x5576, 2); //CHARACTER DESIGNED BY
                backend.updateROMText(0xE, textBox13.Text, 0x558E, 2); //AKIRA TORIYAMA
                backend.updateROMText(0x11, textBox14.Text, 0x55A5, 2); //MUSIC COMPOSED BY
                backend.updateROMText(0xF, textBox15.Text, 0x55B9, 2); //KOICHI SUGIYAMA
                backend.updateROMText(0xC, textBox16.Text, 0x55D1, 2); //PROGRAMED BY
                backend.updateROMText(0xF, textBox17.Text, 0x55E0, 2); //KOICHI NAKAMURA
                backend.updateROMText(0xC, textBox18.Text, 0x55F2, 2); //KOJI YOSHIDA
                backend.updateROMText(0x11, textBox19.Text, 0x5601, 2); //TAKENORI YAMAMORI
                backend.updateROMText(0xB, textBox20.Text, 0x5621, 2); //DESIGNED BY
                backend.updateROMText(0xE, textBox21.Text, 0x562F, 2); //TAKASHI YASUNO
                backend.updateROMText(0x14, textBox22.Text, 0x5646, 2); //SCENARIO ASSISTED BY
                backend.updateROMText(0xF, textBox23.Text, 0x565D, 2); //HIROSHI MIYAOKA
                backend.updateROMText(0xB, textBox24.Text, 0x5675, 2); //ASSISTED BY
                backend.updateROMText(0xB, textBox25.Text, 0x5683, 2); //RIKA SUZUKIE
                backend.updateROMText(0x10, textBox26.Text, 0x5691, 2); //TADASHI FUKUZAWA
                backend.updateROMText(0x11, textBox27.Text, 0x56AD, 2); //SPECIAL THANKS TO
                backend.updateROMText(0x11, textBox28.Text, 0x56C1, 2); //KAZUHIKO TORISHIMA
                backend.updateROMText(0xB, textBox29.Text, 0x56DC, 2); //TRANSLATION
                backend.updateROMText(0x5, textBox30.Text, 0x56EA, 2); //STAFF
                backend.updateROMText(0xD, textBox31.Text, 0x56F8, 2); //TRANSLATED BY
                backend.updateROMText(0xC, textBox32.Text, 0x5708, 2); //TOSHIKO WATSON
                backend.updateROMText(0xF, textBox33.Text, 0x5719, 2); //REVISED TEXT BY
                backend.updateROMText(0xD, textBox34.Text, 0x572B, 2); //SCOTT PELLAND
                backend.updateROMText(0x14, textBox35.Text, 0x573B, 2); //TECHNICAL SUPPORT BY
                backend.updateROMText(0xA, textBox36.Text, 0x5752, 2); //DOUG BAKER
                backend.updateROMText(0xC, textBox37.Text, 0x576E, 2); //PROGRAMED BY
                backend.updateROMText(0xE, textBox38.Text, 0x577D, 2); //KENICHI MASUTAG
                backend.updateROMText(0xD, textBox39.Text, 0x578E, 2); //MANABU YAMANA
                backend.updateROMText(0xB, textBox40.Text, 0x57AA, 2); //DESIGNED BY
                backend.updateROMText(0xE, textBox41.Text, 0x57B8, 2); //SATOSHI FUDABA
                backend.updateROMText(0x11, textBox42.Text, 0x57C9, 2); //SPECIAL THANKS TO
                backend.updateROMText(0xF, textBox43.Text, 0x57DD, 2); //HOWARD PHILLIPS
                backend.updateROMText(0xB, textBox44.Text, 0x57FB, 2); //DIRECTED BY
                backend.updateROMText(0xF, textBox45.Text, 0x5809, 2); //KOICHI NAKAMURA
                backend.updateROMText(0xB, textBox46.Text, 0x5821, 2); //PRODUCED BY
                backend.updateROMText(0xE, textBox47.Text, 0x582F, 2); //YUKINOBU CHIDA
                backend.updateROMText(0x15, textBox48.Text, 0x5846, 2); //BASED ON DRAGON QUEST
                backend.updateROMText(0x9, textBox49.Text, 0x585E, 2); //COPYRIGHT
                backend.updateROMText(0xD, textBox50.Text, 0x586A, 2); //ARMOR PROJECT
                backend.updateROMText(0x9, textBox51.Text, 0x587A, 2); //1986 1989
                backend.updateROMText(0xB, textBox52.Text, 0x5886, 2); //BIRD STUDIO
                backend.updateROMText(0x9, textBox53.Text, 0x5894, 2); //1986 1989
                backend.updateROMText(0xF, textBox54.Text, 0x58A0, 2); //KOICHI SUGIYAMA
                backend.updateROMText(0x9, textBox55.Text, 0x58B2, 2); //1986 1989
                backend.updateROMText(0x9, textBox56.Text, 0x58BE, 2); //     SOFT
                backend.updateROMText(0x9, textBox57.Text, 0x58CA, 2); //1986 1989
                backend.updateROMText(0x4, textBox58.Text, 0x58D6, 2); //ENIX
                backend.updateROMText(0x9, textBox59.Text, 0x58DD, 2); //1986 1989

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);
                textBox1.Text = backend.getROMText(0x10, 0x549F, 2);
                textBox2.Text = backend.getROMText(0x12, 0x54B2, 2);
                textBox3.Text = backend.getROMText(0x16, 0x54C7, 2);
                textBox4.Text = backend.getROMText(0x18, 0x54DF, 2);
                textBox5.Text = backend.getROMText(0xE, 0x54FA, 2);
                textBox6.Text = backend.getROMText(0xD, 0x550B, 2);
                textBox7.Text = backend.getROMText(0x10, 0x551B, 2);
                textBox8.Text = backend.getROMText(0xE, 0x552E, 2);
                textBox9.Text = backend.getROMText(0x5, 0x553F, 2);
                textBox10.Text = backend.getROMText(0x13, 0x554D, 2);
                textBox11.Text = backend.getROMText(0xA, 0x5563, 2);
                textBox12.Text = backend.getROMText(0x15, 0x5576, 2);
                textBox13.Text = backend.getROMText(0xE, 0x558E, 2);
                textBox14.Text = backend.getROMText(0x11, 0x55A5, 2);
                textBox15.Text = backend.getROMText(0xF, 0x55B9, 2);
                textBox16.Text = backend.getROMText(0xC, 0x55D1, 2);
                textBox17.Text = backend.getROMText(0xF, 0x55E0, 2);
                textBox18.Text = backend.getROMText(0xC, 0x55F2, 2);
                textBox19.Text = backend.getROMText(0x11, 0x5601, 2);
                textBox20.Text = backend.getROMText(0xB, 0x5621, 2);
                textBox21.Text = backend.getROMText(0xE, 0x562F, 2);
                textBox22.Text = backend.getROMText(0x14, 0x5646, 2);
                textBox23.Text = backend.getROMText(0xF, 0x565D, 2);
                textBox24.Text = backend.getROMText(0xB, 0x5675, 2);
                textBox25.Text = backend.getROMText(0xB, 0x5683, 2);
                textBox26.Text = backend.getROMText(0x10, 0x5691, 2);
                textBox27.Text = backend.getROMText(0x11, 0x56AD, 2);
                textBox28.Text = backend.getROMText(0x11, 0x56C1, 2);
                textBox29.Text = backend.getROMText(0xB, 0x56DC, 2);
                textBox30.Text = backend.getROMText(0x5, 0x56EA, 2);
                textBox31.Text = backend.getROMText(0xD, 0x56F8, 2);
                textBox32.Text = backend.getROMText(0xC, 0x5708, 2);
                textBox33.Text = backend.getROMText(0xF, 0x5719, 2);
                textBox34.Text = backend.getROMText(0xD, 0x572B, 2);
                textBox35.Text = backend.getROMText(0x14, 0x573B, 2);
                textBox36.Text = backend.getROMText(0xA, 0x5752, 2);
                textBox37.Text = backend.getROMText(0xC, 0x576E, 2);
                textBox38.Text = backend.getROMText(0xE, 0x577D, 2);
                textBox39.Text = backend.getROMText(0xD, 0x578E, 2);
                textBox40.Text = backend.getROMText(0xB, 0x57AA, 2);
                textBox41.Text = backend.getROMText(0xE, 0x57B8, 2);
                textBox42.Text = backend.getROMText(0x11, 0x57C9, 2);
                textBox43.Text = backend.getROMText(0xF, 0x57DD, 2);
                textBox44.Text = backend.getROMText(0xB, 0x57FB, 2);
                textBox45.Text = backend.getROMText(0xF, 0x5809, 2);
                textBox46.Text = backend.getROMText(0xB, 0x5821, 2);
                textBox47.Text = backend.getROMText(0xE, 0x582F, 2);
                textBox48.Text = backend.getROMText(0x15, 0x5846, 2);
                textBox49.Text = backend.getROMText(0x9, 0x585E, 2);
                textBox50.Text = backend.getROMText(0xD, 0x586A, 2);
                textBox51.Text = backend.getROMText(0x9, 0x587A, 2);
                textBox52.Text = backend.getROMText(0xB, 0x5886, 2);
                textBox53.Text = backend.getROMText(0x9, 0x5894, 2);
                textBox54.Text = backend.getROMText(0xF, 0x58A0, 2);
                textBox55.Text = backend.getROMText(0x9, 0x58B2, 2);
                textBox56.Text = backend.getROMText(0x9, 0x58BE, 2);
                textBox57.Text = backend.getROMText(0x9, 0x58CA, 2);
                textBox58.Text = backend.getROMText(0x4, 0x58D6, 2);
                textBox59.Text = backend.getROMText(0x9, 0x58DD, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBox1.MaxLength = 0x10;
            textBox2.MaxLength = 0x12;
            textBox3.MaxLength = 0x16;
            textBox4.MaxLength = 0x18;
            textBox5.MaxLength = 0xE;
            textBox6.MaxLength = 0xD;
            textBox7.MaxLength = 0x10;
            textBox8.MaxLength = 0xE;
            textBox9.MaxLength = 0x5;
            textBox10.MaxLength = 0x13;
            textBox11.MaxLength = 0xA;
            textBox12.MaxLength = 0x15;
            textBox13.MaxLength = 0xE;
            textBox14.MaxLength = 0x11;
            textBox15.MaxLength = 0xF;
            textBox16.MaxLength = 0xC;
            textBox17.MaxLength = 0xF;
            textBox18.MaxLength = 0xC;
            textBox19.MaxLength = 0x11;
            textBox20.MaxLength = 0xB;
            textBox21.MaxLength = 0xE;
            textBox22.MaxLength = 0x14;
            textBox23.MaxLength = 0xF;
            textBox24.MaxLength = 0xB;
            textBox25.MaxLength = 0xB;
            textBox26.MaxLength = 0x10;
            textBox27.MaxLength = 0x11;
            textBox28.MaxLength = 0x11;
            textBox29.MaxLength = 0xB;
            textBox30.MaxLength = 0x5;
            textBox31.MaxLength = 0xD;
            textBox32.MaxLength = 0xC;
            textBox33.MaxLength = 0xF;
            textBox34.MaxLength = 0xD;
            textBox35.MaxLength = 0x14;
            textBox36.MaxLength = 0xA;
            textBox37.MaxLength = 0xC;
            textBox38.MaxLength = 0xE;
            textBox39.MaxLength = 0xD;
            textBox40.MaxLength = 0xB;
            textBox41.MaxLength = 0xE;
            textBox42.MaxLength = 0x11;
            textBox43.MaxLength = 0xF;
            textBox44.MaxLength = 0xB;
            textBox45.MaxLength = 0xF;
            textBox46.MaxLength = 0xB;
            textBox47.MaxLength = 0xE;
            textBox48.MaxLength = 0x15;
            textBox49.MaxLength = 0x9;
            textBox50.MaxLength = 0xD;
            textBox51.MaxLength = 0x9;
            textBox52.MaxLength = 0xB;
            textBox53.MaxLength = 0x9;
            textBox54.MaxLength = 0xF;
            textBox55.MaxLength = 0x9;
            textBox56.MaxLength = 0x9;
            textBox57.MaxLength = 0x9;
            textBox58.MaxLength = 0x4;
            textBox59.MaxLength = 0x9;
        }

        private void FormEndingAndCredits_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }
    }
}
