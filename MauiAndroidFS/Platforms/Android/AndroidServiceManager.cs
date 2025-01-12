namespace MauiAndroidFS.Platforms.Android;

public static class AndroidServiceManager
{
    public static MainActivity MainActivity { get; set; }
    public static bool IsRunning { get; set; }

    public static void StartFService()
    {
        if (MainActivity == null) return;
        MainActivity.StartService();
    }

    public static void StopFService()
    {
        if (MainActivity == null) return;
        MainActivity.StopService();
        IsRunning = false;
    }
}
