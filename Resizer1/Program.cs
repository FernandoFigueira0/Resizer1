namespace Resizer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing resizer");

            Thread thread = new Thread(Resize);
            thread.Start();

            Console.ReadKey();
        }

        static void Resize()
        {

            #region "Directorys"
            string directoryFiles = "InputFiles";
            string finishedFiles = "FinishedFiles";
            string resizedFiles = "ResizedFiles";

            if (!Directory.Exists(directoryFiles))
            {
                Directory.CreateDirectory(directoryFiles);
            }

            if (!Directory.Exists(finishedFiles))
            {
                Directory.CreateDirectory(finishedFiles);
            }

            if (!Directory.Exists(resizedFiles))
            {
                Directory.CreateDirectory(resizedFiles);
            }
            #endregion

            while (true)
            {
                //look input files

                //if contains files, resize
                var inputFiles = Directory.EnumerateFiles(directoryFiles);

                int size = 200;

                foreach (var file in inputFiles)
                {
                    FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    FileInfo fileInfo = new FileInfo(file);
                }
            }

        }

    }
}
