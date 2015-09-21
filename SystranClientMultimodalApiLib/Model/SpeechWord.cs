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
  public class SpeechWord {
    
    /* Start time (in seconds) */
    [DataMember(Name="start", EmitDefaultValue=false)]
    public double? Start { get; set; }

    
    /* Duration (in seconds) */
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public double? Duration { get; set; }

    
    /* Confidence */
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    public double? Confidence { get; set; }

    
    /* Word text */
    [DataMember(Name="text", EmitDefaultValue=false)]
    public string Text { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechWord {\n");
      
      sb.Append("  Start: ").Append(Start).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      
      sb.Append("  Text: ").Append(Text).Append("\n");
      
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