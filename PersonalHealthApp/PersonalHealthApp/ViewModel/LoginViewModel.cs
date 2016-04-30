using PersonalHealth.Models.AppModels;
using PersonalHealth.Services.Interfaces;
using PersonalHealthApp.Common;
using PersonalHealthServices.Impl.Impl;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PersonalHealthApp.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private Patient currentUser;

        public LoginViewModel()
        {
            currentUser = new Patient();
            loginCommand = new RelayCommand(Login);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }
        public Patient CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                NotifyPropertyChanged();
            }
        }
        private String loginStatus;
        public String LoginStatus
        {
            get
            {
                return loginStatus;
            }
            set
            {
                loginStatus = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]String propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private ICommand loginCommand;
        private ICommand toggleExecuteCommand { get; set; }
        private bool canExecute = true;

        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                this.canExecute = value;
            }
        }

        public ICommand ToggleExecuteCommand
        {
            get
            {
                return toggleExecuteCommand;
            }
            set
            {
                toggleExecuteCommand = value;
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                return loginCommand;
            }
            set
            {
                loginCommand = value;
            }
        }

        public void ChangeCanExecute()
        {
            canExecute = !canExecute;
        }

        public void Login()
        {
            IPatientService patientService = new PatientService();
            patientService.loginAsync(currentUser.Username, currentUser.Password);
        } 
    }
}
