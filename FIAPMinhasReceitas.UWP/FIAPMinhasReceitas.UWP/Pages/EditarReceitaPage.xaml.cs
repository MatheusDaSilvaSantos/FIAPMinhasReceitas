using FIAPMinhasReceitas.UWP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAPMinhasReceitas.UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditarReceitaPage : Page
    {
        public EditarReceitaViewModel ViewModel { get; } = new EditarReceitaViewModel();

        public EditarReceitaPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            object parameter = e.Parameter;

            if (parameter == null || parameter is Guid)
            {
                if (parameter == null)
                {
                    parameter = Guid.NewGuid();
                }

                ViewModel.CarregarReceita((Guid)parameter);
            }
            else if (parameter is string)
            {
                WwwFormUrlDecoder uriDecoder = new WwwFormUrlDecoder(parameter.ToString());
                var rule = uriDecoder.GetFirstValueByName("rule");
                var tituloReceita = uriDecoder.GetFirstValueByName("tituloReceita");

                ViewModel.CarregarReceita(Guid.NewGuid());

                if (!string.IsNullOrWhiteSpace(rule))
                {
                    ViewModel.Receita.Titulo = tituloReceita;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (!ViewModel.RegistroExcluido)
                ViewModel.SalvarReceita();
        }
    }
}
