using System;
using System.Drawing;

namespace HorlogeForm
{
    public class Cadran
    {
        public int Rayon { get; set; }
        public Color Couleur { get; set; }

        public Cadran(int rayon, Color couleur)
        {
            Rayon = rayon;
            Couleur = couleur;
        }

        public void Dessiner(Graphics g, Point centre)
        {
            using (Pen pen = new Pen(Couleur, 2))
            {
                g.DrawEllipse(pen, centre.X - Rayon, centre.Y - Rayon, Rayon * 2, Rayon * 2);

                for (int i = 0; i < 12; i++)
                {
                    float angle = i * 30;
                    double radian = angle * Math.PI / 180;

                    float xStart = centre.X + (float)((Rayon - 15) * Math.Cos(radian));
                    float yStart = centre.Y - (float)((Rayon - 15) * Math.Sin(radian));
                    float xEnd = centre.X + (float)(Rayon * Math.Cos(radian));
                    float yEnd = centre.Y - (float)(Rayon * Math.Sin(radian));

                    g.DrawLine(pen, new PointF(xStart, yStart), new PointF(xEnd, yEnd));
                }
            }
        }
    }

}
