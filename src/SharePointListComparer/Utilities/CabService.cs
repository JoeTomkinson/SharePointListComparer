using Microsoft.Deployment.Compression.Cab;
using System.IO;

namespace SharePointListComparer.Utilities
{
    public class CabService
    {
        public string ExtractFromCabFile(string filePath, string destinationFolder)
        {
            CabInfo cab = new CabInfo(filePath);
            cab.Unpack(destinationFolder);
            var filepath = Directory.GetFiles(destinationFolder, "*.xml");
            return filepath[0];
        }
    }
}