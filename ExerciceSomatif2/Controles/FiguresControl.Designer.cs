using ExerciceSomatif2.Models;

namespace ExerciceSomatif2.Controles
{
    public partial class FiguresControl: UserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_fromeCourante = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_affichageType = new System.Windows.Forms.Label();
            this.pictureBox_Figures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Figures)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fromeCourante
            // 
            this.lbl_fromeCourante.AutoSize = true;
            this.lbl_fromeCourante.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fromeCourante.Location = new System.Drawing.Point(299, 10);
            this.lbl_fromeCourante.Name = "lbl_fromeCourante";
            this.lbl_fromeCourante.Size = new System.Drawing.Size(265, 45);
            this.lbl_fromeCourante.TabIndex = 0;
            this.lbl_fromeCourante.Text = "Forme courante";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.Location = new System.Drawing.Point(3, 398);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(370, 38);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "Type de la forme courante:";
            // 
            // lbl_affichageType
            // 
            this.lbl_affichageType.AutoSize = true;
            this.lbl_affichageType.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_affichageType.Location = new System.Drawing.Point(467, 398);
            this.lbl_affichageType.Name = "lbl_affichageType";
            this.lbl_affichageType.Size = new System.Drawing.Size(319, 38);
            this.lbl_affichageType.TabIndex = 2;
            this.lbl_affichageType.Text = "Affichage type courant";
            // 
            // pictureBox_Figures
            // 
            this.pictureBox_Figures.Location = new System.Drawing.Point(18, 59);
            this.pictureBox_Figures.Name = "pictureBox_Figures";
            this.pictureBox_Figures.Size = new System.Drawing.Size(822, 320);
            this.pictureBox_Figures.TabIndex = 3;
            this.pictureBox_Figures.TabStop = false;
            // 
            // FiguresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Figures);
            this.Controls.Add(this.lbl_affichageType);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_fromeCourante);
            this.Name = "FiguresControl";
            this.Size = new System.Drawing.Size(891, 447);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Figures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_fromeCourante;
        private Label lbl_type;
        private Label lbl_affichageType;
        private PictureBox pictureBox_Figures;
    }
}
