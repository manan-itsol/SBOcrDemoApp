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
  "khh43nd/veiDhZA1R1R51daQFTn4Fj" +
  "dkSWSIilXBOmL5t++/Zw/d2MPFwGYY" +
  "V92mCdwqAtRLqYpwbNUr1puevjqgbz" +
  "KaiaKor30e7aIIbkXWz4mBQ873ZRP+" +
  "kzT1V6tCttZYUVkzpOPtwcPJyYpEOI" +
  "BvSBkQHI+SCMyNsNRCk3VPPb9CJjnS" +
  "F2+DnWk0MNOHv9WJsHlAYeX6OFmHgH" +
  "jZucnAJQyRWWxfugmgoOXxG742xrzV" +
  "50O4L1EwmHit8WH4F6y1Qp4Ht/gNq6" +
  "AmtrO/Z6iqj0T47KzSQdTvVs3HkvrV" +
  "64aeX17lLHHmONB+RKBuqB3dJsZZC+" +
  "rYZsvVzT3Xyg==\nU2NhbmJvdFNESw" +
  "pjb20uZGVtbzExLnNib2NyZGVtb2Fw" +
  "cAoxNjQ4Njg0Nzk5CjgzODg2MDcKMw" +
  "==\n";


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