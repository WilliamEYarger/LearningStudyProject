//using LearningStudyProject.Commands;
using System.Windows.Input;

namespace LearningStudyProject.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        private BaseViewModel _QACreateEditViewModel;

        public BaseViewModel QACreateEditViewMode
        {
            get { return _QACreateEditViewModel; }
            set 
            { 
                _QACreateEditViewModel = value;

                OnPropertyChanged(nameof(QACreateEditViewMode));
            }
        }


        private BaseViewModel _AnswerQuestionsViewModel;

        public BaseViewModel AnswerQuestionsViewModel
        {
            get { return _AnswerQuestionsViewModel; }
            set 
            { 
                _AnswerQuestionsViewModel = value;
                OnPropertyChanged(nameof(AnswerQuestionsViewModel));

            }
        }


        private int _SelectedNodeID;

        public int SelectedNodeID
        {
            get { return _SelectedNodeID; }
            set { _SelectedNodeID = value; }
        }


        public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
           // UpdateViewCommand = new UpdateViewCommand(this);
        }

        public MainViewModel(int ID)
        {
            this.SelectedNodeID = ID;
        }

    }
}
