using Newtonsoft.Json;

namespace Kanban_Release.Components.Models;

public class AccountCreationDto
{
    [JsonProperty(PropertyName = "firstname")]
    public string firstname { get; set; }

    [JsonProperty(PropertyName = "lastname")]
    public string lastname { get; set; }
}