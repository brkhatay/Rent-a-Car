using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace rentAcar
{
    class curvesGpanel : Panel
    {
        int wh = 20;
        Color Cone = Color.Purple;
        Color Ctwo = Color.Pink;
        float ang = 45;

        public Color ColorTop { get { return Cone; } set { Cone = value; Invalidate(); } }
        public Color ColorBottom { get { return Ctwo; } set { Ctwo = value; Invalidate(); } }
        public int borderRadius { get { return wh; } set { wh = value; Invalidate(); } }

        public float  Angle { get { return ang; } set { ang = value; Invalidate(); } }

        public curvesGpanel()
        {
          DoubleBuffered = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, ang), gp);


            base.OnPaint(e);
        }
    }
}
