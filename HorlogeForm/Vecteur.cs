using System;

namespace HorlogeForm
{
    public class Vecteur
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vecteur(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vecteur Rotation(float angle, float longueur)
        {
            float radians = angle * (float)(Math.PI / 180);
            return new Vecteur(
                (float)(longueur * Math.Cos(radians)),
                (float)(longueur * Math.Sin(radians))
            );
        }
    }

}
