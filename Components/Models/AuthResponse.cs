using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class AuthResponse
{
    [JsonProperty(PropertyName = "token")]
    public string token { get; set; }
}