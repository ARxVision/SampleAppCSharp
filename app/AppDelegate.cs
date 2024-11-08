namespace ArxSample;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window
    {
        get;
        set;
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();

        var newLabel = new UILabel(new CGRect(50, 200, 250, 50))
        {
            Text = "Status: Disconnected",
            TextAlignment = UITextAlignment.Center,
            BackgroundColor = UIColor.SystemPink
        };

        // Create a UIImageView
        var imageView = new UIImageView(new CGRect(50, 300, 200, 200))
        {
            Image = UIImage.FromFile("your_image.png"), // Replace with your image file
            ContentMode = UIViewContentMode.ScaleAspectFit
        };

        // Add the new label to the view


        var viewModel = new ViewModel(newLabel, imageView);

        var disconnectButton = new UIButton(UIButtonType.System);
        disconnectButton.Frame = new CGRect(50, 100, 100, 50);
        disconnectButton.SetTitle("Disconnect", UIControlState.Normal);
        disconnectButton.TouchUpInside += (sender, e) =>
        {
            // Handle disconnect action
            Console.WriteLine("Disconnect button clicked");
            viewModel.Disconnect();
        };

        // Create the Connect button
        var connectButton = new UIButton(UIButtonType.System);
        connectButton.Frame = new CGRect(200, 100, 100, 50);
        connectButton.SetTitle("Connect", UIControlState.Normal);
        connectButton.TouchUpInside += (sender, e) =>
        {
            viewModel.Connect();
            // Handle connect action
            Console.WriteLine("Connect button clicked");
        };

        // Add buttons to the view
        vc.View.AddSubview(disconnectButton);
        vc.View.AddSubview(connectButton);
        vc.View.AddSubview(newLabel);
        vc.View.AddSubview(imageView);

        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}
