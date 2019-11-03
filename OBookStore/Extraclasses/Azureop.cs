using System;
using Microsoft.Azure;
using System.Collections;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Auth;
using Microsoft.Azure.Storage.Blob;



namespace OBookStore.Extraclasses
{
    public class Azureop
    {

        CloudBlobClient cloudBlobClient = null;

        public Azureop()
        {
            var storageCredentials = new StorageCredentials("saobook", "IpK8E4oZt4rCRuufZMNgtg8GkC6iRPZX6xcYTEGGWNWLAiH2JFsJQ17KgEdckSH7peAgTIcoW706wKS0AvCS0A==");
            var cloudStorageAccount = new CloudStorageAccount(storageCredentials,true);
             cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

            
        }


        public CloudBlockBlob AzureReadBlobFiles()
        {

            var containerName = "html";
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);
            CloudBlockBlob blockBlob = cloudBlobContainer.GetBlockBlobReference("Er7vx.png");
            return blockBlob;

            
        }
    }
}
