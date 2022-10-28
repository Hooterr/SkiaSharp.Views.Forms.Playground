using SkiaPlayground.Compiler;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkiaPlayground.Views
{
    public partial class AboutPage : ContentPage
    {
        private readonly Compiler.Compiler _compiler = new Compiler.Compiler();
        public AboutPage()
        {
            InitializeComponent();
        }
        private CompilationResult _result;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            compileButton.IsEnabled = false;
            _result = await _compiler.CompileAsync(editor.Text);
            compileButton.IsEnabled = true;
            
            if (_result.HasErrors == true)
            {
                BindableLayout.SetItemsSource(errors, _result.CompilationMessages);
            }
            else
            {
                canvas.InvalidateSurface();
            }

            scroll.IsVisible = _result.HasErrors;
        }

        private void canvas_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            if (_result == null || _result.CompilationMessages.Any())
            {
                return;
            }
            e.Surface.Canvas.Clear();
            _result.Draw(e.Surface, e.Info.Size);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            canvas.InvalidateSurface();
        }
    }
}