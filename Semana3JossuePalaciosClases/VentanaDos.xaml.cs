using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3JossuePalaciosClases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaDos : ContentPage
    {
        public VentanaDos(string usuario, string contraseña)
        {
            InitializeComponent();
            lblUser.Text = usuario;
            lblPass.Text = contraseña;
        }
    }
}