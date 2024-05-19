using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class TaskDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    
    [JsonProperty(PropertyName = "deadline")]
    public DateTime dealine { get; set; }
    
    [JsonProperty(PropertyName = "color")]
    public string color { get; set; }
    
    [JsonProperty(PropertyName = "comments")]
    public List<CommentDto> comments { get; set; }
    
    [JsonProperty(PropertyName = "accounts")]
    public List<AccountBaseDto> accounts { get; set; }
}