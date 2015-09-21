using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Systran.MultimodalClientLib.Api;
using Systran.MultimodalClientLib.Client;
using Systran.MultimodalClientLib.Model;
namespace Systran.MultimodalClientLib.Api {
  

  public interface IFileApi {
    
    /// <summary>
    /// Extract text from a file Extract text from a file.\n
    /// </summary>
    /// <param name="InputFile">Input File</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values)) or `auto` for automatic detection</param>/// <param name="Format">Format of the input file.\n\nValid values are the mimetypes returned by the supportedFormats service.\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileExtractTextResponse</returns>
    FileExtractTextResponse MultimodalFileExtractTextGet (string InputFile, string Lang, string Format, int? Profile, string Callback);

    /// <summary>
    /// Extract text from a file Extract text from a file.\n
    /// </summary>
    /// <param name="InputFile">Input File</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values)) or `auto` for automatic detection</param>/// <param name="Format">Format of the input file.\n\nValid values are the mimetypes returned by the supportedFormats service.\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileExtractTextResponse</returns>
    Task<FileExtractTextResponse> MultimodalFileExtractTextGetAsync (string InputFile, string Lang, string Format, int? Profile, string Callback);
    
    /// <summary>
    /// Supported file formats Get a list of supported file formats.\n
    /// </summary>
    /// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileSupportedFormatsResponse</returns>
    FileSupportedFormatsResponse MultimodalFileSupportedFormatsGet (int? Profile, string Callback);

    /// <summary>
    /// Supported file formats Get a list of supported file formats.\n
    /// </summary>
    /// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileSupportedFormatsResponse</returns>
    Task<FileSupportedFormatsResponse> MultimodalFileSupportedFormatsGetAsync (int? Profile, string Callback);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class FileApi : IFileApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="FileApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public FileApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FileApi(String basePath)
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
    /// Extract text from a file Extract text from a file.\n
    /// </summary>
    /// <param name="InputFile">Input File</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values)) or `auto` for automatic detection</param>/// <param name="Format">Format of the input file.\n\nValid values are the mimetypes returned by the supportedFormats service.\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileExtractTextResponse</returns>
    public FileExtractTextResponse MultimodalFileExtractTextGet (string InputFile, string Lang, string Format, int? Profile, string Callback) {

      
      // verify the required parameter 'InputFile' is set
      if (InputFile == null) throw new ApiException(400, "Missing required parameter 'InputFile' when calling MultimodalFileExtractTextGet");
      

      var path = "/multimodal/file/extract/text";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalFileExtractTextGet: " + response.Content, response.Content);
      }
      return (FileExtractTextResponse) apiClient.Deserialize(response.Content, typeof(FileExtractTextResponse));
    }
	
	 /// <summary>
    /// Extract text from a file Extract text from a file.\n
    /// </summary>
    /// <param name="InputFile">Input File</param>/// <param name="Lang">Language code of the input ([details](#description_langage_code_values)) or `auto` for automatic detection</param>/// <param name="Format">Format of the input file.\n\nValid values are the mimetypes returned by the supportedFormats service.\n</param>/// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileExtractTextResponse</returns>
    public async Task<FileExtractTextResponse> MultimodalFileExtractTextGetAsync (string InputFile, string Lang, string Format, int? Profile, string Callback) {

      
          // verify the required parameter 'InputFile' is set
          if (InputFile == null) throw new ApiException(400, "Missing required parameter 'InputFile' when calling MultimodalFileExtractTextGet");
      

      var path = "/multimodal/file/extract/text";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Lang != null) queryParams.Add("lang", apiClient.ParameterToString(Lang)); // query parameter
       if (Format != null) queryParams.Add("format", apiClient.ParameterToString(Format)); // query parameter
       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      if (InputFile != null) fileParams.Add("inputFile", InputFile);
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalFileExtractTextGet: " + response.Content, response.Content);
      }
      return (FileExtractTextResponse) apiClient.Deserialize(response.Content, typeof(FileExtractTextResponse));
    }
    
    /// <summary>
    /// Supported file formats Get a list of supported file formats.\n
    /// </summary>
    /// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileSupportedFormatsResponse</returns>
    public FileSupportedFormatsResponse MultimodalFileSupportedFormatsGet (int? Profile, string Callback) {

      

      var path = "/multimodal/file/supportedFormats";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalFileSupportedFormatsGet: " + response.Content, response.Content);
      }
      return (FileSupportedFormatsResponse) apiClient.Deserialize(response.Content, typeof(FileSupportedFormatsResponse));
    }
	
	 /// <summary>
    /// Supported file formats Get a list of supported file formats.\n
    /// </summary>
    /// <param name="Profile">Profile id\n</param>/// <param name="Callback">Javascript callback function name for JSONP Support\n</param>
    /// <returns>FileSupportedFormatsResponse</returns>
    public async Task<FileSupportedFormatsResponse> MultimodalFileSupportedFormatsGetAsync (int? Profile, string Callback) {

      

      var path = "/multimodal/file/supportedFormats";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Profile != null) queryParams.Add("profile", apiClient.ParameterToString(Profile)); // query parameter
       if (Callback != null) queryParams.Add("callback", apiClient.ParameterToString(Callback)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "accessToken", "apiKey" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling MultimodalFileSupportedFormatsGet: " + response.Content, response.Content);
      }
      return (FileSupportedFormatsResponse) apiClient.Deserialize(response.Content, typeof(FileSupportedFormatsResponse));
    }
    
  }  
  
}
