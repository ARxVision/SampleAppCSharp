using ObjCRuntime;

namespace Arx
{
	[Native]
	public enum ArxButton : long
	{
		Square = 0,
		Circle = 1,
		Triangle = 2,
		VolumeUp = 3,
		VolumeDown = 4
	}

	[Native]
	public enum ButtonPressDuration : long
	{
		Short = 0,
		Long = 1
	}
}
