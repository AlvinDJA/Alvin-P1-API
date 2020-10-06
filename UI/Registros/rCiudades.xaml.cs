using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Alvin_P1_API.BLL;
using Alvin_P1_API.Entidades;
using Microsoft.EntityFrameworkCore.Internal;

namespace Alvin_P1_API.UI.Registros
{
    /// <summary>
    /// Interaction logic for ciudades.xaml
    /// </summary>
    public partial class rCiudades : Window
    {
        private Ciudades ciudad;
        public rCiudades()
        {
            InitializeComponent();
            ciudad = new Ciudades();
            this.DataContext = ciudad;
        }
        private void Limpiar()
        {
            this.ciudad = new Ciudades();
            this.DataContext = ciudad;
        }
        public void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        private bool Validar()
        {
            bool esValido = true;
            if (CiudadesBLL.Existe(nombreTextBox.Text))
            {
                esValido = false;
                MessageBox.Show("Ha ocurrido un error, no puede repetir el nombre", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
;            if (nombreTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Ha ocurrido un error, debe insertar un nombre", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (nombreTextBox.Text.Any(char.IsDigit))
            {
                esValido = false;
                MessageBox.Show("Ha ocurrido un error, no hay ciudades con numeros", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var ciudad = CiudadesBLL.Buscar(Convert.ToInt32(ciudadIdTextBox.Text));
            if (ciudad != null)
                this.ciudad = ciudad;
            else
            {
                this.ciudad = new Ciudades();
                MessageBox.Show("No se ha encontrado", "Error",
                   MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.ciudad;
        }
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Validar())
                return;
            var paso = CiudadesBLL.Guardar(this.ciudad);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (CiudadesBLL.Eliminar(Convert.ToInt32(ciudadIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);

        }

    }

}
//Buscar
//Nuevo
//Guardar
//Eliminar

