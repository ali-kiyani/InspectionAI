using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exhibition
{
    public class MyGroupBox : GroupBox
    {
        public int BORDER_SIZE = 3;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Gray, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Gray, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Gray, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Gray, BORDER_SIZE, ButtonBorderStyle.Inset);
        }
    }
}
