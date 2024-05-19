using Kanban_Release.Components.Models;
using Newtonsoft.Json;

namespace Kanban_Release.Components;

public static class ServiceRequest
{
    private static string Host = "https://kanbandeskserver.onrender.com";

    public static async Task<AuthResponse> SendLoginRequest(AuthRequest request)
    {
        var authUrl = $"{Host}/api/v1/auth/login";

        var tmpResponse = await ApiService.PostRequest(authUrl, request, null);
        
        return JsonConvert.DeserializeObject<AuthResponse>(tmpResponse);
    }
}