namespace DatabasePersonalPBO
{
    partial class rendangRecipe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.recipesDataSet = new DatabasePersonalPBO.RecipesDataSet();
            this.recipexIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipexIngredientTableAdapter = new DatabasePersonalPBO.RecipesDataSetTableAdapters.RecipexIngredientTableAdapter();
            this.tableAdapterManager = new DatabasePersonalPBO.RecipesDataSetTableAdapters.TableAdapterManager();
            this.ResepRendang = new System.Windows.Forms.ListBox();
            this.rendang_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipexIngredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendang_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Surfing Capital", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "RecipeME!";
            // 
            // recipesDataSet
            // 
            this.recipesDataSet.DataSetName = "RecipesDataSet";
            this.recipesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipexIngredientBindingSource
            // 
            this.recipexIngredientBindingSource.DataMember = "RecipexIngredient";
            this.recipexIngredientBindingSource.DataSource = this.recipesDataSet;
            // 
            // recipexIngredientTableAdapter
            // 
            this.recipexIngredientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientTableAdapter = null;
            this.tableAdapterManager.RecipeTableAdapter = null;
            this.tableAdapterManager.RecipexIngredientTableAdapter = this.recipexIngredientTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabasePersonalPBO.RecipesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ResepRendang
            // 
            this.ResepRendang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResepRendang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResepRendang.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResepRendang.FormattingEnabled = true;
            this.ResepRendang.ItemHeight = 21;
            this.ResepRendang.Location = new System.Drawing.Point(50, 141);
            this.ResepRendang.Name = "ResepRendang";
            this.ResepRendang.Size = new System.Drawing.Size(368, 424);
            this.ResepRendang.TabIndex = 6;
            this.ResepRendang.SelectedIndexChanged += new System.EventHandler(this.listRendang_SelectedIndexChanged);
            // 
            // rendang_pic
            // 
            this.rendang_pic.Image = global::DatabasePersonalPBO.Properties.Resources.jual_rendang_di_bandung;
            this.rendang_pic.Location = new System.Drawing.Point(644, 36);
            this.rendang_pic.Name = "rendang_pic";
            this.rendang_pic.Size = new System.Drawing.Size(185, 181);
            this.rendang_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rendang_pic.TabIndex = 5;
            this.rendang_pic.TabStop = false;
            // 
            // rendangRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 648);
            this.Controls.Add(this.ResepRendang);
            this.Controls.Add(this.rendang_pic);
            this.Controls.Add(this.label1);
            this.Name = "rendangRecipe";
            this.Text = "rendangRecipe";
            this.Load += new System.EventHandler(this.rendangRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipexIngredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendang_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rendang_pic;
        private RecipesDataSet recipesDataSet;
        private System.Windows.Forms.BindingSource recipexIngredientBindingSource;
        private RecipesDataSetTableAdapters.RecipexIngredientTableAdapter recipexIngredientTableAdapter;
        private RecipesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox ResepRendang;
    }
}