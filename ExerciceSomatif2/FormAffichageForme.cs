using ExerciceSomatif2.Models;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private Controleur controleur;

        public FormAffichageForme()
        {
            InitializeComponent();
            controleur = new Controleur();
            MAJAffichageFormes(controleur.FormeCourante);
            Abonnement();
        }

        private void MAJAffichageFormes(Forme formeCourante)
        {
            figuresControl2.Forme = formeCourante;
         
        }

        private void Abonnement()
        {
            controleur.ChangementFormeCouranteEvent += Controleur_ChangementFormeCourantEvent;
        }

        private void Controleur_ChangementFormeCourantEvent(object? sender, Forme forme)
        {
            MAJAffichageFormes(forme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_passer_Click(object sender, EventArgs e)
        {
            controleur.PasserALaFormeSuivante();
        }
    }
}