using System;
using System.Collections.Generic;
using System.Text;


namespace Abaco.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attributes
       
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if(this.password != value)
                {
                    this.password = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.Password)));
                }
            }
        }

        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                if (this.isRunning != value)
                {
                    this.isRunning = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsRunning)));
                }
            }
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnable
        {
            get
            {
                return this.IsEnable;
            }
            set
            {
                if (this.isEnable != value)
                {
                    this.isEnable = value;
                    PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.IsEnable)));
                }
            }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnable = true;
        }
        #endregion

        #region Commands
        public ICommand IniciarCommand
        {
            get
            {
                return new RelayCommand(Iniciar);
            }
            
        }
  
       
        private async void Iniciar()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "Has Introducido mal tu correo", 
                    "Aceptar");
                return;
            }
            
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Has Introducido mal tu contraseña",
                    "Aceptar");
                return;
            }

            this.IsRunning = true;
            this.IsEnable = false;


            if (this.Email != "pvillatoro@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnable = true;
                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Correo o contreseña incorrecta",
                   "Aceptar");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnable = true;
            await Application.Current.MainPage.DisplayAlert(
                   "Ok",
                   "Fuck Yeah",
                   "Aceptar");
            return;
        }
        #endregion
    }
}
