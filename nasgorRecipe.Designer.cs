namespace DatabasePersonalPBO
{
    partial class nasgorRecipe
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
            this.nasgor_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NasiGorengRecipe = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nasgor_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // nasgor_pic
            // 
            this.nasgor_pic.Image = global::DatabasePersonalPBO.Properties.Resources.menu_valuemeals_nasigorengayam;
            this.nasgor_pic.Location = new System.Drawing.Point(634, 12);
            this.nasgor_pic.Name = "nasgor_pic";
            this.nasgor_pic.Size = new System.Drawing.Size(185, 181);
            this.nasgor_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nasgor_pic.TabIndex = 7;
            this.nasgor_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Surfing Capital", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "RecipeME!";
            // 
            // NasiGorengRecipe
            // 
            this.NasiGorengRecipe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NasiGorengRecipe.FormattingEnabled = true;
            this.NasiGorengRecipe.ItemHeight = 20;
            this.NasiGorengRecipe.Location = new System.Drawing.Point(41, 137);
            this.NasiGorengRecipe.Name = "NasiGorengRecipe";
            this.NasiGorengRecipe.Size = new System.Drawing.Size(524, 424);
            this.NasiGorengRecipe.TabIndex = 9;
            this.NasiGorengRecipe.SelectedIndexChanged += new System.EventHandler(this.NasiGorengRecipe_SelectedIndexChanged);
            // 
            // nasgorRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 590);
            this.Controls.Add(this.NasiGorengRecipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nasgor_pic);
            this.Name = "nasgorRecipe";
            this.Text = "nasgorRecipe";
            this.Load += new System.EventHandler(this.nasgorRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nasgor_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nasgor_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NasiGorengRecipe;
    }
}