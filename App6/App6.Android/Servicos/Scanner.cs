using System.Threading.Tasks;
using App6.Droid.Servicos;
using App6.Interfaces;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(Scanner))]
namespace App6.Droid.Servicos
{
    public class Scanner : IScan
    {
        public async Task<string> ScanAsync()
        {
            var opcao = new MobileBarcodeScanningOptions();

            opcao.PossibleFormats.Clear();
            opcao.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);            

            var scanner = new MobileBarcodeScanner
            {
                TopText = "Scaneando o QRCode",
                UseCustomOverlay = false

            };

            var resultadoScan = await scanner.Scan(opcao);
            return resultadoScan.Text;
        }
    }
}