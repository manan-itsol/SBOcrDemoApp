using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using ScanbotSDK.Xamarin.Forms;

namespace SBOcrDemoApp.Droid
{
    [Activity(Label = "SBOcrDemoApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            const string LICENSE_KEY =
  "A3DQdaSlrCotN4ctoEjTRUAkagqjOr" +
  "uuHkipFnL1LtPpAiazzGrTqaXB2IJA" +
  "ZNLo2R1jytf82ENYlLuAFvcvh5WtCQ" +
  "h9VY9uyDKm+bMtbPvEDpPCYmqWDQ6F" +
  "QbCRqPoej2L5bE29yDhBqwkrz9JBxH" +
  "ogUGhOtjxAuLu/qWsCWd/1OXsIi2Jy" +
  "U1Uw1dlHrq4AzLflKrJxRd9hjqCdvE" +
  "7x7m/psi1UohfgVmN7adQk+h84D901" +
  "Fr/jRQFRsxxGxvZPi8JpII2301cdre" +
  "C+vqxGT2nuB7CC857OlRA5OddC8wwe" +
  "6oVj+vZujNDR0nVRpW2EEPEEPAvLzS" +
  "X0hEc52SjQOA==\nU2NhbmJvdFNESw" +
  "pjb20uY29tcGFueW5hbWUuc2JvY3Jk" +
  "ZW1vYXBwCjE2NDU0ODc5OTkKODM4OD" +
  "YwNwoz\n";
            // You can pass null as licenseKey for trial mode. See the "License" section for more details.
            SBSDKInitializer.Initialize(Application, LICENSE_KEY, new SBSDKConfiguration { EnableLogging = true });

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}