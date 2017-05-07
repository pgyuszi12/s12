using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solitaire
{
    public partial class Form1 : Form
    {
        List<PictureBox> CardPictures = new List<PictureBox>();
        BoardController boardController;

        public Form1()
        {
            InitializeComponent();
            boardController = new BoardController();
        }
        /*
        private void GeneratePictureBoxes()
        {
            for(int i = 0; i < cards.Count; i++) { 
                PictureBox pb = new System.Windows.Forms.PictureBox();
                pb.Parent = this;
                pb.Top = i*110;
                pb.Image = Properties.Resources.ace_of_clubs;
                pb.Visible = true;
                pb.Width = 50;
                pb.Height = 100;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Refresh();
            }
            this.Refresh();
        }*/
     /*
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pbox = (PictureBox)sender;
            pbox.Parent = column1_Panel;
            pbox.Top = 75;
            column1_Panel.Controls.SetChildIndex(pbox, 0);
        }
        */
    }
}
