namespace SistemaCandidatas
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.picMunicipios = new System.Windows.Forms.PictureBox();
            this.picCandidatas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxModulos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCandidatas)).BeginInit();
            this.gbxModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMunicipios
            // 
            this.picMunicipios.Image = ((System.Drawing.Image)(resources.GetObject("picMunicipios.Image")));
            this.picMunicipios.Location = new System.Drawing.Point(301, 43);
            this.picMunicipios.Margin = new System.Windows.Forms.Padding(4);
            this.picMunicipios.Name = "picMunicipios";
            this.picMunicipios.Size = new System.Drawing.Size(228, 157);
            this.picMunicipios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMunicipios.TabIndex = 1;
            this.picMunicipios.TabStop = false;
            // 
            // picCandidatas
            // 
            this.picCandidatas.Image = ((System.Drawing.Image)(resources.GetObject("picCandidatas.Image")));
            this.picCandidatas.Location = new System.Drawing.Point(24, 43);
            this.picCandidatas.Margin = new System.Windows.Forms.Padding(4);
            this.picCandidatas.Name = "picCandidatas";
            this.picCandidatas.Size = new System.Drawing.Size(228, 157);
            this.picCandidatas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCandidatas.TabIndex = 2;
            this.picCandidatas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Candidatas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Municipios";
            // 
            // gbxModulos
            // 
            this.gbxModulos.Controls.Add(this.picCandidatas);
            this.gbxModulos.Controls.Add(this.label2);
            this.gbxModulos.Controls.Add(this.picMunicipios);
            this.gbxModulos.Controls.Add(this.label1);
            this.gbxModulos.Location = new System.Drawing.Point(13, 13);
            this.gbxModulos.Name = "gbxModulos";
            this.gbxModulos.Size = new System.Drawing.Size(571, 251);
            this.gbxModulos.TabIndex = 5;
            this.gbxModulos.TabStop = false;
            this.gbxModulos.Text = "Elige el modulo:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.gbxModulos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCandidatas)).EndInit();
            this.gbxModulos.ResumeLayout(false);
            this.gbxModulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMunicipios;
        private System.Windows.Forms.PictureBox picCandidatas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxModulos;
    }
}