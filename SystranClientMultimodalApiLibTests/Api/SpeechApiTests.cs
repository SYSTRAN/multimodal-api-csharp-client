using Microsoft.VisualStudio.TestTools.UnitTesting;
using Systran.MultimodalClientLib.Api;
using Systran.MultimodalClientLib.Client;
using Systran.MultimodalClientLib.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Systran.MultimodalClientLib.Api.Tests
{
    [TestClass()]
    public class SpeechApiTests
    {
        private static ApiClient client;
        private static SpeechApi speechApi;

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
            speechApi = new SpeechApi(Configuration.apiClient);
        }

        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(speechApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void MultimodalSpeechAlignGetTest()
        {
            SpeechAlignResponse speechAlignResponse = new SpeechAlignResponse();
            speechAlignResponse = speechApi.MultimodalSpeechAlignGet("../../speech-lid.mp3", "../../test.txt", "en", null, null, null);
            Assert.IsNotNull(speechAlignResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechAlignGetAsyncTest()
        {
            SpeechAlignResponse speechAlignResponse = new SpeechAlignResponse();
            Task.Run(async () =>
            {
                speechAlignResponse = await speechApi.MultimodalSpeechAlignGetAsync("../../speech-lid.mp3", "align.txt", "en", null, null, null);
            }).Wait();
            Assert.IsNotNull(speechAlignResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechDetectLanguageGetTest()
        {
            SpeechDetectLanguageResponse speechDetectLanguageResponse = new SpeechDetectLanguageResponse();
            speechDetectLanguageResponse = speechApi.MultimodalSpeechDetectLanguageGet("../../speech-lid.mp3", null, null, null);
            Assert.IsNotNull(speechDetectLanguageResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechDetectLanguageGetAsyncTest()
        {
            SpeechDetectLanguageResponse speechDetectLanguageResponse = new SpeechDetectLanguageResponse();
            Task.Run(async () =>
            {
                speechDetectLanguageResponse = await speechApi.MultimodalSpeechDetectLanguageGetAsync("../../speech-lid.mp3", null, null, null);
            }).Wait();
            Assert.IsNotNull(speechDetectLanguageResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechSegmentGetTest()
        {
            SpeechSegmentResponse speechSegmentResponse = new SpeechSegmentResponse();
            speechSegmentResponse = speechApi.MultimodalSpeechSegmentGet("../../speech-lid.mp3", null, null, null);
            Assert.IsNotNull(speechSegmentResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechSegmentGetAsyncTest()
        {
            SpeechSegmentResponse speechSegmentResponse = new SpeechSegmentResponse();
            Task.Run(async () =>
            {
                speechSegmentResponse = await speechApi.MultimodalSpeechSegmentGetAsync("../../speech-lid.mp3", null, null, null);
            }).Wait();
            Assert.IsNotNull(speechSegmentResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechSupportedLanguagesGetTest()
        {
            SpeechSupportedLanguagesResponse speechSupportedLanguagesResponse = new SpeechSupportedLanguagesResponse();
            speechSupportedLanguagesResponse = speechApi.MultimodalSpeechSupportedLanguagesGet(null);
            Assert.IsNotNull(speechSupportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void MultimodalSpeechSupportedLanguagesGetAsyncTest()
        {
            SpeechSupportedLanguagesResponse speechSupportedLanguagesResponse = new SpeechSupportedLanguagesResponse();
            Task.Run(async () =>
            {
                speechSupportedLanguagesResponse = await speechApi.MultimodalSpeechSupportedLanguagesGetAsync(null);
            }).Wait();
            Assert.IsNotNull(speechSupportedLanguagesResponse.Languages);
        }

        [TestMethod()]
        public void MultimodalSpeechTranscribeGetTest()
        {
           SpeechTranscribeResponse speechTranscribeResponse = new SpeechTranscribeResponse();
            speechTranscribeResponse = speechApi.MultimodalSpeechTranscribeGet("speech-transcribe.mp3", "en", null, null, null, null);
           Assert.IsNotNull(speechTranscribeResponse.Segments);
        }

        [TestMethod()]
        public void MultimodalSpeechTranscribeGetAsyncTest()
        {
            SpeechTranscribeResponse speechTranscribeResponse = new SpeechTranscribeResponse();
            Task.Run(async () =>
            {
                speechTranscribeResponse = await speechApi.MultimodalSpeechTranscribeGetAsync("speech-transcribe.mp3", "en", null, null, null, null);
            }).Wait();
            Assert.IsNotNull(speechTranscribeResponse.Segments);
        }
    }
}