using System.Threading.Tasks;

namespace App6.Interfaces
{
    public interface IScan
    {
        Task<string> ScanAsync();
    }
}
