
using LearningStudyProject.ViewModels;
using System.Windows;

namespace LearningStudyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You must first Open the Subject Tree Window and then Get the HOlding Folder");
        }
    }
}
