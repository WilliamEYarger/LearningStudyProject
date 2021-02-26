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
using LearningStudyProject.Commands;
using LearningStudyProject.HelperClasses;

namespace LearningStudyProject.Views
{
    /// <summary>
    /// Interaction logic for QACreateEditView.xaml
    /// </summary>
    public partial class QACreateEditView : UserControl
    {
        public QACreateEditView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if(SubjectStaticMembers.DataNode == null)
            {
                MessageBox.Show("You must select a Subject Node to add Data to First");
                


                return;
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            // Enter Save File code here
            MessageBox.Show("Save File Clicked");
        }

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {

            // Enter begin a new file code here
            MessageBox.Show("Begin a New File Clicked");
        }

        private void Append_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Append Clicked");
        }
    }
}
