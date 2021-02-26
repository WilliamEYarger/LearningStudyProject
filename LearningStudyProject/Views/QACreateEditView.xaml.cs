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
//using LearningStudyProject.Commands;
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

        #region Fields

        private Dictionary<string, string> qaDictionary = new Dictionary<string, string>();
        //--------------------------Booleans---------------------------------------//
        // Edit mode is append to a new or existing file
        private bool appendToFile = false;
        // Edit mode is edit selected qa Pairs
        private bool editSelectedQAPairs = false;
        // Edit mode is edit All files Seriatem
        private bool editAllSeriatem = false;
        //--------------------------String---------------------------------------//


        private string imageURL = "";
        private string mp3URL = "";
        private string qaFilePath = "";
        private string currentQAPairStr = "";

        #endregion Fields

        #region Menu Items Click Methods


        #region Save File Click

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            // Enter Save File code here
            MessageBox.Show("Save File Clicked");
        }// End Save File Click
        #endregion Save File Click


        #region Begin a new QA File (NewFile_Click)

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {

            // Enter begin a new file code here
            MessageBox.Show("Begin a New File Clicked");
        }// End NewFile_Click
        #endregion NewFile_Click


        #region Append Questions and answers (Append_Click)

        private void Append_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Append Clicked");
        }// End Append_Click
        #endregion Append_Click


        #endregion Menu Items Click Methods
    }
}
