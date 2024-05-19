using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class AccountBaseDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "firstname")]
    public string firstname { get; set; }
    
    [JsonProperty(PropertyName = "lastname")]
    public string lastname { get; set; }
}