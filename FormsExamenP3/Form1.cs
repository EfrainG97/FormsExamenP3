using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsExamenP3.Controller;
using FormsExamenP3.Model;

namespace FormsExamenP3
{
    public partial class Form1 : Form
    {
        VideojuegoController vc = new VideojuegoController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarJuegos();

        }

        private async void CargarJuegos()
        {
            DGVViedo.DataSource = null;
            DGVViedo.DataSource = await vc.GetVideojuegos();
        }

        void Limpiar(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var precioc=Convert.ToDouble(TBPrecio.Text);
            if (await vc.AgregarJuego(new Videojuego { Titulo = TBTitulo.Text, Genero = TBGenero.Text, Plataforma = TBPlataforma.Text, Precio = precioc }))
            {
                MessageBox.Show("Videojuego Agregado con Exito");
                Limpiar(this);
            }
            else
            {
                MessageBox.Show("Hubo un problema al agregar el Videojuego");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarJuegos();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (await vc.EliminarJuego(Convert.ToInt32(TBID.Text)))
            {
                {
                    MessageBox.Show("Videojuego eliminado con exito");
                    CargarJuegos();
                    Limpiar(this);
                }
            }
        }

        private async void BtnCargar_Click(object sender, EventArgs e)
        {
            var lista = await vc.ObtenerVideojuegoID(Convert.ToInt32(TBID.Text));

            TBTitulo.Text = lista.Titulo.ToString();
            TBPlataforma.Text = lista.Plataforma.ToString();
            TBGenero.Text = lista.Genero.ToString();
            TBPrecio.Text = lista.Precio.ToString();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            double precioc = Convert.ToDouble(TBPrecio.Text);

            if (await vc.ActualizarJuego(Convert.ToInt32(TBID.Text),new Videojuego(Convert.ToInt32(TBID.Text), TBTitulo.Text, TBGenero.Text,TBPlataforma.Text,precioc)))
            {
                MessageBox.Show("Videojuego actualizado con Exito");
                CargarJuegos();
                Limpiar(this);
            }
            else
            {
                MessageBox.Show("Hubo un problema al actualizar el videojuego");
            }
        }
    }
}
