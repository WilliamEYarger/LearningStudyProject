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

namespace LearningStudyProject.Views
{
    /// <summary>
    /// Interaction logic for AnswerQuestionsView.xaml
    /// </summary>
    public partial class AnswerQuestionsView : UserControl
    {
        public AnswerQuestionsView()
        {
            InitializeComponent();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save and Return Clicked");
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test Clicked");
        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Review Clicked");
        }

        private void UseForm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use Form Clicked");
        }

        private void btnOpenImage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Image button Clicked");
        }

        private void btnOpenMp3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Mp3 file button Clicked");
        }

        private void btnShowCorrect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show Correct  Answer Clicked");
        }

        private void btnScoreCorrect_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Scored Correct Clicked");
        }


        private void btnScoreWrong_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Scored Wrong Clicked");
        }
    
    }
}
