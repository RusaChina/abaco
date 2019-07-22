using System;
using Xamarin.Forms.Xaml;
using Abaco.Models;
using Abaco.Repository;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Abaco
{
    using Xamarin.Forms;
    using Abaco.Views;
    public partial class App : Application
    {
        #region Constructors
        public App(String Filename)
        {
            InitializeComponent();
            UsuarioRepositorio.Inicializador(Filename);
            this.MainPage = new NavigationPage (new AbacoTabbedPage());
        }
        #endregion
        #region Methods

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
