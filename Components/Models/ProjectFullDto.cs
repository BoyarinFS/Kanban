using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class ProjectFullDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "name")]
    public string name { get; set; }
    
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    
    [JsonProperty(PropertyName = "owner")]
    public AccountBaseDto owner { get; set; }
    
    [JsonProperty(PropertyName = "members")]
    public List<AccountBaseDto> members { get; set; }
    
    [JsonProperty(PropertyName = "panels")]
    public List<PanelDto> panels { get; set; }
}