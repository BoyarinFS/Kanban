using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class CommentDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "message")]
    public string message { get; set; }
    
    [JsonProperty(PropertyName = "owner")]
    public AccountBaseDto owner { get; set; }
}