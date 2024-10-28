using Arx;

using ObjCRuntime;

public class ViewModel : IArxHeadsetApi
{
    private ArxHeadsetHandler _headsetHandler;

    public NativeHandle Handle { get; private set; }

    public ViewModel()
    {
        // Initialize ArxHeadsetHandler with the ViewModel as the delegate
        _headsetHandler = new ArxHeadsetHandler(this);
    }

    // Implement the IArxHeadsetApi methods here
    public void OnDeviceConnectionError(Exception error)
    {
        // Handle the connection error
    }

    public void OnDeviceConnectionErrorWithError(NSError error)
    {
        Console.Write("SeeingAI-Arx error is " + error.Description);
    }

    public void OnDevicePhotoReceivedWithImage(UIImage image, Arx.Resolution frameDescriptor)
    {
        // Handle the received photo
    }

    public void OnButtonClickedWithButton(ArxButton button, bool isLongPress)
    {
        // Handle the button click
    }

    public void OnDisconnect()
    {
        // Handle the disconnect
    }

    public void OnConnected()
    {
        // Handle the connected state
    }

    public void OnImuDataUpdateWithImuData(ImuData imuData)
    {
        // Handle the IMU data update
    }
    /*
    NativeHandle Constructor(ArxButton button, ButtonPressDuration press_duration)
    {
        //handle here
    }
    */

    // Implementing the IDisposable interface
    public void Dispose()
    {
        //Dispose(true);
        GC.SuppressFinalize(this);
    }
}