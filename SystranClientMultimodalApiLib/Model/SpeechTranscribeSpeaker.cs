using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.MultimodalClientLib.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SpeechTranscribeSpeaker {
    
    /* Speaker id */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /* Channel id */
    [DataMember(Name="channel", EmitDefaultValue=false)]
    public int? Channel { get; set; }

    
    /* Speech duration (in seconds) */
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public double? Duration { get; set; }

    
    /* Gender */
    [DataMember(Name="gender", EmitDefaultValue=false)]
    public string Gender { get; set; }

    
    /* Speaker detected language ([details](#description_langage_code_values)) */
    [DataMember(Name="lang", EmitDefaultValue=false)]
    public string Lang { get; set; }

    
    /* Confidence for the detected language */
    [DataMember(Name="langConfidence", EmitDefaultValue=false)]
    public double? LangConfidence { get; set; }

    
    /* number of spoken words */
    [DataMember(Name="nbWords", EmitDefaultValue=false)]
    public int? NbWords { get; set; }

    
    /* Confidence for the text */
    [DataMember(Name="textConfidence", EmitDefaultValue=false)]
    public double? TextConfidence { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechTranscribeSpeaker {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      
      sb.Append("  LangConfidence: ").Append(LangConfidence).Append("\n");
      
      sb.Append("  NbWords: ").Append(NbWords).Append("\n");
      
      sb.Append("  TextConfidence: ").Append(TextConfidence).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}