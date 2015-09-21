using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.MultimodalClientLib.Client;
using Systran.MultimodalClientLib.Model;

namespace Systran.MultimodalClientLib.Api {
  

  public interface ISpeechApi {
    
    /// <summary>
    /// Align speech Align text and audio files.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="TextFile">Plain text file, ASCII, ISO-8859 or UTF8 encoded.\n\nThe text should include one sentence or clause per line ending with a punctuation mark.\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechAlignResponse</returns>
    SpeechAlignResponse MultimodalSpeechAlignGet (string AudioFile, string TextFile, string Lang, string Model, string Sampling, string Callback);

    /// <summary>
    /// Align speech Align text and audio files.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="TextFile">Plain text file, ASCII, ISO-8859 or UTF8 encoded.\n\nThe text should include one sentence or clause per line ending with a punctuation mark.\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechAlignResponse</returns>
    Task<SpeechAlignResponse> MultimodalSpeechAlignGetAsync (string AudioFile, string TextFile, string Lang, string Model, string Sampling, string Callback);
    
    /// <summary>
    /// Speech language detection Detect languages from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechDetectLanguageResponse</returns>
    SpeechDetectLanguageResponse MultimodalSpeechDetectLanguageGet (string AudioFile, string Sampling, int? MaxSpeaker, string Callback);

    /// <summary>
    /// Speech language detection Detect languages from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechDetectLanguageResponse</returns>
    Task<SpeechDetectLanguageResponse> MultimodalSpeechDetectLanguageGetAsync (string AudioFile, string Sampling, int? MaxSpeaker, string Callback);
    
    /// <summary>
    /// Segment speech Segment an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSegmentResponse</returns>
    SpeechSegmentResponse MultimodalSpeechSegmentGet (string AudioFile, string Sampling, int? MaxSpeaker, string Callback);

    /// <summary>
    /// Segment speech Segment an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSegmentResponse</returns>
    Task<SpeechSegmentResponse> MultimodalSpeechSegmentGetAsync (string AudioFile, string Sampling, int? MaxSpeaker, string Callback);
    
    /// <summary>
    /// Supported Languages List of languages in which Speech is supported.\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSupportedLanguagesResponse</returns>
    SpeechSupportedLanguagesResponse MultimodalSpeechSupportedLanguagesGet (string Callback);

    /// <summary>
    /// Supported Languages List of languages in which Speech is supported.\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSupportedLanguagesResponse</returns>
    Task<SpeechSupportedLanguagesResponse> MultimodalSpeechSupportedLanguagesGetAsync (string Callback);
    
    /// <summary>
    /// Transcribe speech Get text from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechTranscribeResponse</returns>
    SpeechTranscribeResponse MultimodalSpeechTranscribeGet (string AudioFile, string Lang, string Model, string Sampling, int? MaxSpeaker, string Callback);

    /// <summary>
    /// Transcribe speech Get text from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechTranscribeResponse</returns>
    Task<SpeechTranscribeResponse> MultimodalSpeechTranscribeGetAsync (string AudioFile, string Lang, string Model, string Sampling, int? MaxSpeaker, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class SpeechApi : ISpeechApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="SpeechApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public SpeechApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SpeechApi"/> class.
    /// </summary>
    /// <returns></returns>
    public SpeechApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Align speech Align text and audio files.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="TextFile">Plain text file, ASCII, ISO-8859 or UTF8 encoded.\n\nThe text should include one sentence or clause per line ending with a punctuation mark.\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechAlignResponse</returns>
    public SpeechAlignResponse MultimodalSpeechAlignGet (string AudioFile, string TextFile, string Lang, string Model, string Sampling, string Callback) {

      
      // verify the required parameter 'AudioFile' is set
      if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechAlignGet");
      
      // verify the required parameter 'TextFile' is set
      if (TextFile == null) throw new ApiException(400, "Missing required parameter 'TextFile' when calling MultimodalSpeechAlignGet");
      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling MultimodalSpeechAlignGet");
      

      var path = "/multimodal/speech/align";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Model != null) queryParams.Add("model", apiClient.ParameterToString(Model)); // query parameter
       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      if (TextFile != null) fileParams.Add("textFile", TextFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechAlignGet: " + response.Content, response.Content);
      }
      return (SpeechAlignResponse) apiClient.Deserialize(response.Content, typeof(SpeechAlignResponse));
    }
	
