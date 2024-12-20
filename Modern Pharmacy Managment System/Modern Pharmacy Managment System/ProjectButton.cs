using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class ProjectButton : PictureBox
    {
        public ProjectButton()
        {
            InitializeComponent();
        }

        private void ProjectButton_Load(object sender, EventArgs e)
        {

        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get
            {
                return NormalImage;
            }
            set
            {
                NormalImage = value;
            }
        }
        public Image ImageHover
        {
            get
            {
                return HoverImage;
            }
            set
            {
                HoverImage = value;
            }
        }

        private void ProjectButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void ProjectButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
