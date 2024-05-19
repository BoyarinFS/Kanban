using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class ProjectBaseDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
}