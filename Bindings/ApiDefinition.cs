using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Arx
{
	// @protocol ArxHeadsetApi
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP6camera13ArxHeadsetApi_")]
	interface ArxHeadsetApi
	{
		// @required -(void)onDeviceConnectionErrorWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("onDeviceConnectionErrorWithError:")]
		void OnDeviceConnectionErrorWithError (NSError error);

		// @required -(void)onDevicePhotoReceivedWithImage:(UIImage * _Nonnull)image frameDescriptor:(Resolution * _Nonnull)frameDescriptor;
		[Abstract]
		[Export ("onDevicePhotoReceivedWithImage:frameDescriptor:")]
		void OnDevicePhotoReceivedWithImage (UIImage image, Resolution frameDescriptor);

		// @required -(void)onButtonClickedWithButton:(enum ArxButton)button isLongPress:(BOOL)isLongPress;
		[Abstract]
		[Export ("onButtonClickedWithButton:isLongPress:")]
		void OnButtonClickedWithButton (ArxButton button, bool isLongPress);

		// @required -(void)onDisconnect;
		[Abstract]
		[Export ("onDisconnect")]
		void OnDisconnect ();

		// @required -(void)onConnected;
		[Abstract]
		[Export ("onConnected")]
		void OnConnected ();

		// @required -(void)onImuDataUpdateWithImuData:(ImuData * _Nonnull)imuData;
		[Abstract]
		[Export ("onImuDataUpdateWithImuData:")]
		void OnImuDataUpdateWithImuData (ImuData imuData);
	}

	// @interface ArxHeadsetHandler : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6camera17ArxHeadsetHandler")]
	[DisableDefaultCtor]
	interface ArxHeadsetHandler
	{
		// -(void)connect;
		[Export ("connect")]
		void Connect ();

		// -(void)disconnect;
		[Export ("disconnect")]
		void Disconnect ();
	}

	// @interface ButtonData : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6camera10ButtonData")]
	[DisableDefaultCtor]
	interface ButtonData
	{
		// @property (readonly, nonatomic) enum ArxButton button;
		[Export ("button")]
		ArxButton Button { get; }

		// @property (readonly, nonatomic) enum ButtonPressDuration press_duration;
		[Export ("press_duration")]
		ButtonPressDuration Press_duration { get; }

		// -(instancetype _Nonnull)initWithButton:(enum ArxButton)button press_duration:(enum ButtonPressDuration)press_duration __attribute__((objc_designated_initializer));
		[Export ("initWithButton:press_duration:")]
		[DesignatedInitializer]
		NativeHandle Constructor (ArxButton button, ButtonPressDuration press_duration);
	}

	// @interface ImuData : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6camera7ImuData")]
	[DisableDefaultCtor]
	interface ImuData
	{
		// @property (copy, nonatomic) NSUUID * _Nullable id;
		[NullAllowed, Export ("id", ArgumentSemantic.Copy)]
		NSUuid Id { get; set; }

		// @property (readonly, nonatomic) float acc_x;
		[Export ("acc_x")]
		float Acc_x { get; }

		// @property (readonly, nonatomic) float acc_y;
		[Export ("acc_y")]
		float Acc_y { get; }

		// @property (readonly, nonatomic) float acc_z;
		[Export ("acc_z")]
		float Acc_z { get; }

		// @property (readonly, nonatomic) float gyr_x;
		[Export ("gyr_x")]
		float Gyr_x { get; }

		// @property (readonly, nonatomic) float gyr_y;
		[Export ("gyr_y")]
		float Gyr_y { get; }

		// @property (readonly, nonatomic) float gyr_z;
		[Export ("gyr_z")]
		float Gyr_z { get; }

		// @property (readonly, nonatomic) float mag_x;
		[Export ("mag_x")]
		float Mag_x { get; }

		// @property (readonly, nonatomic) float mag_y;
		[Export ("mag_y")]
		float Mag_y { get; }

		// @property (readonly, nonatomic) float mag_z;
		[Export ("mag_z")]
		float Mag_z { get; }

		// @property (readonly, nonatomic) float temperature;
		[Export ("temperature")]
		float Temperature { get; }

		// -(instancetype _Nonnull)initWithAcc_x:(float)acc_x acc_y:(float)acc_y acc_z:(float)acc_z gyr_x:(float)gyr_x gyr_y:(float)gyr_y gyr_z:(float)gyr_z mag_x:(float)mag_x mag_y:(float)mag_y mag_z:(float)mag_z temperature:(float)temperature __attribute__((objc_designated_initializer));
		[Export ("initWithAcc_x:acc_y:acc_z:gyr_x:gyr_y:gyr_z:mag_x:mag_y:mag_z:temperature:")]
		[DesignatedInitializer]
		NativeHandle Constructor (float acc_x, float acc_y, float acc_z, float gyr_x, float gyr_y, float gyr_z, float mag_x, float mag_y, float mag_z, float temperature);
	}

	// @interface Resolution : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6camera10Resolution")]
	[DisableDefaultCtor]
	interface Resolution
	{
		// @property (readonly, nonatomic) NSInteger width;
		[Export ("width")]
		nint Width { get; }

		/https://dev.azure.com/msresearch/SeeingAI/_settings// @property (readonly, nonatomic) NSInteger height;
		[Export ("height")]
		nint Height { get; }

		// -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height __attribute__((objc_designated_initializer));
		[Export ("initWithWidth:height:")]
		[DesignatedInitializer]
		NativeHandle Constructor (nint width, nint height);
	}
}
