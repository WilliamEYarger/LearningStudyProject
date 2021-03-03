
using LearningStudyProject.HelperClasses;
using LearningStudyProject.ViewModels;
using LearningStudyProject.Views;
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

        private void OpenSubjectFolder_Click(object sender, RoutedEventArgs e)
        {
            UserContentControl.Content = new SubjectsTreeViewModel();
        }


        private void QACreateEdit_Click(object sender, RoutedEventArgs e)
        {

            if(SubjectStaticMembers.DataNode == null)
            {
                MessageBox.Show("You must have a Subject node selected before you can create a Data File");
                return;
            }
            //UserContentControl.Content = new QACreateEditViewModel();
            UserContentControl.Content = new QACreateEditView();
        }

        private void TestReview_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectStaticMembers.DataNode == null)
            {
                MessageBox.Show("You must have a Subject node selected before you can create a Data File");
                return;
            }
            UserContentControl.Content = new AnswerQuestionsView();
        }
    }
}
