using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace tempApp
{
    public static class NetworkHandler
    {
       static private Boolean  download_file_from_url(String url, FileInfo file)
        {
            var client = new WebClient();
            try
            {
                client.DownloadFile(url, file.FullName);

            }
            catch (Exception)
            {

                throw;
            }

            return true;
        
        }


        static private Boolean checksum_files(FileInfo localFile, FileInfo downloadedFile)
        {
            byte[] fileHash1, fileHash2;
            FileStream stream1 = new FileStream(
            localFile.FullName,
            System.IO.FileMode.Open,
            System.IO.FileAccess.Read,
            System.IO.FileShare.ReadWrite);
            FileStream stream2 = new FileStream(
           downloadedFile.FullName,
           System.IO.FileMode.Open,
           System.IO.FileAccess.Read,
           System.IO.FileShare.ReadWrite);


            using (SHA256Managed sha = new SHA256Managed())
            {
                fileHash1 = sha.ComputeHash(stream1);
                fileHash2 = sha.ComputeHash(stream2);
            }

            for (int i = 0; (i < fileHash1.Length) && (i < fileHash2.Length); i++)
            {
                if (fileHash1[i] != fileHash2[i])
                {
                    //files are not same
                    throw new Exception();
                    
                }
            }
            return true;
        }

    }
}
