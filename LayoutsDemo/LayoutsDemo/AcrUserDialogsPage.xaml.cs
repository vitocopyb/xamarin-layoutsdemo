using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcrUserDialogsPage : ContentPage
    {
        private bool cancelada;

        public AcrUserDialogsPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Analizando");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
            }

            UserDialogs.Instance.HideLoading();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            using (IProgressDialog dialog = UserDialogs.Instance.Progress("Procesando"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    await Task.Delay(500);
                    dialog.PercentComplete = i * 10;
                }
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            cancelada = false;

            using (IProgressDialog dialog = UserDialogs.Instance.Progress("Procesando", () => cancelada = true, "Cancelar"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    await Task.Delay(500);
                    if (!cancelada)
                    {
                        dialog.PercentComplete = i * 10;
                    }
                    else
                    {
                        i = 10;
                        dialog.Dispose();
                    }
                }
            }
        }
    }
}