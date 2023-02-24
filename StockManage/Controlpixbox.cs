using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManage
{
    public partial class Controlpixbox : UserControl
    {
        public Controlpixbox()
        {
            InitializeComponent();
        }
        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }
        }
       public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void Controlpixbox_MouseHover(object sender, EventArgs e)
        {
            this.ImageHover = HoverImage;

        }

        private void Controlpixbox_MouseLeave(object sender, EventArgs e)
        {
            this.ImageNormal = NormalImage;
        }
    }
}
