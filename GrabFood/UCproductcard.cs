using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GrabFood
{
    public partial class UCproductcard : UserControl
    {
        public UCproductcard()
        {
            InitializeComponent();
            RoundControls();
        }

        private void UCproductcard_Load(object sender, EventArgs e)
        {
            productImage.Image = Image.FromFile("chickenjoy.jpg");
        }

        private void RoundControls()
        {
            MakeRounded(cardPanel, 18);
            MakeRounded(btnAddBasket, 8);
        }

        private void MakeRounded(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }
    }
}