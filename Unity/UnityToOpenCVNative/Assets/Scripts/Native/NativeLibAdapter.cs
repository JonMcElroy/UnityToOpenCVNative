using System.Runtime.InteropServices;
using System;

using UnityEngine;

/*
	NativeLibAdapter is an example communication layer between managed C# and native C++
 */
public class NativeLibAdapter
{
	[DllImport("native-lib")]
	private static extern int InitCV_Internal(int width, int height);

	[DllImport("native-lib")]
	private static extern IntPtr SubmitFrame_Internal(int width, int height, IntPtr bufferAddr);

	[DllImport("native-lib")]
	private static extern int FooTestFunction_Internal();

	public static int InitCV(int width, int height)
	{
		int result = InitCV_Internal(width, height);
		Debug.LogWarning("[NativeLibAdapter] InitCV " + (result == 0 ? "No Errors" : "Error Code : " + result));
		
		return result;
	}

	public static IntPtr SubmitFrame(int width, int height, IntPtr bufferAddr)
	{
		IntPtr ret = SubmitFrame_Internal(width, height, bufferAddr);
		return ret;
	}

	public static int FooTest()
	{
		return FooTestFunction_Internal();
	}

}