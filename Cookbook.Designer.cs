namespace DatabasePersonalPBO
{
    partial class Cookbook
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
            this.label2 = new System.Windows.Forms.Label();
            this.recipesDataSet = new DatabasePersonalPBO.RecipesDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.listRCP = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Surfing Capital", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "RecipeME!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(262, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Here\'s your recipe!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // recipesDataSet
            // 
            this.recipesDataSet.DataSetName = "RecipesDataSet";
            this.recipesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipe";
            // 
            // listRCP
            // 
            this.listRCP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listRCP.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRCP.ForeColor = System.Drawing.Color.SteelBlue;
            this.listRCP.FormattingEnabled = true;
            this.listRCP.ItemHeight = 21;
            this.listRCP.Location = new System.Drawing.Point(25, 129);
            this.listRCP.Name = "listRCP";
            this.listRCP.Size = new System.Drawing.Size(198, 193);
            this.listRCP.TabIndex = 6;
            // 
            // Cookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listRCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cookbook";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.Cookbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RecipesDataSet recipesDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listRCP;
    }
}