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
    public partial class FormItems : Form {

        string path = "";

        public FormItems(string romPath) {
            InitializeComponent();
            path = romPath;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend(path);

                backend.updateROMText(0x4, textBoxWN1.Text, 0x7B38, 0); //Herb
                backend.updateROMText(0x5, textBoxWN2.Text, 0x7B3D, 0); //Torch
                backend.updateROMText(0x8, textBoxWN3.Text, 0x7B43, 0); //Dragon's
                backend.updateROMText(0x5, textBoxWN4.Text, 0x7B4C, 0); //Wings
                backend.updateROMText(0x5, textBoxWN5.Text, 0x7B52, 0); //Magic
                backend.updateROMText(0x5, textBoxWN6.Text, 0x7B58, 0); //Fairy
                backend.updateROMText(0x7, textBoxWN7.Text, 0x7B5E, 0); //Ball of
                backend.updateROMText(0x6, textBoxWN8.Text, 0x7B66, 0); //Tablet
                backend.updateROMText(0x5, textBoxWN9.Text, 0x7B6D, 0); //Fairy
                backend.updateROMText(0x6, textBoxWN10.Text, 0x7B73, 0); //Silver
                backend.updateROMText(0x8, textBoxWN11.Text, 0x7B7A, 0); //Staff of
                backend.updateROMText(0x9, textBoxWN12.Text, 0x7B83, 0); //Stones of
                backend.updateROMText(0x9, textBoxWN13.Text, 0x7B8D, 0); //Gwaelin's
                backend.updateROMText(0x7, textBoxWN14.Text, 0x7B97, 0); //Rainbow
                backend.updateROMText(0x6, textBoxWN15.Text, 0x7B9F, 0); //Cursed
                backend.updateROMText(0x5, textBoxWN16.Text, 0x7BA6, 0); //Death
                backend.updateROMText(0x9, textBoxWN17.Text, 0x7BAC, 0); //Fighter's
                backend.updateROMText(0x9, textBoxWN18.Text, 0x7BB6, 0); //Erdrick's
                backend.updateROMText(0x5, textBoxWN19.Text, 0x7C24, 0); //Scale
                backend.updateROMText(0x3, textBoxWN20.Text, 0x7C2B, 0); //Key
                backend.updateROMText(0x5, textBoxWN21.Text, 0x7C3C, 0); //Flute
                backend.updateROMText(0x5, textBoxWN22.Text, 0x7C35, 0); //Light
                backend.updateROMText(0x4, textBoxWN23.Text, 0x7C42, 0); //Harp
                backend.updateROMText(0x4, textBoxWN24.Text, 0x7C47, 0); //Rain
                backend.updateROMText(0x8, textBoxWN25.Text, 0x7C4C, 0); //Sunlight
                backend.updateROMText(0x4, textBoxWN26.Text, 0x7C55, 0); //Love
                backend.updateROMText(0x4, textBoxWN27.Text, 0x7C5A, 0); //Drop
                backend.updateROMText(0x4, textBoxWN28.Text, 0x7C5F, 0); //Belt
                backend.updateROMText(0x8, textBoxWN29.Text, 0x7C64, 0); //Necklace
                backend.updateROMText(0x5, textBoxWN30.Text, 0x7C72, 0); //Token
                backend.updateROMText(0x4, textBoxWN31.Text, 0x7C6D, 0); //Ring
                backend.updateROMText(0x5, textBoxWN32.Text, 0x7C2F, 0); //Water

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormItems_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend(path);

                textBoxWN1.Text = backend.getROMText(0x4, 0x7B38, 0);
                textBoxWN2.Text = backend.getROMText(0x5, 0x7B3D, 0);
                textBoxWN3.Text = backend.getROMText(0x8, 0x7B43, 0);
                textBoxWN4.Text = backend.getROMText(0x5, 0x7B4C, 0);
                textBoxWN5.Text = backend.getROMText(0x5, 0x7B52, 0);
                textBoxWN6.Text = backend.getROMText(0x5, 0x7B58, 0);
                textBoxWN7.Text = backend.getROMText(0x7, 0x7B5E, 0);
                textBoxWN8.Text = backend.getROMText(0x6, 0x7B66, 0);
                textBoxWN9.Text = backend.getROMText(0x5, 0x7B6D, 0);
                textBoxWN10.Text = backend.getROMText(0x6, 0x7B73, 0);
                textBoxWN11.Text = backend.getROMText(0x8, 0x7B7A, 0);
                textBoxWN12.Text = backend.getROMText(0x9, 0x7B83, 0);
                textBoxWN13.Text = backend.getROMText(0x9, 0x7B8D, 0);
                textBoxWN14.Text = backend.getROMText(0x7, 0x7B97, 0);
                textBoxWN15.Text = backend.getROMText(0x6, 0x7B9F, 0);
                textBoxWN16.Text = backend.getROMText(0x5, 0x7BA6, 0);
                textBoxWN17.Text = backend.getROMText(0x9, 0x7BAC, 0);
                textBoxWN18.Text = backend.getROMText(0x9, 0x7BB6, 0);
                textBoxWN19.Text = backend.getROMText(0x5, 0x7C24, 0);
                textBoxWN20.Text = backend.getROMText(0x3, 0x7C2B, 0);
                textBoxWN21.Text = backend.getROMText(0x5, 0x7C3C, 0);
                textBoxWN22.Text = backend.getROMText(0x5, 0x7C35, 0);
                textBoxWN23.Text = backend.getROMText(0x4, 0x7C42, 0);
                textBoxWN24.Text = backend.getROMText(0x4, 0x7C47, 0);
                textBoxWN25.Text = backend.getROMText(0x8, 0x7C4C, 0);
                textBoxWN26.Text = backend.getROMText(0x4, 0x7C55, 0);
                textBoxWN27.Text = backend.getROMText(0x4, 0x7C5A, 0);
                textBoxWN28.Text = backend.getROMText(0x4, 0x7C5F, 0);
                textBoxWN29.Text = backend.getROMText(0x8, 0x7C64, 0);
                textBoxWN30.Text = backend.getROMText(0x5, 0x7C72, 0);
                textBoxWN31.Text = backend.getROMText(0x4, 0x7C6D, 0);
                textBoxWN32.Text = backend.getROMText(0x5, 0x7C2F, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxWN1.MaxLength =  0x4;
            textBoxWN2.MaxLength =  0x5;
            textBoxWN3.MaxLength =  0x8;
            textBoxWN4.MaxLength =  0x5;
            textBoxWN5.MaxLength =  0x5;
            textBoxWN6.MaxLength =  0x5;
            textBoxWN7.MaxLength =  0x7;
            textBoxWN8.MaxLength =  0x6;
            textBoxWN9.MaxLength =  0x5;
            textBoxWN10.MaxLength = 0x6;
            textBoxWN11.MaxLength = 0x8;
            textBoxWN12.MaxLength = 0x9;
            textBoxWN13.MaxLength = 0x9;
            textBoxWN14.MaxLength = 0x7;
            textBoxWN15.MaxLength = 0x6;
            textBoxWN16.MaxLength = 0x5;
            textBoxWN17.MaxLength = 0x9;
            textBoxWN18.MaxLength = 0x9;
            textBoxWN19.MaxLength = 0x5;
            textBoxWN20.MaxLength = 0x3;
            textBoxWN21.MaxLength = 0x5;
            textBoxWN22.MaxLength = 0x5;
            textBoxWN23.MaxLength = 0x4;
            textBoxWN24.MaxLength = 0x4;
            textBoxWN25.MaxLength = 0x8;
            textBoxWN26.MaxLength = 0x4;
            textBoxWN27.MaxLength = 0x4;
            textBoxWN28.MaxLength = 0x4;
            textBoxWN29.MaxLength = 0x8;
            textBoxWN30.MaxLength = 0x5;
            textBoxWN31.MaxLength = 0x4;
            textBoxWN32.MaxLength = 0x5;

        }
    }
}
