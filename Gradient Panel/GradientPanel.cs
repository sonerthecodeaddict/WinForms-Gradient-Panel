using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;



namespace Gradient_Panel
{
    public class GradientPanel : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }


        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.gradientTop, this.gradientBottom, 80F);
            Graphics g = e.Graphics;
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);
        }

    }
}
