using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStudyProject.HelperClasses
{
    public static class QAFileStaticHelpers
    {
        #region Properties 

        #region QADictionary

        private static Dictionary<string,string> _QADictionary;

        public static Dictionary<string,string> QADictionary
        {
            get { return _QADictionary; }
            set { _QADictionary = value; }
        }
        #endregion QADictionary


        #region CurrentQNumber

        private static int _CurrentQNumber =0;

        public static int CurrentQNumber
        {
            get { return _CurrentQNumber; }
            set { _CurrentQNumber = value; }
        }
        #endregion CurrentQNumber

        #region QAOutputString

        private static string _QAOutputString;

        private static string NewLineChars = "\r\n";

        public static string QAOutputString
        {
            get { return _QAOutputString; }
            set 
            {
                _QAOutputString = value;
                // replace \r\n with ~
                _QAOutputString = _QAOutputString.Replace(NewLineChars, "~");
                QAOutputStringsList.Add(_QAOutputString);
            }
        }

        #endregion QAOutputString

        #region QAOutputStringsList

        private static List<string>  _QAOutputStringLists = new List<string>();

        public static List<string> QAOutputStringsList
        {
            get { return _QAOutputStringLists; }
            set { _QAOutputStringLists = value; }
        }

        #endregion QAOutputStringsList

        private static string QADirectoryPath = SubjectStaticMembers.HomeFolderPath + "\\QAFiles";
        private static string IDTitleTextFilePath = SubjectStaticMembers.HomeFolderPath + "\\ID-TitleText.txt";

        #endregion Properties

        public static void OpenQAFiles()
        {
            CreateOpenQADirectory();
            CreateOpenIDTitleTextfile();
        }

        #region Public Methods


        #endregion Public Method

        #region Private Methods

        // If the QA File Directory doesn't exist create it
       
        
        private static void CreateOpenQADirectory()
        {
            if (!Directory.Exists(QADirectoryPath))
            {
                Directory.CreateDirectory(QADirectoryPath);
            }
        }

        private static void CreateOpenIDTitleTextfile()
        {
            if (!File.Exists(IDTitleTextFilePath))
            {
                FileStream fileStream = File.Create(IDTitleTextFilePath);
            }
        }


        #endregion Private Methods


    }// End QAFileStaticHelpers
}
