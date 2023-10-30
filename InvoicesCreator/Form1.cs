using System;
using System.Collections.Generic;
using System.IO;
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

            // https://www.youtube.com/watch?v=rmXDFM97Ue4 Continue tomorrow
        }
    }
}
