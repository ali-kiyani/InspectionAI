using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exhibition
{
    public class MyGroupBox : GroupBox
    {
        public int BORDER_SIZE = 10;
        Color c = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         c, BORDER_SIZE, ButtonBorderStyle.Solid,
                                         c, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         c, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         c, BORDER_SIZE, ButtonBorderStyle.Inset);
        }
    }
}
