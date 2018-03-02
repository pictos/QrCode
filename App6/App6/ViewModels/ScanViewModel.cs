using App6.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class ScanViewModel : BaseViewModel
    {
        public Command ScanCommand { get; }

        public ScanViewModel()
        {
            ScanCommand = new Command(async () => await ExecuteScanCommand());
        }

        async Task ExecuteScanCommand()
        {
            var scanner = DependencyService.Get<IScan>();
            var result = await scanner.ScanAsync();

            if (result != null)
                await DisplayAlert("Resultado", result, "Ok");
        }
    }
}
