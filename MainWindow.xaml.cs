﻿using Alvin_P1_API.Entidades;
using System.Windows;
using Alvin_P1_API.UI.Registros;
using Alvin_P1_API.UI.Consultas;

namespace Alvin_P1_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rCiudades_Click(object sender, RoutedEventArgs e)
        {
            new rCiudades().Show();
        }
         private void cCiudades_Click(object sender, RoutedEventArgs e)
        {
            new cCiudades().Show();
        }
        

    }
}
