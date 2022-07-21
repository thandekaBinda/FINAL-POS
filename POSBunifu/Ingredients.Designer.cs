
namespace POSBunifu
{
    partial class Ingredients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iNGREDIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNGREDIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lafusionPOSDataSet = new POSBunifu.lafusionPOSDataSet();
            this.iNGREDIENTSTableAdapter = new POSBunifu.lafusionPOSDataSetTableAdapters.INGREDIENTSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lafusionPOSDataSet1 = new POSBunifu.lafusionPOSDataSet1();
            this.iNGREDIENTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iNGREDIENTSTableAdapter1 = new POSBunifu.lafusionPOSDataSet1TableAdapters.INGREDIENTSTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lafusionPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lafusionPOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNGREDIENTIDDataGridViewTextBoxColumn,
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNGREDIENTSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(372, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(381, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iNGREDIENTIDDataGridViewTextBoxColumn
            // 
            this.iNGREDIENTIDDataGridViewTextBoxColumn.DataPropertyName = "INGREDIENT_ID";
            this.iNGREDIENTIDDataGridViewTextBoxColumn.HeaderText = "INGREDIENT_ID";
            this.iNGREDIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNGREDIENTIDDataGridViewTextBoxColumn.Name = "iNGREDIENTIDDataGridViewTextBoxColumn";
            this.iNGREDIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNGREDIENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNGREDIENTNAMEDataGridViewTextBoxColumn
            // 
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "INGREDIENT_NAME";
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn.HeaderText = "INGREDIENT_NAME";
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn.Name = "iNGREDIENTNAMEDataGridViewTextBoxColumn";
            this.iNGREDIENTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNGREDIENTSBindingSource
            // 
            this.iNGREDIENTSBindingSource.DataMember = "INGREDIENTS";
            this.iNGREDIENTSBindingSource.DataSource = this.lafusionPOSDataSet;
            // 
            // lafusionPOSDataSet
            // 
            this.lafusionPOSDataSet.DataSetName = "lafusionPOSDataSet";
            this.lafusionPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNGREDIENTSTableAdapter
            // 
            this.iNGREDIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "INGREDIENT_NAME";
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(331, 166);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(100, 22);
            this.txtIngredient.TabIndex = 6;
            // 
            // lafusionPOSDataSet1
            // 
            this.lafusionPOSDataSet1.DataSetName = "lafusionPOSDataSet1";
            this.lafusionPOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNGREDIENTSBindingSource1
            // 
            this.iNGREDIENTSBindingSource1.DataMember = "INGREDIENTS";
            this.iNGREDIENTSBindingSource1.DataSource = this.lafusionPOSDataSet1;
            // 
            // iNGREDIENTSTableAdapter1
            // 
            this.iNGREDIENTSTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ingredients";
            this.Text = "Ingredients";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lafusionPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lafusionPOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lafusionPOSDataSet lafusionPOSDataSet;
        private System.Windows.Forms.BindingSource iNGREDIENTSBindingSource;
        private lafusionPOSDataSetTableAdapters.INGREDIENTSTableAdapter iNGREDIENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNGREDIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNGREDIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngredient;
        private lafusionPOSDataSet1 lafusionPOSDataSet1;
        private System.Windows.Forms.BindingSource iNGREDIENTSBindingSource1;
        private lafusionPOSDataSet1TableAdapters.INGREDIENTSTableAdapter iNGREDIENTSTableAdapter1;
        private System.Windows.Forms.Button btnDelete;
    }
}