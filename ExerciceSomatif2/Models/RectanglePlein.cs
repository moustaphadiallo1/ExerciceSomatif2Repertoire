using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public class RectanglePlein : Rectangle
    {
        public RectanglePlein() : base()
        {

        }
        protected override void Dessiner(Graphics graphics)
        {
            SolidBrush maBrush = new SolidBrush(couleur);
            graphics.FillRectangle(maBrush, 10, 10, 80, 80);
        }
        public override string ObteinirType()
        {
            return "RectanglePlein";
        }
    }
}
