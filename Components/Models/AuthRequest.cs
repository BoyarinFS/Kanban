using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class AuthRequest
{
    [JsonProperty(PropertyName = "login")]
    public string login { get; set; }
    
    [JsonProperty(PropertyName = "password")]
    public string password { get; set; }
}