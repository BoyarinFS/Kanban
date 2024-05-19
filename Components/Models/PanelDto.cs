using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class PanelDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    
    [JsonProperty(PropertyName = "tasks")]
    public List<TaskDto> tasks { get; set; }
}