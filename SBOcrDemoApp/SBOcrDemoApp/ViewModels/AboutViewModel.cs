using ScanbotSDK.Xamarin.Forms;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SBOcrDemoApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            CaptureCommand = new Command(async () => await ExecuteCaptureCommand());
        }

        public ICommand OpenWebCommand { get; }
        public ICommand CaptureCommand { get; }

        private string _extractedText;
        public string ExtractedText
        {
            get
            {
                return _extractedText;
            }
            set
            {
                _extractedText = value;
                OnPropertyChanged(nameof(ExtractedText));
            }
        }

        private async Task ExecuteCaptureCommand()
        {
            var config = new DocumentScannerConfiguration();
            var result = await SBSDK.UI.LaunchDocumentScannerAsync(config);
            if (result.Status == OperationResult.Ok)
            {
                var image = result.Pages[0].Document;


                var languages = new[] { "en", "la" }; // or specify more languages like { "en", "de", ... }
                var ocrResult = await SBSDK.Operations.PerformOcrAsync(result.Pages.Select(x => x.Document), languages);

                ExtractedText = ocrResult.Text;
                // See the recognized plain text of all images/pages via result.Text,
                // or get more details of each image/page via result.Pages:
                foreach (var ocrPage in ocrResult.Pages)
                {
                    //ocrPage.Paragraphs ...
                    //ocrPage.Lines ...
                    //ocrPage.Words ...
                    // example for words:
                    foreach (var wordBlock in ocrPage.Words)
                    {
                        //wordBlock.Text ...
                        //wordBlock.BoundingBox.X ...
                        //wordBlock.BoundingBox.Y ...
                        //wordBlock.BoundingBox.Width ...
                        //wordBlock.BoundingBox.Height ...
                    }
                }

            }
        }
    }
}