# UnityToOpenCVNative
An example project for communicating between OpenCV C++ and Unity. Additional platforms will be added as available.

This project includes the OpenCV 3 static libraries but does not include methods to build them. 

Credit goes to Thomas van den Berge for their exhaustive write up here http://thomasmountainborn.com/2016/09/11/unity-and-opencv-part-one-install/ and to everyone who posted on adapating to other platforms here https://forum.unity3d.com/threads/tutorial-using-c-opencv-within-unity.459434/

## Getting Started
Included is an Android Studio project (located in /Android/) and a Unity project (located in /Unity/). The gradle configuration for the Android studio project will build and copy .so files directly into the relevant folders in the Unity project. If you make changes to the plugin and rebuild it be sure to restart Unity as it does not reload plugins once they have been loaded. If someone has a good cross-platform solution to this please comment or contribute.

### Running the Unity Example Project
At the time of writing this, the Unity Editor support is not checked in so to test please deploy to an Android device.

## Contributing
Any tweaks, fixes and contributions are greatly appreciated. I would love to add support and standard build paths for all platforms given time but hopefully this small repository helps someone in the meantime.
