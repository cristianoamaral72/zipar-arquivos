using System;
using System.IO;
using System.IO.Compression;

namespace ZipArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\";
            //ZiparPastaArquivos(path);
            DiziparPastaArquivos(path);
        }

        private static void ZiparPastaArquivos(string path)
        {
            string sourceDirctoty = $"{path}Documentos\\Arquivos MP3";

            if (Directory.Exists(sourceDirctoty))
            {
                string archiveName = $"{path}Documentos\\DocumetosArchive.zip";
                if (!File.Exists(archiveName))
                {
                    ZipFile.CreateFromDirectory(sourceDirctoty, archiveName, CompressionLevel.Optimal, false);
                }
            }
        }

        private static void DiziparPastaArquivos(string path)
        {
            string destinationDirectory = $"{path}Documentos\\DocumentsUnzipped";

            if (Directory.Exists(path))
            {
                string archiveName = $"{path}Documentos\\DocumetosArchive.zip";
                if (File.Exists(archiveName))
                {
                    ZipFile.ExtractToDirectory(archiveName, destinationDirectory);
                }
            }
        }
    }
}
