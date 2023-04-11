using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainForm : ContentPage
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnstart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Converter());

        }
    }
}