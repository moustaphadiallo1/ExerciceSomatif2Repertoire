using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = ExerciceSomatif2.Models.Rectangle;

namespace ExerciceSomatif2
{
    public  class Controleur
    {
        //Liste et methode pour passer à la forme suivante
        //Un evenement qui indique le changement de forme

        
        private List<Forme> formes;
        private int idFormeCourante;
        private Forme formeCourante;

        public Controleur()
        {
           formes = new List<Forme>();

           formes.Add(new Rectangle());
           formes.Add(new Cercle());
           formes.Add(new RectanglePlein());
           formes.Add(new CerclePlein());
           idFormeCourante = 0;
           formeCourante = formes[idFormeCourante];
        }

        public Forme FormeCourante { get => formeCourante; }
        public event EventHandler<Forme> ChangementFormeCouranteEvent;

        public void PasserALaFormeSuivante()
        {
            idFormeCourante = (idFormeCourante + 1) % formes.Count;
            formeCourante = formes[idFormeCourante];
            ChangementFormeCouranteEvent?.Invoke(this, formeCourante);
        }

    }
}
