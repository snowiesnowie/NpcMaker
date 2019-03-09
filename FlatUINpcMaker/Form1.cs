using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatUINpcMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/i6qPk0Yt").Contains("1.0"))
            {
                if (MessageBox.Show("Looks like there is another version, would you like to download it", "NPC Maker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Process.Start("https://discord.gg/9CfgyNv");
            }
            else
            {
                MessageBox.Show("You are on the correct version", "NPC Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatLabel20_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatLabel21_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Yellow);
            formSkin1.Refresh();
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Red);
            formSkin1.Refresh();
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Green);
            formSkin1.Refresh();
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.White);
            formSkin1.Refresh();
        }

        private void flatButton11_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Black);
            formSkin1.Refresh();
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Lime);
            formSkin1.Refresh();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Pink);
            formSkin1.Refresh();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Blue);
            formSkin1.Refresh();
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Aqua);
            formSkin1.Refresh();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Purple);
            formSkin1.Refresh();
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Gold);
            formSkin1.Refresh();
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Violet);
            formSkin1.Refresh();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel22_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skincolortext.Text = "#D2B48C";
        }

        private void Skincolortext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Haircolortext.Text = "#faf0be";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Haircolortext.Text = "#B7A69E";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton15_Click(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            StreamWriter creater = new StreamWriter("English.DAT");
            creater.WriteLine("Name " + nameineditor.Text);

            if (Common.Checked)
                creater.WriteLine("Character <color=Common>" + nameingame.Text + "</color>");

            if (Uncommon.Checked)
                creater.WriteLine("Character <color=Uncommon>" + nameingame.Text + "</color>");

            if (Rare.Checked)
                creater.WriteLine("Character <color=Rare>" + nameingame.Text + "</color>");

            if (Epic.Checked)
                creater.WriteLine("Character <color=Epic>" + nameingame.Text + "</color>");

            if (Legendary.Checked)
                creater.WriteLine("Character <color=Legendary>" + nameingame.Text + "</color>");

            if (mYTHICAL.Checked)
                creater.WriteLine("Character <color=Mythical>" + nameingame.Text + "</color>");
            creater.Close();
        }

        private void Legendary_CheckedChanged(object sender)
        {

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            StreamWriter creater = new StreamWriter("Asset.DAT");

            creater.WriteLine("Type NPC");
            creater.WriteLine("ID " + NPCID.Text);
            creater.WriteLine("Dialogue " + DialogueID.Text);
            creater.WriteLine("");
            creater.WriteLine("Shirt " + Shirt.Text);
            creater.WriteLine("Pants " + Pants.Text);
            creater.WriteLine("Hat " + Hat.Text);
            creater.WriteLine("Vest " + Vest.Text);
            creater.WriteLine("Mask " + Mask.Text);
            creater.WriteLine("Backpack " + Backpack.Text);
            creater.WriteLine("Glasses " + Glasses.Text);
            creater.WriteLine("");
            creater.WriteLine("Face " + Face.Text);
            creater.WriteLine("Beard " + Beard.Text);
            creater.WriteLine("Hair " + Hair.Text);
            creater.WriteLine("");
            creater.WriteLine("Color_Skin " + Skincolortext.Text);
            creater.WriteLine("Color_Hair " + Haircolortext.Text);
            creater.WriteLine("");
            creater.WriteLine("Primary " + Primary.Text);
            creater.WriteLine("Secondary " + Secondary.Text);
            creater.WriteLine("Tertiary " + Tertiary.Text);            
            creater.WriteLine("");
            if (Equipped.Text.Contains(" "))
                {
                creater.WriteLine("");
            }
            else
            {
                creater.WriteLine("Equipped " + Equipped.Text);
            }
            creater.Close();
        }

        private void flatLabel16_Click(object sender, EventArgs e)
        {

        }
            
        private void flatButton15_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/9CfgyNv");
        }
    }
}
