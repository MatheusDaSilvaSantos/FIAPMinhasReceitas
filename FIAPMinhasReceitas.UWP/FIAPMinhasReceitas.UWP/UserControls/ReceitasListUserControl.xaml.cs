using FIAPMinhasReceitas.Models;
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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace FIAPMinhasReceitas.UWP.UserControls
{
    public sealed partial class ReceitasListUserControl : UserControl
    {
        public ReceitasListUserControl()
        {
            this.InitializeComponent();
        }


        public Receita Receita
        {
            get { return (Receita)GetValue(ReceitaProperty); }
            set { SetValue(ReceitaProperty, value); }
        }

        public static readonly DependencyProperty ReceitaProperty =
            DependencyProperty.Register("Receita", typeof(Receita), typeof(ReceitasListUserControl), new PropertyMetadata(null));

    }
}
