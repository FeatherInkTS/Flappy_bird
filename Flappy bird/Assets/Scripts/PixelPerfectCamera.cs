using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {
	public static float pixelToUnit = 100f;

	public static float scale = 1f;

	public Vector2 nativeResolution = new Vector2 (1152, 2048);

	void Awake()
	{
		var camera = GetComponent<Camera> ();

		if (camera.orthographic) {
			scale = Screen.height / nativeResolution.y;
			pixelToUnit *= scale;
			camera.orthographicSize = (Screen.height / 2) / pixelToUnit;
		}
	}
}
