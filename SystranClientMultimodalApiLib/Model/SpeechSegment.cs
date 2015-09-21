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
  public class SpeechSegment {
    
    /* Channel id */
    [DataMember(Name="channel", EmitDefaultValue=false)]
    public int? Channel { get; set; }

    
    /* Speaker id */
    [DataMember(Name="speaker", EmitDefaultValue=false)]
    public string Speaker { get; set; }

    
    /* Confidence for the detected speaker */
    [DataMember(Name="speakerConfidence", EmitDefaultValue=false)]
    public double? SpeakerConfidence { get; set; }

    
    /* Start time (in seconds) */
    [DataMember(Name="start", EmitDefaultValue=false)]
    public double? Start { get; set; }

    
    /* End time (in seconds) */
    [DataMember(Name="end", EmitDefaultValue=false)]
    public double? End { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechSegment {\n");
      
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      
      sb.Append("  Speaker: ").Append(Speaker).Append("\n");
      
      sb.Append("  SpeakerConfidence: ").Append(SpeakerConfidence).Append("\n");
      
      sb.Append("  Start: ").Append(Start).Append("\n");
      
      sb.Append("  End: ").Append(End).Append("\n");
      
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