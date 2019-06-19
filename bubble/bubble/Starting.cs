using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble
{
    public partial class Starting : Form
    {
        public static int level = 0;
        public Starting()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InGame newForm = new InGame();
            this.Visible = false;
            level = 1;
            newForm.ShowDialog();
            this.Close();
        }

        private void btnControles_Click(object sender, EventArgs e)
        {
            btnControles.Visible = false;
            btnExit.Visible = false;
            btnNewGame.Visible = false;
            btnBack.Visible = true;
            lbLeft.Visible = true;
            lbRight.Visible = true;
            lbShoot.Visible = true;
            imgLevo.Visible = true;
            imgDesno.Visible = true;
            imgGore.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnControles.Visible = true;
            btnExit.Visible = true;
            btnNewGame.Visible = true;
            btnBack.Visible = false;
            lbLeft.Visible = false;
            lbRight.Visible = false;
            lbShoot.Visible = false;
            imgLevo.Visible = false;
            imgDesno.Visible = false;
            imgGore.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
                this.Close();
        }
    }
}
