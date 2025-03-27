using System;
using System.Drawing;
using System.Windows.Forms;

namespace HorlogeForm
{
    public class Horloge : Control
    {
        private Aiguille heureAiguille;
        private Aiguille minuteAiguille;
        private Aiguille secondeAiguille;
        private Cadran cadran;
        private Timer timer;
        private BufferedGraphics buffer;

        public Horloge()
        {
            this.DoubleBuffered = true;
            this.heureAiguille = new Aiguille(0, Color.Red, 4);
            this.minuteAiguille = new Aiguille(0, Color.Blue, 3);
            this.secondeAiguille = new Aiguille(0, Color.Green, 1);
            this.cadran = new Cadran(0, Color.Green);


            this.timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => this.Invalidate();
            timer.Start();

            BufferedGraphicsContext context = BufferedGraphicsManager.Current;
            buffer = context.Allocate(this.CreateGraphics(), this.ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = buffer.Graphics;
            g.Clear(this.BackColor);

            int rayon = Math.Min(this.Width, this.Height) / 2 - 10;

            Point centre = new Point(this.Width / 2, this.Height / 2);

            cadran.Rayon = rayon;
            heureAiguille.Longueur = rayon * 0.5f;
            minuteAiguille.Longueur = rayon * 0.7f;
            secondeAiguille.Longueur = rayon * 0.9f;

            cadran.Dessiner(g, centre);

            DateTime now = DateTime.Now;
            float heureAngle = (now.Hour % 12) * 30 + now.Minute * 0.5f;
            float minuteAngle = now.Minute * 6;
            float secondeAngle = now.Second * 6;

            heureAiguille.Dessiner(g, centre, -heureAngle + 90);
            minuteAiguille.Dessiner(g, centre, -minuteAngle + 90);
            secondeAiguille.Dessiner(g, centre, -secondeAngle + 90);

            buffer.Render(e.Graphics);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (buffer != null)
            {
                buffer.Dispose();
                BufferedGraphicsContext context = BufferedGraphicsManager.Current;
                buffer = context.Allocate(this.CreateGraphics(), this.ClientRectangle);
            }

            this.Invalidate();
        }
    }

}
