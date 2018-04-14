using FIAPMinhasReceitas.Models.Abstracts;
using FIAPMinhasReceitas.UWP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAPMinhasReceitas.UWP.ViewModels
{
    public class ConfiguracoesViewModel : NotifyableClass
    {
        private int? _ordemListaReceitasConfiguracao;

        public int? OrdemListaReceitasConfiguracao
        {
            get
            {
                return StorageService.LerConfiguracao(StorageService.Configuracoes.OrdemListaReceitas, 0);
            }
            set
            {
                StorageService.GravarConfiguracao(StorageService.Configuracoes.OrdemListaReceitas, value);
            }
        }
    }
}
