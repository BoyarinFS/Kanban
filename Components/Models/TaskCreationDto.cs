using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class TaskCreationDto
{
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    
    [JsonProperty(PropertyName = "description")]
    public string deskription { get; set; }
    
    [JsonProperty(PropertyName = "deadline")]
    public DateTime deadline { get; set; }
    
    [JsonProperty(PropertyName = "color")]
    public string color { get; set; }
    
    [JsonProperty(PropertyName = "panelId")]
    public Int64 panelId { get; set; }
}