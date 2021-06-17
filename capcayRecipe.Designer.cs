namespace DatabasePersonalPBO
{
    partial class capcayRecipe
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
            this.capcay_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RecipeCapcay = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.capcay_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // capcay_pic
            // 
            this.capcay_pic.Image = global::DatabasePersonalPBO.Properties.Resources.cap_cay___chomp_chomp_by_adirosa_da2b6uj_fullview;
            this.capcay_pic.Location = new System.Drawing.Point(680, 3);
            this.capcay_pic.Name = "capcay_pic";
            this.capcay_pic.Size = new System.Drawing.Size(185, 181);
            this.capcay_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capcay_pic.TabIndex = 8;
            this.capcay_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Surfing Capital", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "RecipeME!";
            // 
            // RecipeCapcay
            // 
            this.RecipeCapcay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RecipeCapcay.FormattingEnabled = true;
            this.RecipeCapcay.ItemHeight = 21;
            this.RecipeCapcay.Location = new System.Drawing.Point(36, 119);
            this.RecipeCapcay.Name = "RecipeCapcay";
            this.RecipeCapcay.Size = new System.Drawing.Size(610, 382);
            this.RecipeCapcay.TabIndex = 10;
            // 
            // capcayRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 553);
            this.Controls.Add(this.RecipeCapcay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capcay_pic);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "capcayRecipe";
            this.Text = "capcayRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.capcay_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox capcay_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RecipeCapcay;
    }
}