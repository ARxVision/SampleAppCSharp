using Arx;

using ObjCRuntime;

public class ViewModel : NSObject, IArxHeadsetApi
{
    private ArxHeadsetHandler _headsetHandler;
    private UILabel label;
    private UIImageView imageView;
    public ViewModel(UILabel label, UIImageView image)
    {
        // Initialize ArxHeadsetHandler with the ViewModel as the delegate
        _headsetHandler = new ArxHeadsetHandler(this);
        this.label = label;
        this.imageView = image;
        _headsetHandler.MjpegUrlString = "http://127.0.0.1:8081/stream";
    }

    // Implement the IArxHeadsetApi methods here
    public void OnDeviceConnectionError(Exception error)
    {
        // Handle the connection error
    }

    public void Connect()
    {
        this.label.Text = "Connecting";
        _headsetHandler.Connect();
    }

    public void Disconnect()
    {
        this.label.Text = "Disconnecting";
        _headsetHandler.Disconnect();
    }

    public void OnDeviceConnectionErrorWithError(NSError error)
    {
        Console.Write("SeeingAI-Arx error is " + error.Description);
        this.label.Text = error.Description;
    }

    public void OnDevicePhotoReceivedWithImage(UIImage image, Arx.Resolution frameDescriptor)
    {
        //Console.WriteLine("SeeingAI-Arx photo received");
        // Handle the received photo
        this.imageView.Image = image;
    }

    public void OnButtonClickedWithButton(ArxButton button, bool isLongPress)
    {
        // Handle the button click
        this.label.Text = "Button clicked";
        Console.WriteLine("SeeingAI-Arx button clicked");
    }

    public void OnDisconnect()
    {
        Console.WriteLine("SeeingAI-Arx is disconnected");
        this.label.Text = "disconnected";
        // Handle the disconnect
    }

    public void OnConnected()
    {
        Console.WriteLine("SeeingAI-Arx is connected");
        this.label.Text = "connected yay";
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

}
