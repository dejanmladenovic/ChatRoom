using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAppForm
{
    public partial class ColorRadioButton : RadioButton
    {
        public ColorRadioButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.AutoSize = false;
            //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle.Location, c1, c2, angle);
            SolidBrush frcolor = new SolidBrush(this.ForeColor);
            Pen p = new Pen(frcolor);
            e.Graphics.DrawRectangle(p, 0, 0, 50, 50);
            //e.Graphics.DrawString(text, this.Font, frcolor, new Point(textX, textY));
            //Rectangle rc = new Rectangle(0, 0, 50, boxsize);
            //ControlPaint.DrawRadioButton(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
            //b.Dispose();
            p.Dispose();
        }
    }
}
