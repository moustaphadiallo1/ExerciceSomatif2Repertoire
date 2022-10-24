namespace ExerciceSomatif2
{
    partial class FormAffichageForme
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PasserAuSuivant = new System.Windows.Forms.Button();
            this.figuresControl2 = new ExerciceSomatif2.Controles.FiguresControl();
            this.btn_passer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PasserAuSuivant
            // 
            this.btn_PasserAuSuivant.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_PasserAuSuivant.Location = new System.Drawing.Point(357, 459);
            this.btn_PasserAuSuivant.Name = "btn_PasserAuSuivant";
            this.btn_PasserAuSuivant.Size = new System.Drawing.Size(267, 42);
            this.btn_PasserAuSuivant.TabIndex = 1;
            this.btn_PasserAuSuivant.Text = "Passer au suivant";
            this.btn_PasserAuSuivant.UseVisualStyleBackColor = true;
            // 
            // figuresControl2
            // 
            this.figuresControl2.Forme = null;
            this.figuresControl2.Location = new System.Drawing.Point(30, 12);
            this.figuresControl2.Name = "figuresControl2";
            this.figuresControl2.Size = new System.Drawing.Size(1097, 469);
            this.figuresControl2.TabIndex = 0;
            // 
            // btn_passer
            // 
            this.btn_passer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_passer.Location = new System.Drawing.Point(385, 487);
            this.btn_passer.Name = "btn_passer";
            this.btn_passer.Size = new System.Drawing.Size(238, 51);
            this.btn_passer.TabIndex = 1;
            this.btn_passer.Text = "Passer au suivant";
            this.btn_passer.UseVisualStyleBackColor = true;
            this.btn_passer.Click += new System.EventHandler(this.btn_passer_Click);
            // 
            // FormAffichageForme
            // 
            this.ClientSize = new System.Drawing.Size(1251, 549);
            this.Controls.Add(this.btn_passer);
            this.Controls.Add(this.figuresControl2);
            this.Name = "FormAffichageForme";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.FiguresControl figuresControl1;
        private Button btn_PasserAuSuivant;
        private Controles.FiguresControl figuresControl2;
        private Button btn_passer;
    }
}