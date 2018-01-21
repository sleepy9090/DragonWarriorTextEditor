using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class Form1Main : Form {

        string path;

        public Form1Main() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            disableMenuItems();
        }

        private void buttonOpenRom_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK) {
                path = ofd.FileName;
                textBoxFilename.Text = path;
                
                loadRom();
            }
        }

        private void loadRom() {
            enableMenuItems();
        }

        private void enableMenuItems() {
            toolStripMenuItemSpells.Enabled = true;
            toolStripMenuItemItems.Enabled = true;
            toolStripMenuItemMenus.Enabled = true;
            toolStripMenuItemEquipment.Enabled = true;
            toolStripMenuItemTitles.Enabled = true;
            toolStripMenuItemMonsters.Enabled = true;
            toolStripMenuItemDialog.Enabled = true;
        }

        private void disableMenuItems() {
            toolStripMenuItemSpells.Enabled = false;
            toolStripMenuItemItems.Enabled = false;
            toolStripMenuItemMenus.Enabled = false;
            toolStripMenuItemEquipment.Enabled = false;
            toolStripMenuItemTitles.Enabled = false;
            toolStripMenuItemMonsters.Enabled = false;
            toolStripMenuItemDialog.Enabled = false;
        }

        #region toolstrip menu items
        private void toolStripMenuItemSpells_Click(object sender, EventArgs e) {
            FormSpells formSpells = new FormSpells(path);
            formSpells.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            buttonOpenRom_Click(sender, e);
        }

        private void toolStripMenuItemItems_Click(object sender, EventArgs e) {
            FormItems formItems = new FormItems(path);
            formItems.ShowDialog();
        }

        private void toolStripMenuItemMenus_Click(object sender, EventArgs e) {
            FormMenusAndCommands formMenusAndCommands = new FormMenusAndCommands(path);
            formMenusAndCommands.ShowDialog();
        }

        private void toolStripMenuItemEquipment_Click(object sender, EventArgs e) {
            FormEquipment formEquipment = new FormEquipment(path);
            formEquipment.ShowDialog();
        }

        private void toolStripMenuItemMonsters_Click(object sender, EventArgs e) {
            FormMonsters formMonsters = new FormMonsters(path);
            formMonsters.ShowDialog();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void toolStripMenuItemTitle_Click(object sender, EventArgs e) {
            FormTitleScreens formTitleScreens = new FormTitleScreens(path);
            formTitleScreens.ShowDialog();
        }

        private void toolStripMenuItemDialog1_Click(object sender, EventArgs e)
        {
            FormDialog1 formDialog1 = new FormDialog1(path);
            formDialog1.ShowDialog();
        }

        private void toolStripMenuItemDialog2_Click(object sender, EventArgs e)
        {
            FormDialog2 formDialog2 = new FormDialog2(path);
            formDialog2.ShowDialog();
        }

        private void toolStripMenuItemDialog3_Click(object sender, EventArgs e)
        {
            FormDialog3 formDialog3 = new FormDialog3(path);
            formDialog3.ShowDialog();
        }

        private void toolStripMenuItemDialog4_Click(object sender, EventArgs e)
        {
            FormDialog4 formDialog4 = new FormDialog4(path);
            formDialog4.ShowDialog();
        }

        private void toolStripMenuItemDialog5_Click(object sender, EventArgs e)
        {
            FormDialog5 formDialog5 = new FormDialog5(path);
            formDialog5.ShowDialog();
        }

        private void toolStripMenuItemDialog6_Click(object sender, EventArgs e)
        {
            FormDialog6 formDialog6 = new FormDialog6(path);
            formDialog6.ShowDialog();
        }

        private void toolStripMenuItemDialog7_Click(object sender, EventArgs e)
        {
            FormDialog7 formDialog7 = new FormDialog7(path);
            formDialog7.ShowDialog();
        }

        private void toolStripMenuItemDialog8_Click(object sender, EventArgs e)
        {
            FormDialog8 formDialog8 = new FormDialog8(path);
            formDialog8.ShowDialog();
        }

        private void toolStripMenuItemDialog9_Click(object sender, EventArgs e)
        {
            FormDialog9 formDialog9 = new FormDialog9(path);
            formDialog9.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
