using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new AcrUserDialogsPage();
            //MainPage = new StackLayoutPage();
            //MainPage = new GridLayoutPage();
            //MainPage = new AbsoluteLayoutPage();
            MainPage = new RelativeLayoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
