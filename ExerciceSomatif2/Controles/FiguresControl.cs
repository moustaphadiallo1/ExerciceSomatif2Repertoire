﻿using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class FiguresControl : UserControl
    {
        private Forme formes;

        public Forme Forme
        {
            get => formes;
            set
            {
                formes = value;
                MAJAffichageForme();
            }
        }
        public FiguresControl()
        {
            InitializeComponent();
        }
        

        private void MAJAffichageForme()
        {
            if (formes is null)
            {

                lbl_affichageType.Text = "";
                pictureBox_Figures.Visible = false;
                return;
            }
            lbl_affichageType.Text = formes.ObteinirType();
            pictureBox_Figures.Visible = true;
            pictureBox_Figures.Image = formes.Dessiner();
        }
    }
}
