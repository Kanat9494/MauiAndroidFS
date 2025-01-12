using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using MauiAndroidFS.Platforms.Android;

namespace MauiAndroidFS;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public MainActivity()
    {
        AndroidServiceManager.MainActivity = this;
    }

    public void StartService()
    {
        var serviceIntent = new Intent(this, typeof(NotificationFS));
        serviceIntent.PutExtra("inputExtra", "Background Service");
        StartService(serviceIntent);
    }

    public void StopService()
    {
        var serviceIntent = new Intent(this, typeof(NotificationFS));
        StopService(serviceIntent);
    }
}
