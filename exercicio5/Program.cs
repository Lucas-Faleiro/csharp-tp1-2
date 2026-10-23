namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DownloadManager downloadManager = new DownloadManager();
            downloadManager.DownloadCompleted += downloadManager.NotificarFimDownload;

            Console.WriteLine("=== Download de arquivos fictícios ===");
            string arquivo = "fictício.zip";
            downloadManager.iniciarDownload(arquivo);
        }
    }
}