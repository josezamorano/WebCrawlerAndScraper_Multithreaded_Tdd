using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper.DataAccessLayer.IOFiles
{
    public class DirectoryProvider : IDirectoryProvider
    {
        public static SemaphoreSlim semaphore9 = new SemaphoreSlim(1,1);
        public bool CreateDirectoryIfNotExist(string directoryFullPath)
        {
            semaphore9.Wait();
            try
            {
                if (!Directory.Exists(directoryFullPath))
                {
                    Directory.CreateDirectory(directoryFullPath);
                }
                return true;
            }
            catch(Exception ex) 
            { 
                return false;
            }
            finally { semaphore9.Release(); }            
        }

        public string[] DirectoryGetFiles(string filePath)
        {
            semaphore9.Wait();
            try
            {
               string[] allFiles = Directory.GetFiles(filePath);
                return allFiles;
            }
            catch(Exception ex) 
            {
                return new string[0];
            }
            finally { semaphore9.Release(); }
        }

        public string[] DirectoryGetDirectories(string folderFullPath)
        {
            semaphore9.Wait();
            try
            {
                string[] allDirectories = Directory.GetDirectories(folderFullPath);
                return allDirectories;
            }
            catch(Exception ex) 
            { 
                return new string[0];
            }
            finally { semaphore9.Release(); }
        }
    }
}
