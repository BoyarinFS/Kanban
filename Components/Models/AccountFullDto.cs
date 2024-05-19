using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class AccountFullDto
{
    [JsonProperty(PropertyName = "uuid")]
    public Int64 uuid { get; set; }
    
    [JsonProperty(PropertyName = "firstname")]
    public string firstname { get; set; }
    
    [JsonProperty(PropertyName = "lastname")]
    public string lastname { get; set; }
    
    [JsonProperty(PropertyName = "ownProjects")]
    public List<ProjectBaseDto> ownProjects { get; set; }
    
    [JsonProperty(PropertyName = "workingProjects")]
    public List<ProjectBaseDto> workingProjects { get; set; }
}