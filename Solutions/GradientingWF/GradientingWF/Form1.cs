using System.Drawing.Drawing2D;

namespace GradientingWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class GradientLabel : Control
        {
            private System.Windows.Forms.Timer _timer;
            private float _gradientOffset = 0;

            public GradientLabel()
            {
                DoubleBuffered = true;
                _timer = new System.Windows.Forms.Timer();
                _timer.Interval = 16; // ~60fps
                _timer.Tick += (s, e) =>
                {
                    _gradientOffset += 2; // Speed, larger = faster
                    Invalidate();
                };

                _timer.Start();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                int gradientSpan = Width * 1; // Size

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(0, 0, gradientSpan, Height),
                    Color.Red, Color.Blue,
                    LinearGradientMode.Horizontal))
                {
                    ColorBlend blend = new ColorBlend
                    {
                        Positions = new[] { 0f, 0.25f, 0.5f, 0.75f, 1f },
                        //Colors = new[] { Color.Red, Color.Purple, Color.Blue, Color.Purple, Color.Red }
                        Colors = new[] { Color.Purple, Color.DarkMagenta, Color.Magenta, Color.DarkMagenta, Color.Purple }
                    };

                    brush.InterpolationColors = blend;
                    brush.WrapMode = WrapMode.TileFlipX;

                    float offset = _gradientOffset % gradientSpan;
                    brush.TranslateTransform(-offset, 0);

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddString(this.Text, this.Font.FontFamily, (int)this.Font.Style,
                            this.Font.Height, this.ClientRectangle, StringFormat.GenericDefault);
                        e.Graphics.FillPath(brush, path);
                    }
                }
            }

        }


        private void spawnBtn_Click(object sender, EventArgs e)
        {
            GradientLabel label = new GradientLabel
            {
                Text = "Animated",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Size = new Size(150, 50),
                Location = new Point(10, 10)
            };
            panel1.Controls.Add(label);
        }
    }
}
