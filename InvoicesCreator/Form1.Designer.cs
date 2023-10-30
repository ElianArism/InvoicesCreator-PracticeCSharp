namespace InvoicesCreator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.efectivoTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.devolucionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAPagarLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.venderBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cantidadNumericUpDown);
            this.panel1.Controls.Add(this.efectivoTxtBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.precioLabel);
            this.panel1.Controls.Add(this.nombreLabel);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Controls.Add(this.comboBoxProductos);
            this.panel1.Controls.Add(this.devolucionLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.eliminarBtn);
            this.panel1.Controls.Add(this.agregarBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.totalAPagarLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(56, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 634);
            this.panel1.TabIndex = 0;
            // 
            // efectivoTxtBox
            // 
            this.efectivoTxtBox.Location = new System.Drawing.Point(266, 572);
            this.efectivoTxtBox.Name = "efectivoTxtBox";
            this.efectivoTxtBox.Size = new System.Drawing.Size(112, 22);
            this.efectivoTxtBox.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cantidad";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Location = new System.Drawing.Point(146, 189);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(11, 16);
            this.precioLabel.TabIndex = 15;
            this.precioLabel.Text = "-";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(146, 138);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(11, 16);
            this.nombreLabel.TabIndex = 14;
            this.nombreLabel.Text = "-";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(146, 84);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(11, 16);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "-";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(149, 27);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(264, 24);
            this.comboBoxProductos.TabIndex = 12;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // devolucionLabel
            // 
            this.devolucionLabel.AutoSize = true;
            this.devolucionLabel.Location = new System.Drawing.Point(412, 575);
            this.devolucionLabel.Name = "devolucionLabel";
            this.devolucionLabel.Size = new System.Drawing.Size(11, 16);
            this.devolucionLabel.TabIndex = 11;
            this.devolucionLabel.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Devolucion";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(487, 151);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(117, 54);
            this.eliminarBtn.TabIndex = 9;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(487, 78);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(117, 57);
            this.agregarBtn.TabIndex = 8;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio";
            // 
            // totalAPagarLabel
            // 
            this.totalAPagarLabel.AutoSize = true;
            this.totalAPagarLabel.Location = new System.Drawing.Point(183, 575);
            this.totalAPagarLabel.Name = "totalAPagarLabel";
            this.totalAPagarLabel.Size = new System.Drawing.Size(11, 16);
            this.totalAPagarLabel.TabIndex = 6;
            this.totalAPagarLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(16, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // venderBtn
            // 
            this.venderBtn.Location = new System.Drawing.Point(322, 724);
            this.venderBtn.Name = "venderBtn";
            this.venderBtn.Size = new System.Drawing.Size(112, 54);
            this.venderBtn.TabIndex = 19;
            this.venderBtn.Text = "VENDER";
            this.venderBtn.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(353, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "FACTURA VENTA MADIEL SA";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUCTO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(149, 239);
            this.cantidadNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(264, 22);
            this.cantidadNumericUpDown.TabIndex = 19;
            this.cantidadNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 800);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.venderBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalAPagarLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox efectivoTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label devolucionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button venderBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

