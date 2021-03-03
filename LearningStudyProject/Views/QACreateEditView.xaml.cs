using System;
using System.Collections.Generic;
using System.IO;
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
using LearningStudyProject.DataModels;
using LearningStudyProject.HelperClasses;
using LearningStudyProject.ViewModels;

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

        QACreateEditView ThisQACreateEditView; 
        #region Properties

        #region qaDictionary

        /// <summary>
        /// This dictionary contains the question and answer strings
        /// for a particular subject
        /// The key is an int which represents the question number
        /// the value is a ^ delimited string where the components are:
        ///     the QuestionNumberInt to string
        ///     the question
        ///     the answer
        ///     a Image .jpg URL
        ///     a sound .mp3 URL
        /// </summary>
        private static Dictionary<int, string> _qaDictionary;

        public static Dictionary<int, string> qaDictionary
        {
            get { return _qaDictionary; }
            set { _qaDictionary = value; }
        }

        #endregion qaDictionary

        //string QAFilePath;
        #endregion Properties

        #region OnLoaded Method

        /// <summary>
        /// Check to see if the QAFiles Directory exists and if 
        ///     not, create it.
        /// Check to see if a QA file with the name Q"DataNode's ID".txtx
        ///     exists and if not create it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            QAFileStaticHelpers.OpenQAFiles();

            //// If the QA File Directory doesn't exist create it
            //string QADirectoryPath = SubjectStaticMembers.HomeFolderPath + "\\QAFiles";
            //if (!Directory.Exists(QADirectoryPath))
            //{
            //    Directory.CreateDirectory(QADirectoryPath);
            //}

            ////Get the selected DataNode
            //SubjectNodes DataNode = SubjectStaticMembers.DataNode;

            ////Convert its ID into the QAFile name
            //string DataNodeName = DataNode.ID.ToString();

            ////If the Data node QA File doesn't exist create it
            //QAFilePath = QADirectoryPath + "\\Q" + DataNodeName+".txt";
            //if (!File.Exists(QAFilePath))
            //{
            //    FileStream fileStream = File.Create(QAFilePath);
            //}

            //// Make sure the ID-TitleText file exists

            //if(!File.Exists(QADirectoryPath+ "\\ID-TitleTex.txt"))
            //{
            //    FileStream fileStream = File.Create(QADirectoryPath + "\\ID-TitleTex.txt");
            //}

            ThisQACreateEditView = new QACreateEditView();
        }// End UserControl OnLoaded Method
        #endregion OnLoaded Method

        #region Fields

       
        //--------------------------Booleans---------------------------------------//
       
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
            /*
                File.WriteAllLines(filePath, either a string[] or an IEnumerable of string such as a List<string>
                For above it would be
                File.WriteAllLines((@"C:\Users\Public\TestFolder\WriteText.txt",lines);
                You could add to the List<string.> lines before writing ie>
                lines.Add(text, text); and then write the updated List to the file
             */

            // Write QAOutputStringsList to output file

            //List<string> QAOutputStrings = QAFileStaticHelpers.QAOutputStringsList;
            //File.WriteAllLines(QAFilePath, QAOutputStrings);
            QAFileStaticHelpers.SaveFiles();

        }// End Save File Click
        #endregion Save File Click


        #region Begin a new QA File (NewFile_Click)

        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            QACreateEditView ThisQACreateEditView = new QACreateEditView();
            int CurrentQANumber = QAFileStaticHelpers.CurrentQNumber;
            ThisQACreateEditView.tbkCurrentQuestionNumber.Text = CurrentQANumber.ToString();
        }
        #endregion NewFile_Click
         

        #region Append Questions and answers (Append_Click)

        private void Append_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Append Clicked");
        }// End Append_Click
        #endregion Append_Click

        #endregion Menu Items Click Methods


        #region Images and Sounds menu

        private void miQuestionJpgUrl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("miQuestionJpgUrl_Click");
        }

        private void miAnswerJpgUrl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("miAnswerJpgUrl_Click");
        }

        private void miQuestionMp3Url_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("miQuestionMp3Url_Click");
        }

        private void miAnswerMp3Url_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("miAnswerMp3Url_Click");
        }
        #endregion Images and Sounds menu

        private void btnGetNextQA_Click(object sender, RoutedEventArgs e)
        {
            string ThisQuestion = tbxQuestion.Text;
            string ThisAnswser = tbxAnswer.Text;
            int CurrentQANum = QAFileStaticHelpers.CurrentQNumber;
            string CurrentQANumString = CurrentQANum.ToString();
            QAFileStaticHelpers.QAOutputString = CurrentQANumString + '^' + ThisQuestion + SubjectStaticMembers.D1+ ThisAnswser + '^' + '^';
            CurrentQANum++;
            QAFileStaticHelpers.CurrentQNumber = CurrentQANum;
            tbkCurrentQuestionNumber.Text = CurrentQANum.ToString();
            tbxQuestion.Text = "";
            tbxAnswer.Text = "";
            ThisQACreateEditView.tbxQuestion.Text = "";
            ThisQACreateEditView.tbxAnswer.Text = "";
            ThisQACreateEditView.tbkCurrentQuestionNumber.Text = CurrentQANum.ToString();
        }
        
    }
}
