using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.MultimodalClientLib.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.MultimodalClientLib.Client;
using Systran.MultimodalClientLib.Model;
using System.IO;
using System.Diagnostics;

namespace Systran.MultimodalClientLib.Api.Tests
{
    [TestClass()]
    public class FileApiTests
    {
        private static ApiClient client;
        private static FileApi fileApi;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key); Configuration.apiKey = keys; Configuration.apiKey = keys;
            Configuration.apiKey = keys;
            fileApi = new FileApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(fileApi.apiClient.basePath, typeof(string));
            String test = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Trace.WriteLine(test);
        }

        [TestMethod()]
        public void MultimodalFileExtractTextGetTest()
        {
            // string input = Convert.ToBase64String(File.ReadAllBytes("test.txt"));

            FileExtractTextResponse fileExtractTextResponse = new FileExtractTextResponse();
            fileExtractTextResponse = fileApi.MultimodalFileExtractTextGet("../../test.txt", "en", null, null, null);
            Assert.IsNotNull(fileExtractTextResponse.Text);
        }

        [TestMethod()]
        public void MultimodalFileExtractTextGetAsyncTest()
        {
            FileExtractTextResponse fileExtractTextResponse = new FileExtractTextResponse();
            Task.Run(async () =>
            {
                fileExtractTextResponse = await fileApi.MultimodalFileExtractTextGetAsync("../../test.txt", "en", null, null, null);
            }).Wait();
            Assert.IsNotNull(fileExtractTextResponse.Text);
        }

        [TestMethod()]
        public void MultimodalFileSupportedFormatsGetTest()
        {
            String test = System.Reflection.Assembly.GetExecutingAssembly().Location;

            Trace.WriteLine(test);

            FileSupportedFormatsResponse fileSupportedFormatsResponse = new FileSupportedFormatsResponse();
            fileSupportedFormatsResponse = fileApi.MultimodalFileSupportedFormatsGet(null, null);
            Assert.IsNotNull(fileSupportedFormatsResponse.Formats);
        }

        [TestMethod()]
        public void MultimodalFileSupportedFormatsGetAsyncTest()
        {
            FileSupportedFormatsResponse fileSupportedFormatsResponse = new FileSupportedFormatsResponse();
            Task.Run(async () =>
            {
                fileSupportedFormatsResponse = await fileApi.MultimodalFileSupportedFormatsGetAsync(null, null);
            }).Wait();
            Assert.IsNotNull(fileSupportedFormatsResponse.Formats);
        }
    }
}