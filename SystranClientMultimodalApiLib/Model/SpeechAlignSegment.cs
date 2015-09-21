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
  public class SpeechAlignSegment {
    
    /* Channel id */
    [DataMember(Name="channel", EmitDefaultValue=false)]
    public int? Channel { get; set; }

    
    /* Start time (in seconds) */
    [DataMember(Name="start", EmitDefaultValue=false)]
    public double? Start { get; set; }

    
    /* End time (in seconds) */
    [DataMember(Name="end", EmitDefaultValue=false)]
    public double? End { get; set; }

    
    /* Detected language ([details](#description_langage_code_values)) */
    [DataMember(Name="lang", EmitDefaultValue=false)]
    public string Lang { get; set; }

    
    /* Confidence for the text */
    [DataMember(Name="textConfidence", EmitDefaultValue=false)]
    public double? TextConfidence { get; set; }

    
    /* Array of words */
    [DataMember(Name="words", EmitDefaultValue=false)]
    public List<SpeechWord> Words { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechAlignSegment {\n");
      
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      
      sb.Append("  Start: ").Append(Start).Append("\n");
      
      sb.Append("  End: ").Append(End).Append("\n");
      
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      
      sb.Append("  TextConfidence: ").Append(TextConfidence).Append("\n");
      
      sb.Append("  Words: ").Append(Words).Append("\n");
      
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