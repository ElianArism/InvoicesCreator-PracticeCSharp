using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;

namespace InvoicesCreator
{
    public partial class Form1 : Form
    {
        private List<ProductDTO> products; 
        public Form1()
        {
            InitializeComponent();
            ReadItemsFromList();
        }


        public void ReadItemsFromList()
        {
            string path = Path.Combine(Application.StartupPath,  "itemsTienda.json");
            string json = File.ReadAllText(path);
            List<ProductDTO> items = JsonSerializer.Deserialize<List<ProductDTO>>(json);
            products = items; 
            foreach (ProductDTO i in items)
            {
                comboBoxProductos.Items.Add(i.nombre); 
            }

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProductos.SelectedIndex == -1)
            {
                return; 
            }
            string prodName = comboBoxProductos.SelectedItem.ToString();
            ProductDTO prod = products.Find((p) => p.nombre == prodName);

            codigoLabel.Text = prod.cod; 
            nombreLabel.Text = prod.nombre;
            precioLabel.Text = prod.precio.ToString(); 
            
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if(codigoLabel.Text == "-" ||  codigoLabel.Text == string.Empty)
            {
                return; 
            }

            DataGridViewRow invoiceRow = new DataGridViewRow();
            invoiceRow.CreateCells(dataGridView1);

            invoiceRow.Cells[0].Value = codigoLabel.Text;
            invoiceRow.Cells[1].Value = nombreLabel.Text;
            invoiceRow.Cells[2].Value = precioLabel.Text;
            invoiceRow.Cells[3].Value = cantidadNumericUpDown.Value.ToString();

            decimal precioValue = decimal.Parse(precioLabel.Text);
            invoiceRow.Cells[4].Value = cantidadNumericUpDown.Value * precioValue;

            codigoLabel.Text = "-";
            nombreLabel.Text = "-";
            precioLabel.Text = "-";
            cantidadNumericUpDown.Value = 1;
            comboBoxProductos.SelectedIndex = -1;

            dataGridView1.Rows.Add(invoiceRow);

            this.calculateTotalAmount();

        }

        private void calculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                totalAmount += decimal.Parse(item.Cells[4].Value.ToString());   
            }
            totalAPagarLabel.Text = totalAmount.ToString();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult deleteItem = MessageBox.Show($"Desea eliminar el producto {dataGridView1.CurrentRow.Cells[1].Value}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                
                if(deleteItem == DialogResult.Yes)
                {
                    // Current row === Row seleccionada
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    this.calculateTotalAmount();
                    return; 
                }
            }
            catch {}

        }

        private void efectivoTxtBox_TextChanged(object sender, EventArgs e)
        {
            try {
                decimal totalAmount = decimal.Parse(totalAPagarLabel.Text);
                decimal paidAmount = decimal.Parse(efectivoTxtBox.Text);

                decimal result = totalAmount - paidAmount;

                if(result > 0) { return; }

                devolucionLabel.Text = $"{Math.Abs(result)}";
            }
            catch { }
        }

        private void venderBtn_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "factura.txt");

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("********* EMPRESA: MADIEL *********");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("------- CODIGO ------- | ------- PRECIO ------- | ------- PRODUCTO ------- | ------- CANTIDAD ------- | ------- TOTAL -------");
                foreach( DataGridViewRow row in dataGridView1.Rows )
                {
                    sw.WriteLine($"{row.Cells[0].Value} | {row.Cells[1].Value} | {row.Cells[2].Value} | {row.Cells[3].Value} | {row.Cells[4].Value}");
                }
                sw.WriteLine($"TOTAL: ${totalAPagarLabel.Text}");
                sw.WriteLine("");
                sw.WriteLine($"DEVOLUCION: ${devolucionLabel.Text}");
            }


            // OPEN File
            Process.Start(path); 
        }
    }
}
