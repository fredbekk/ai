using Ai.Droid;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(Toast_Android))]
namespace Ai.Droid
{
    public class Toast_Android : IToast
    {
        public void Show(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}