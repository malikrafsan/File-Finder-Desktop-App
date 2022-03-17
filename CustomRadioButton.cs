using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FolderCrawler
{
    class CustomRadioButton: RadioButton
    {
        private Color checkColor = Color.MediumSlateBlue;
        private Color unCheckColor = Color.Gray;

        public Color CheckColor
        {
            get
            {
                return checkColor;
            }

            set
            {
                checkColor = value;
                this.Invalidate();
            }
        }

        public Color UnCheckColor
        {
            get
            {
                return unCheckColor;
            }

            set
            {
                unCheckColor = value;
                this.Invalidate();
            }
        }

        public CustomRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2),
                Y = (this.Height - rbCheckSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(this.checkColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(this.checkColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                g.Clear(this.BackColor);
                if (this.Checked)
                {
                    g.DrawEllipse(penBorder, rectRbBorder);
                    g.FillEllipse(brushRbCheck, rectRbCheck);
                }
                else
                {
                    penBorder.Color = unCheckColor;
                    g.DrawEllipse(penBorder, rectRbBorder);
                }

                g.DrawString(this.Text, this.Font, brushText,
                    rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }
    }
}
