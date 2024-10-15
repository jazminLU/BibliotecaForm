using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaForm
{
    public partial class Form1 : Form
    {
        string nombreLibro, genero, libroMasPag = "";
        int cantPaginas = 0, numEstante = 1, librosPorEstante = 0, cantMaxPag = 0, cantLibros = 0, cantI = 0, cantN = 0, cantH = 0, sumaPaginas = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtCantPaginas_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblResumenFinal_Click(object sender, EventArgs e)
        {
        }

        private void lblEstante_Click(object sender, EventArgs e)
        {
        }

        double promedioPaginas = 0;

        public Form1()
        {
            InitializeComponent();

            cmbGenero.Items.Add("Infantil");
            cmbGenero.Items.Add("Historia");
            cmbGenero.Items.Add("Novela");
            lblEstante.Text = $"Estante {numEstante}";
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreLibro.Text))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un género.");
                return;
            }

            if (!int.TryParse(txtCantPaginas.Text, out cantPaginas) || cantPaginas <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de páginas.");
                return;
            }

            nombreLibro = txtNombreLibro.Text;
            genero = cmbGenero.SelectedItem.ToString();

            if (genero == "Infantil")
            {
                cantI++;
            }
            else if (genero == "Historia")
            {
                cantH++;
            }
            else if (genero == "Novela")
            {
                cantN++;
            }

            librosPorEstante++;
            cantLibros++;
            sumaPaginas += cantPaginas;

            if (cantPaginas > cantMaxPag)
            {
                cantMaxPag = cantPaginas;
                libroMasPag = nombreLibro;
            }

            lstResumen.Items.Add($"Libro: {nombreLibro}, Género: {genero}, Páginas: {cantPaginas}");

            txtNombreLibro.Clear();
            txtCantPaginas.Clear();
            cmbGenero.SelectedIndex = -1;
        }

        private void btnFinalizarEstante_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Has terminado el estante {numEstante}.");

            if (numEstante == 3)  
            {
           
                if (cantLibros > 0)
                {
                    promedioPaginas = (double)sumaPaginas / cantLibros;
                    string resumen =
                                     $"Libro con más páginas: {libroMasPag} ({cantMaxPag} páginas)\n" +
                                     $"Total de libros infantiles: {cantI}\n" +
                                     $"Total de libros de historia: {cantH}\n" +
                                     $"Total de novelas: {cantN}\n" +
                                     $"Promedio de páginas por libro: {promedioPaginas:F2}\n" +
                                     $"Total de libros ingresados: {cantLibros}";

                    lstResumenFinal.Items.Clear();
                    lstResumenFinal.Items.Add($"Libro con más páginas: {libroMasPag} ({cantMaxPag} páginas)");
                    lstResumenFinal.Items.Add($"Total de libros infantiles: {cantI}");
                    lstResumenFinal.Items.Add($"Total de libros de historia: {cantH}");
                    lstResumenFinal.Items.Add($"Total de novelas: {cantN}");
                    lstResumenFinal.Items.Add($"Promedio de páginas por libro: {promedioPaginas:F2}");

                  
                    lblEstante.Text = $"Total de libros ingresados: {cantLibros}";
                }
                else
                {
                    lstResumenFinal.Items.Add("No se ingresaron libros.");
                }

                btnAgregarLibro.Enabled = false;
                btnFinalizarEstante.Enabled = false;
            }
            else if (numEstante < 3) 
            {
        
                numEstante++;
                lblEstante.Text = $"Estante {numEstante}";
            }
        }
    }
}
