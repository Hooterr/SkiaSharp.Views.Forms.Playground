using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SkiaPlayground.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string _sourceCode;

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            SourceCode = "using System;\r\nusing SkiaSharp;\r\n\r\nvoid Draw(SKCanvas canvas, int width, int height)\r\n{\r\n\tvar p = new SKPaint\r\n\t{\r\n\t\tColor = SKColors.Red,\r\n\t\tIsAntialias = true,\r\n\t\tStyle = SKPaintStyle.Stroke,\r\n\t\tStrokeWidth = 10\r\n\t};\r\n\r\n\tcanvas.DrawLine(20, 200, 100, 1050, p);\r\n}\r\n";
        }

        public ICommand OpenWebCommand { get; }

        public string SourceCode
        {
            get => _sourceCode;
            set => SetProperty(ref _sourceCode, value);
        }

    }
}