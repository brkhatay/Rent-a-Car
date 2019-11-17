using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace panel
{
    [DefaultEvent("Click")]

    public partial class cutomButton : UserControl
    {
        int wh = 20;
        Color Cone = Color.Purple;
        Color Ctwo = Color.Pink;
        float ang = 45;
        Timer t = new Timer();
        bool anim = false;

        string txt = "";
        public cutomButton()
        {
            DoubleBuffered = true;
            ForeColor = Color.White;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { ang = ang % 360 + 1; };

            if (anim == true)
            {

            }


        }

        public Color c0 { get {return Cone; } set {Cone = value; Invalidate(); } }
        public Color c1 { get {return Ctwo; } set {Ctwo = value; Invalidate(); } }

        public string text { get { return txt; } set { txt = value; Invalidate(); } }

        public int borderRadius { get { return wh; } set { wh = value; Invalidate(); } }
        public float Angle { get { return ang; } set { ang = value; Invalidate(); } }

        public bool Anim { get {return anim; } set { anim = value; Invalidate(); } }
        protected override void OnPaint (PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width-wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width-wh, Height - wh, wh, wh ), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            //e.Graphics.FillPath(new SolidBrush(Color.Teal), gp); // solid color
            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, c0,c1,ang), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
            

        }

    }
}
