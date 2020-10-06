using System;
using System.Collections.Generic;
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

namespace Alvin_P1_API.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cCiudades.xaml
    /// </summary>
    public partial class cCiudades : Window
    {
        public cCiudades()
        {
            InitializeComponent();
        }
        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Ciudades>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: 
                        listado = CiudadesBLL.GetList(e => e.ciudadId == Convert.ToInt32(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = CiudadesBLL.GetList(e => e.nombre.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = CiudadesBLL.GetList(c => true);
            }

            CiudadDataGrid.ItemsSource = null;
            CiudadDataGrid.ItemsSource = listado;
        }


    }
}
