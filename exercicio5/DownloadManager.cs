namespace exercicio5
{
    internal class DownloadManager
    {
        public event Action<string> DownloadCompleted;
        public void iniciarDownload(string arquivo)
        {
            Console.WriteLine($"Download do arquivo -{arquivo}- iniciado!");
            Thread.Sleep(5000);
            DownloadCompleted(arquivo);
        }

        public void NotificarFimDownload(string arquivo)
        {
            Console.WriteLine($"O download do arquivo -{arquivo}- foi concluido");
        }
    }
}
