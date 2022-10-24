using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class CerclePlein : Cercle
    {
        public CerclePlein() : base()
        {

        }
        protected override void Dessiner(Graphics graphics)
        {

            SolidBrush maBrush = new SolidBrush(couleur);
            graphics.FillEllipse(maBrush, 10, 10, 80, 80);
        }

        public override string ObteinirType()
        {
            return "CerclePlein";
        }
    }
}
