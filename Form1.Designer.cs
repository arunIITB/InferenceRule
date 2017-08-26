namespace RuleInference
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tradeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new RuleInference.DataSet1();
            this.tradeDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxInferredRules = new System.Windows.Forms.TextBox();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateData = new System.Windows.Forms.Button();
            this.InferRules = new System.Windows.Forms.Button();
            this.tradeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strikeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tradeDataBindingSource
            // 
            this.tradeDataBindingSource.DataMember = "TradeData";
            this.tradeDataBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradeDataBindingSource1
            // 
            this.tradeDataBindingSource1.DataMember = "TradeData";
            this.tradeDataBindingSource1.DataSource = this.dataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeIDDataGridViewTextBoxColumn,
            this.tradeDateDataGridViewTextBoxColumn,
            this.symbolDataGridViewTextBoxColumn,
            this.strikeDataGridViewTextBoxColumn,
            this.marketPriceDataGridViewTextBoxColumn,
            this.notionalDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tradeDataBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxInferredRules
            // 
            this.textBoxInferredRules.Location = new System.Drawing.Point(823, 56);
            this.textBoxInferredRules.Multiline = true;
            this.textBoxInferredRules.Name = "textBoxInferredRules";
            this.textBoxInferredRules.Size = new System.Drawing.Size(520, 237);
            this.textBoxInferredRules.TabIndex = 1;
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(170, 333);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(354, 20);
            this.textBoxExpression.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inferred Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result Expression";
            // 
            // GenerateData
            // 
            this.GenerateData.Location = new System.Drawing.Point(28, 390);
            this.GenerateData.Name = "GenerateData";
            this.GenerateData.Size = new System.Drawing.Size(116, 29);
            this.GenerateData.TabIndex = 5;
            this.GenerateData.Text = "Generate Data";
            this.GenerateData.UseVisualStyleBackColor = true;
            this.GenerateData.Click += new System.EventHandler(this.GenerateData_Click);
            // 
            // InferRules
            // 
            this.InferRules.Location = new System.Drawing.Point(823, 390);
            this.InferRules.Name = "InferRules";
            this.InferRules.Size = new System.Drawing.Size(116, 29);
            this.InferRules.TabIndex = 6;
            this.InferRules.Text = "Infer Rules";
            this.InferRules.UseVisualStyleBackColor = true;
            // 
            // tradeIDDataGridViewTextBoxColumn
            // 
            this.tradeIDDataGridViewTextBoxColumn.DataPropertyName = "TradeID";
            this.tradeIDDataGridViewTextBoxColumn.HeaderText = "TradeID";
            this.tradeIDDataGridViewTextBoxColumn.Name = "tradeIDDataGridViewTextBoxColumn";
            // 
            // tradeDateDataGridViewTextBoxColumn
            // 
            this.tradeDateDataGridViewTextBoxColumn.DataPropertyName = "TradeDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.tradeDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tradeDateDataGridViewTextBoxColumn.HeaderText = "TradeDate";
            this.tradeDateDataGridViewTextBoxColumn.Name = "tradeDateDataGridViewTextBoxColumn";
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            this.symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            // 
            // strikeDataGridViewTextBoxColumn
            // 
            this.strikeDataGridViewTextBoxColumn.DataPropertyName = "Strike";
            this.strikeDataGridViewTextBoxColumn.HeaderText = "Strike";
            this.strikeDataGridViewTextBoxColumn.Name = "strikeDataGridViewTextBoxColumn";
            // 
            // marketPriceDataGridViewTextBoxColumn
            // 
            this.marketPriceDataGridViewTextBoxColumn.DataPropertyName = "MarketPrice";
            this.marketPriceDataGridViewTextBoxColumn.HeaderText = "MarketPrice";
            this.marketPriceDataGridViewTextBoxColumn.Name = "marketPriceDataGridViewTextBoxColumn";
            // 
            // notionalDataGridViewTextBoxColumn
            // 
            this.notionalDataGridViewTextBoxColumn.DataPropertyName = "Notional";
            this.notionalDataGridViewTextBoxColumn.HeaderText = "Notional";
            this.notionalDataGridViewTextBoxColumn.Name = "notionalDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 503);
            this.Controls.Add(this.InferRules);
            this.Controls.Add(this.GenerateData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExpression);
            this.Controls.Add(this.textBoxInferredRules);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tradeDataBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tradeDataBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxInferredRules;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateData;
        private System.Windows.Forms.Button InferRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strikeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}

