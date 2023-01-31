using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper.DataAccessLayer.IOFiles
{
   
    public class PathProvider : IPathProvider
    {
        private static SemaphoreSlim semaphore10 = new SemaphoreSlim(1, 1);
        public string GetFileNameFromPath(string fullFilePath)
        {
            semaphore10.Wait();
            try
            {
                var fileName = Path.GetFileName(fullFilePath);
                return fileName;
            }
            finally { semaphore10.Release(); }           
        }
    }
}
