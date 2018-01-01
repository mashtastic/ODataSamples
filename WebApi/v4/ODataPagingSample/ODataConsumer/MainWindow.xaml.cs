using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using ODataPagingSample.Models;

namespace ODataConsumer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var context = new Default.Container(new Uri("http://localhost:23645/api"));

            List<Movie> movies = context.Movies.ToList();
            List<Movie> movies2 = context.Movies.Skip(25).ToList();
        }
    }
}
