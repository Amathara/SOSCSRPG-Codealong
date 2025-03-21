﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;// declaring a private variable.

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession(); // we instansiate.

            DataContext = _gameSession; // What the .xaml file is going to use for its values!!!!!!! DataContext is a built in property.

        }
    }
}