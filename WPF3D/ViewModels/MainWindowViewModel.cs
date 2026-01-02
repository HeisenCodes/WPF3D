using CommunityToolkit.Mvvm.ComponentModel;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;

namespace WPF3D.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial Model3D Model { get; set; } = new Model3DGroup();

        public MainWindowViewModel()
        {
            var importer = new ModelImporter();


            Model = importer.Load("Models/FemaleHead.obj");
        }
    }
}
