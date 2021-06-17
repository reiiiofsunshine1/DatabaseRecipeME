namespace DatabasePersonalPBO
{
    partial class recipeSoto
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
            this.label1 = new System.Windows.Forms.Label();
            this.soto_pic = new System.Windows.Forms.PictureBox();
            this.sotoRecipe = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.soto_pic)).BeginInit();
            this.SuspendLayout();
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
            this.label1.TabIndex = 3;
            this.label1.Text = "RecipeME!";
            // 
            // soto_pic
            // 
            this.soto_pic.Image = global::DatabasePersonalPBO.Properties.Resources.soto_ayam_gurih;
            this.soto_pic.Location = new System.Drawing.Point(581, 12);
            this.soto_pic.Name = "soto_pic";
            this.soto_pic.Size = new System.Drawing.Size(185, 161);
            this.soto_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.soto_pic.TabIndex = 6;
            this.soto_pic.TabStop = false;
            // 
            // sotoRecipe
            // 
            this.sotoRecipe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sotoRecipe.FormattingEnabled = true;
            this.sotoRecipe.ItemHeight = 20;
            this.sotoRecipe.Location = new System.Drawing.Point(21, 108);
            this.sotoRecipe.Name = "sotoRecipe";
            this.sotoRecipe.Size = new System.Drawing.Size(445, 344);
            this.sotoRecipe.TabIndex = 7;
            // 
            // recipeSoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 517);
            this.Controls.Add(this.sotoRecipe);
            this.Controls.Add(this.soto_pic);
            this.Controls.Add(this.label1);
            this.Name = "recipeSoto";
            this.Text = "recipeSoto";
            ((System.ComponentModel.ISupportInitialize)(this.soto_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox soto_pic;
        private System.Windows.Forms.ListBox sotoRecipe;
    }
}