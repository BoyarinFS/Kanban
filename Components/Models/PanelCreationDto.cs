using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class PanelCreationDto
{
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }

    [JsonProperty(PropertyName = "projectId")]
    public Int64 projectId { get; set; }
}