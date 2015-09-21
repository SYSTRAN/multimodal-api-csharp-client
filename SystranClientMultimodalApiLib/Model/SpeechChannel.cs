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
  public class SpeechChannel {
    
    /* Channel id */
    [DataMember(Name="id", EmitDefaultValue=false)]
    public int? Id { get; set; }

    
    /* Signal duration (in seconds) */
    [DataMember(Name="signalDuration", EmitDefaultValue=false)]
    public double? SignalDuration { get; set; }

    
    /* Speech duration (in seconds) */
    [DataMember(Name="speechDuration", EmitDefaultValue=false)]
    public double? SpeechDuration { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SpeechChannel {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  SignalDuration: ").Append(SignalDuration).Append("\n");
      
      sb.Append("  SpeechDuration: ").Append(SpeechDuration).Append("\n");
      
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