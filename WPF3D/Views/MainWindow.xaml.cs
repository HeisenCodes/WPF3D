using System.Windows;
using WPF3D.ViewModels;

namespace WPF3D.Views
{
    public partial class MainWindow : Window
    {
        MainWindowViewModel ViewModel;

        public MainWindow(MainWindowViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = this.ViewModel = viewModel;


        }


    }
}
