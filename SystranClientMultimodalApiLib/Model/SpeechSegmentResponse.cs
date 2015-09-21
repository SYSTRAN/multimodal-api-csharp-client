using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Systran.MultimodalClientLib.Model {

  /// <summary>
  /// Response of a Speech Segment request
  /// </summary>
  [DataContract]
  public class SpeechSegmentResponse {
    
    /* Array of channels */
    [DataMember(Name="channels", EmitDefaultValue=false)]
    public List<SpeechChannel> Channels { get; set; }

    
    /* Array of speakers */
    [DataMember(Name="speakers", EmitDefaultValue=false)]
    public List<SpeechSpeaker> Speakers { get; set; }

    
    /* Array of segments */
    [DataMember(Name="segments", EmitDefaultValue=false)]
    public List<SpeechSegment> Segments { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechSegmentResponse {\n");
      
      sb.Append("  Channels: ").Append(Channels).Append("\n");
      
      sb.Append("  Speakers: ").Append(Speakers).Append("\n");
      
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      
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