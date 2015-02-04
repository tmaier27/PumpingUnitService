using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connectivity.Plugin;
using Xamarin.Forms;

namespace PumpingUnitApp
{
   public class App : Application
   {
      public App()
      {
         // The root page of your application
         if (CrossConnectivity.Current.IsConnected)
            MainPage = new ViewPumpingUnitPage();
         else
            MainPage = new NoNetworkPage();
      }

      protected override void OnStart()
      {
         // Handle when your app starts
         CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
      }

      private void HandleConnectivityChanged(object sender, Connectivity.Plugin.Abstractions.ConnectivityChangedEventArgs e)
      {
         Type currentPage = this.MainPage.GetType();
         if (e.IsConnected && currentPage != typeof(ViewPumpingUnitPage))
            this.MainPage = new ViewPumpingUnitPage();
         else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
            this.MainPage = new NoNetworkPage();
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}
