using Minecraft_Recipe_Finder.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Recipe_Finder
{
    public partial class BBlocks : Form
    {
        public BBlocks()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            coarse_dirt coarse_dirt = new coarse_dirt();
            coarse_dirt.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            planks planks = new planks();
            planks.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            wood wood = new wood();
            wood.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            stained_glass stained_glass = new stained_glass();
            stained_glass.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            lapis_block lapis_block = new lapis_block();
            lapis_block.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sandstone sandstone = new sandstone();
            sandstone.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            cut_sandstone cut_sandstone = new cut_sandstone();
            cut_sandstone.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            chiseled_sandstone chiseled_sandstone = new chiseled_sandstone();
            chiseled_sandstone.ShowDialog();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            gold_block gold_block = new gold_block();
            gold_block.ShowDialog();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            iron_block iron_block = new iron_block();
            iron_block.ShowDialog();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            slabs slabs = new slabs();
            slabs.ShowDialog();
        }
    }
}
