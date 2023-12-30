
namespace xml_json_to_accdb
{
    partial class Converter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonReadXML = new System.Windows.Forms.Button();
			this.buttonXMLtoGrid = new System.Windows.Forms.Button();
			this.buttonJSONtoGrid = new System.Windows.Forms.Button();
			this.buttonReadJSON = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.testDBDataSet = new xml_json_to_accdb.TestDBDataSet();
			this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 23);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(296, 462);
			this.textBox1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(317, 23);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(737, 462);
			this.dataGridView1.TabIndex = 1;
			// 
			// buttonReadXML
			// 
			this.buttonReadXML.Location = new System.Drawing.Point(13, 492);
			this.buttonReadXML.Margin = new System.Windows.Forms.Padding(4);
			this.buttonReadXML.Name = "buttonReadXML";
			this.buttonReadXML.Size = new System.Drawing.Size(100, 50);
			this.buttonReadXML.TabIndex = 5;
			this.buttonReadXML.Text = "Read XML";
			this.buttonReadXML.UseVisualStyleBackColor = true;
			this.buttonReadXML.Click += new System.EventHandler(this.buttonReadXML_Click);
			// 
			// buttonXMLtoGrid
			// 
			this.buttonXMLtoGrid.Location = new System.Drawing.Point(317, 492);
			this.buttonXMLtoGrid.Margin = new System.Windows.Forms.Padding(4);
			this.buttonXMLtoGrid.Name = "buttonXMLtoGrid";
			this.buttonXMLtoGrid.Size = new System.Drawing.Size(150, 50);
			this.buttonXMLtoGrid.TabIndex = 6;
			this.buttonXMLtoGrid.Text = "Read XML to grid";
			this.buttonXMLtoGrid.UseVisualStyleBackColor = true;
			this.buttonXMLtoGrid.Click += new System.EventHandler(this.buttonXMLtoGrid_Click);
			// 
			// buttonJSONtoGrid
			// 
			this.buttonJSONtoGrid.Location = new System.Drawing.Point(475, 492);
			this.buttonJSONtoGrid.Margin = new System.Windows.Forms.Padding(4);
			this.buttonJSONtoGrid.Name = "buttonJSONtoGrid";
			this.buttonJSONtoGrid.Size = new System.Drawing.Size(150, 50);
			this.buttonJSONtoGrid.TabIndex = 8;
			this.buttonJSONtoGrid.Text = "Read JSON to grid";
			this.buttonJSONtoGrid.UseVisualStyleBackColor = true;
			this.buttonJSONtoGrid.Click += new System.EventHandler(this.buttonJSONtoGrid_Click);
			// 
			// buttonReadJSON
			// 
			this.buttonReadJSON.Location = new System.Drawing.Point(121, 492);
			this.buttonReadJSON.Margin = new System.Windows.Forms.Padding(4);
			this.buttonReadJSON.Name = "buttonReadJSON";
			this.buttonReadJSON.Size = new System.Drawing.Size(100, 50);
			this.buttonReadJSON.TabIndex = 7;
			this.buttonReadJSON.Text = "Read JSON";
			this.buttonReadJSON.UseVisualStyleBackColor = true;
			this.buttonReadJSON.Click += new System.EventHandler(this.buttonReadJSON_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(905, 492);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(150, 50);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save to DB and read it";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// testDBDataSet
			// 
			this.testDBDataSet.DataSetName = "TestDBDataSet";
			this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// providerBindingSource
			// 
			this.providerBindingSource.DataMember = "Provider";
			this.providerBindingSource.DataSource = this.testDBDataSet;
			// 
			// incomeBindingSource
			// 
			this.incomeBindingSource.DataMember = "Income";
			this.incomeBindingSource.DataSource = this.testDBDataSet;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataMember = "Product";
			this.productBindingSource.DataSource = this.testDBDataSet;
			// 
			// Converter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonJSONtoGrid);
			this.Controls.Add(this.buttonReadJSON);
			this.Controls.Add(this.buttonXMLtoGrid);
			this.Controls.Add(this.buttonReadXML);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Converter";
			this.Text = "Converter";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReadXML;
        private System.Windows.Forms.Button buttonXMLtoGrid;
        private System.Windows.Forms.Button buttonJSONtoGrid;
        private System.Windows.Forms.Button buttonReadJSON;
		private System.Windows.Forms.Button buttonSave;
		private TestDBDataSet testDBDataSet;
		private System.Windows.Forms.BindingSource providerBindingSource;
		private System.Windows.Forms.BindingSource incomeBindingSource;
		private System.Windows.Forms.BindingSource productBindingSource;
	}
}

