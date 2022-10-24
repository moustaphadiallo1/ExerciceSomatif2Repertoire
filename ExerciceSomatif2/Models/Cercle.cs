using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class Cercle : Forme
    {
        public Cercle() : base(Color.Orange)
        {
        }

        protected override void Dessiner(Graphics graphics)
        {
            
            Pen monPen = new Pen(couleur);
            graphics.DrawEllipse(monPen, 5, 5, 80, 80);
        }

        public override string ObteinirType()
        {
            return "Cercle";
        }
    }
}
