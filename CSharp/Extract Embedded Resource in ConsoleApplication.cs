namespace ExampleApp
{
    class ExampleClass
    {
        public static void Main()
        {
            //Resourse info
            string extractPath = "C:\\Folder\\YourResource.zip";
            string resourceName = "YourResource.zip";

            //Getting assembly resources
            var myAssembly = Assembly.GetExecutingAssembly();
            string fullResourceName = $"{myAssembly.GetName().Name}.{resourceName.Replace('\\', '.')}";

            //Searching and extracting resource
            if (!myAssembly.GetManifestResourceNames().Contains(fullResourceName));
            {
                using Stream wstream = File.Create(rEFIndBin);
                using Stream rstream = myAssembly.GetManifestResourceStream(fullResourceName);
                rstream.CopyTo(wstream);
            }
            else
                throw new Exception("Assembly resource not found")
        }
    }
}
