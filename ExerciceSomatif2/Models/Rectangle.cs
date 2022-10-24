
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Configuration;
using System.Configuration;

namespace ExerciceSomatif2.Models
{
    public class Rectangle : Forme
    {
        public Rectangle():base(Color.Green)
        {

        }

        protected override void Dessiner(Graphics graphics)
        {
            Pen monPen = new Pen(couleur);
            graphics.DrawRectangle(monPen, 5,5,80,80);
        }

        public override string ObteinirType()
        {
            return "Rectangle";
        }
    }
}
