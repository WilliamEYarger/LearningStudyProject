using LearningStudyProject.ViewModels;
using System;
using System.Windows.Input;

namespace LearningStudyProject.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "SubjectTree")
            {
                viewModel.SelectedViewModel = new SubjectsTreeViewModel();
            }
            else if (parameter.ToString() == "QACreateEdit")
            {
                viewModel.SelectedViewModel = new QACreateEditViewModel();
            }
        }
    }
}
