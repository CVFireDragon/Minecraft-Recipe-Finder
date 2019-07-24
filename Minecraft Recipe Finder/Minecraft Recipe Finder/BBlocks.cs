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
    }
}
