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
  public class SpeechTranscribeSegment {
    
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

    
    /* Detected language ([details](#description_langage_code_values)) */
    [DataMember(Name="lang", EmitDefaultValue=false)]
    public string Lang { get; set; }

    
    /* Confidence for the detected language */
    [DataMember(Name="langConfidence", EmitDefaultValue=false)]
    public double? LangConfidence { get; set; }

    
    /* Array of words */
    [DataMember(Name="words", EmitDefaultValue=false)]
    public List<SpeechWord> Words { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechTranscribeSegment {\n");
      
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      
      sb.Append("  Speaker: ").Append(Speaker).Append("\n");
      
      sb.Append("  SpeakerConfidence: ").Append(SpeakerConfidence).Append("\n");
      
      sb.Append("  Start: ").Append(Start).Append("\n");
      
      sb.Append("  End: ").Append(End).Append("\n");
      
      sb.Append("  Lang: ").Append(Lang).Append("\n");
      
      sb.Append("  LangConfidence: ").Append(LangConfidence).Append("\n");
      
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