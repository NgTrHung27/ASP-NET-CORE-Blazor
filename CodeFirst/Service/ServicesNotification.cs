using Microsoft.JSInterop;

public class ServicesNotification
{
    private readonly IJSRuntime _jsRuntime;

    public ServicesNotification(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task DisplayGeneralNotification(string icon, string message, string title)
    {
        await _jsRuntime.InvokeVoidAsync("DisplayGeneralNotification", icon, message, title);
    }
}