	 /// <summary>
    /// Align speech Align text and audio files.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="TextFile">Plain text file, ASCII, ISO-8859 or UTF8 encoded.\n\nThe text should include one sentence or clause per line ending with a punctuation mark.\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechAlignResponse</returns>
    public async Task<SpeechAlignResponse> MultimodalSpeechAlignGetAsync (string AudioFile, string TextFile, string Lang, string Model, string Sampling, string Callback) {

      
          // verify the required parameter 'AudioFile' is set
          if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechAlignGet");
      
          // verify the required parameter 'TextFile' is set
          if (TextFile == null) throw new ApiException(400, "Missing required parameter 'TextFile' when calling MultimodalSpeechAlignGet");
      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling MultimodalSpeechAlignGet");
      

      var path = "/multimodal/speech/align";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Model != null) queryParams.Add("model", apiClient.ParameterToString(Model)); // query parameter
       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      if (TextFile != null) fileParams.Add("textFile", TextFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechAlignGet: " + response.Content, response.Content);
      }
      return (SpeechAlignResponse) apiClient.Deserialize(response.Content, typeof(SpeechAlignResponse));
    }
    
    /// <summary>
    /// Speech language detection Detect languages from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechDetectLanguageResponse</returns>
    public SpeechDetectLanguageResponse MultimodalSpeechDetectLanguageGet (string AudioFile, string Sampling, int? MaxSpeaker, string Callback) {

      
      // verify the required parameter 'AudioFile' is set
      if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechDetectLanguageGet");
      

      var path = "/multimodal/speech/detectLanguage";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechDetectLanguageGet: " + response.Content, response.Content);
      }
      return (SpeechDetectLanguageResponse) apiClient.Deserialize(response.Content, typeof(SpeechDetectLanguageResponse));
    }
	
	 /// <summary>
    /// Speech language detection Detect languages from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechDetectLanguageResponse</returns>
    public async Task<SpeechDetectLanguageResponse> MultimodalSpeechDetectLanguageGetAsync (string AudioFile, string Sampling, int? MaxSpeaker, string Callback) {

      
          // verify the required parameter 'AudioFile' is set
          if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechDetectLanguageGet");
      

      var path = "/multimodal/speech/detectLanguage";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechDetectLanguageGet: " + response.Content, response.Content);
      }
      return (SpeechDetectLanguageResponse) apiClient.Deserialize(response.Content, typeof(SpeechDetectLanguageResponse));
    }
    
    /// <summary>
    /// Segment speech Segment an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSegmentResponse</returns>
    public SpeechSegmentResponse MultimodalSpeechSegmentGet (string AudioFile, string Sampling, int? MaxSpeaker, string Callback) {

      
      // verify the required parameter 'AudioFile' is set
      if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechSegmentGet");
      

      var path = "/multimodal/speech/segment";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechSegmentGet: " + response.Content, response.Content);
      }
      return (SpeechSegmentResponse) apiClient.Deserialize(response.Content, typeof(SpeechSegmentResponse));
    }
	
	 /// <summary>
    /// Segment speech Segment an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSegmentResponse</returns>
    public async Task<SpeechSegmentResponse> MultimodalSpeechSegmentGetAsync (string AudioFile, string Sampling, int? MaxSpeaker, string Callback) {

      
          // verify the required parameter 'AudioFile' is set
          if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechSegmentGet");
      

      var path = "/multimodal/speech/segment";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechSegmentGet: " + response.Content, response.Content);
      }
      return (SpeechSegmentResponse) apiClient.Deserialize(response.Content, typeof(SpeechSegmentResponse));
    }
    
    /// <summary>
    /// Supported Languages List of languages in which Speech is supported.\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSupportedLanguagesResponse</returns>
    public SpeechSupportedLanguagesResponse MultimodalSpeechSupportedLanguagesGet (string Callback) {

      

      var path = "/multimodal/speech/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SpeechSupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SpeechSupportedLanguagesResponse));
    }
	
	 /// <summary>
    /// Supported Languages List of languages in which Speech is supported.\n
    /// </summary>
    /// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechSupportedLanguagesResponse</returns>
    public async Task<SpeechSupportedLanguagesResponse> MultimodalSpeechSupportedLanguagesGetAsync (string Callback) {

      

      var path = "/multimodal/speech/supportedLanguages";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechSupportedLanguagesGet: " + response.Content, response.Content);
      }
      return (SpeechSupportedLanguagesResponse) apiClient.Deserialize(response.Content, typeof(SpeechSupportedLanguagesResponse));
    }
    
    /// <summary>
    /// Transcribe speech Get text from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechTranscribeResponse</returns>
    public SpeechTranscribeResponse MultimodalSpeechTranscribeGet (string AudioFile, string Lang, string Model, string Sampling, int? MaxSpeaker, string Callback) {

      
      // verify the required parameter 'AudioFile' is set
      if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechTranscribeGet");
      
      // verify the required parameter 'Lang' is set
      if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling MultimodalSpeechTranscribeGet");
      

      var path = "/multimodal/speech/transcribe";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Model != null) queryParams.Add("model", apiClient.ParameterToString(Model)); // query parameter
       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechTranscribeGet: " + response.Content, response.Content);
      }
      return (SpeechTranscribeResponse) apiClient.Deserialize(response.Content, typeof(SpeechTranscribeResponse));
    }
	
	 /// <summary>
    /// Transcribe speech Get text from an audio file.\n
    /// </summary>
    /// <param name="AudioFile">Audio file ([details](#description_audio_files)).\n</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values))</param>/// <param name="Model">Model name\n</param>/// <param name="Sampling">Sampling quality of the audio file.\n * high: wide band audio such as radio and TV broadcast (sampling higher or equal to 16KHz)\n * low: telephone data with sampling rates higher or equal to 8KHz. It is highly recommended to not use a bit rate lower than 32Kbps.\n</param>/// <param name="MaxSpeaker">Maximum number of speakers. Default 1 for low sampling and infinity for high sampling</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>SpeechTranscribeResponse</returns>
    public async Task<SpeechTranscribeResponse> MultimodalSpeechTranscribeGetAsync (string AudioFile, string Lang, string Model, string Sampling, int? MaxSpeaker, string Callback) {

      
          // verify the required parameter 'AudioFile' is set
          if (AudioFile == null) throw new ApiException(400, "Missing required parameter 'AudioFile' when calling MultimodalSpeechTranscribeGet");
      
          // verify the required parameter 'Lang' is set
          if (Lang == null) throw new ApiException(400, "Missing required parameter 'Lang' when calling MultimodalSpeechTranscribeGet");
      

      var path = "/multimodal/speech/transcribe";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Model != null) queryParams.Add("model", apiClient.ParameterToString(Model)); // query parameter
       if (Sampling != null) queryParams.Add("sampling", apiClient.ParameterToString(Sampling)); // query parameter
       if (MaxSpeaker != null) queryParams.Add("maxSpeaker", apiClient.ParameterToString(MaxSpeaker)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (AudioFile != null) fileParams.Add("audioFile", AudioFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalSpeechTranscribeGet: " + response.Content, response.Content);
      }
      return (SpeechTranscribeResponse) apiClient.Deserialize(response.Content, typeof(SpeechTranscribeResponse));
    }
    
  }  
  
}
