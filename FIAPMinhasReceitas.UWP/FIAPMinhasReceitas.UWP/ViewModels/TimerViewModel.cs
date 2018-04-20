using FIAPMinhasReceitas.Models.Abstracts;
using FIAPMinhasReceitas.UWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class TimerViewModel : NotifyableClass
    {
        private TimeSpan timeNotificacao;
        public TimeSpan TimeNotificacao
        {
            get { return timeNotificacao; }
            set { Set(ref timeNotificacao, value); }
        }

        public async void AtivarTimer()
        {
            NotificationService.AgendarToastNotification(timeNotificacao);

            ContentDialog dialog = new ContentDialog()
            {
                Content = "Timer agendado com sucesso",
                CloseButtonText = "Fechar"
            };

            await dialog.ShowAsync();
        }
    }
}
