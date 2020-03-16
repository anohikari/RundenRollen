using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RundenRollen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel viewModel = new ViewModel();
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.GegnerEinheiten.Add(new Trupp("Hans",20,2,16,4));
            viewModel.VerbündeteEinheiten.Add(new Trupp("Dieter", 20, 2, 16, 4));
            DataContext = viewModel;
        }
    }
}
