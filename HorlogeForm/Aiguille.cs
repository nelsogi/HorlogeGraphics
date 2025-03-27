using System;
using System.Drawing;

namespace HorlogeForm
{
    public class Aiguille
    {
        public float Longueur { get; set; }
        public Color Couleur { get; set; }
        public float Epaisseur { get; set; }

        public Aiguille(float longueur, Color couleur, float epaisseur)
        {
            Longueur = longueur;
            Couleur = couleur;
            Epaisseur = epaisseur;
        }

        public void Dessiner(Graphics g, Point centre, float angle)
        {
            double radian = angle * Math.PI / 180;

            float x = centre.X + (float)(Longueur * Math.Cos(radian));
            float y = centre.Y - (float)(Longueur * Math.Sin(radian));

            using (Pen pen = new Pen(Couleur, Epaisseur))
            {
                g.DrawLine(pen, centre, new PointF(x, y));
            }
        }
    }

}
