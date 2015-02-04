using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connectivity.Plugin;
using Connectivity.Plugin.Abstractions;
using Xamarin.Forms;

namespace PumpingUnitApp
{
   public partial class ViewPumpingUnitPage : ContentPage
   {
      public ViewPumpingUnitPage()
      {
         InitializeComponent();
      }

      private void UpdateNetworkInfo(object sender, ConnectivityChangedEventArgs e)
      {
         ConnectionDetails.Text = CrossConnectivity.Current.ConnectionTypes.FirstOrDefault().ToString();
      }

      protected override void OnAppearing()
      {
         base.OnAppearing();

         ConnectionDetails.Text = CrossConnectivity.Current
             .ConnectionTypes.First().ToString();

         CrossConnectivity.Current.ConnectivityChanged += UpdateNetworkInfo;
      }

      protected override void OnDisappearing()
      {
         base.OnDisappearing();

         CrossConnectivity.Current.ConnectivityChanged -= UpdateNetworkInfo;
      }

      private void OnTestUrl(object sender, EventArgs e)
      {
         return;
      }
   }
}
