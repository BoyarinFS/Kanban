using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class ProjectCreationDto
{
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }

    [JsonProperty(PropertyName = "accountId")]
    public Int64 accountId { get; set; }
}