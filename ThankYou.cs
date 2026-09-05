using System.Drawing;
using System.Windows.Forms;

namespace CursedPopupGame
{
    public class ThankYou : Form
    {
        public ThankYou()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 250);
            this.Text = "THANK YOU";

            this.BackgroundImage = Properties.Resources.static_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Label msg = new Label();
            msg.Text = "THANK YOU";
            msg.Font = new Font("Arial", 48, FontStyle.Bold);
            msg.ForeColor = Color.White;
            msg.Dock = DockStyle.Top;
            msg.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(msg);

            PictureBox thumb = new PictureBox();
            thumb.Image = Properties.Resources.thumbsup;
            thumb.SizeMode = PictureBoxSizeMode.Zoom;
            thumb.Dock = DockStyle.Bottom;
            thumb.Height = 120;
            this.Controls.Add(thumb);
        }
    }
}
