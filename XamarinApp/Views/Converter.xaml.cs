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
	public partial class Converter : ContentPage
	{
		double cm;
		double m;

		public Converter ()
		{
			InitializeComponent ();//shows us the frontend part
        }
		private void CalculateLength()
		{
			cm = Convert.ToDouble(txtcm.Text);
			m = cm / 100;
			lbloutcome.Text = m.ToString() + " m";
		}
		private void Validate()
		{
			if(!string.IsNullOrEmpty(txtcm.Text))
			{
				CalculateLength();
			}
			else
			{
				DisplayAlert("Error", "Please enter a value for conversion","ok");
			}
		}
        private void btnback_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();	
        }

        private void btnconvert_Clicked(object sender, EventArgs e)
        {
			Validate();

        }
    }
}