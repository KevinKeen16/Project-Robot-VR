using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class CameraTest : Editor {
	public Vector3 CamPos1;
	public Quaternion CamPos2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log(SceneView.lastActiveSceneView.position);
	}

	void ResetCam()
	{
		var view = SceneView.currentDrawingSceneView;
		if (view != null)
		{
			var target = new GameObject();
			target.transform.position = CamPos1;
			target.transform.rotation = CamPos2;
			view.AlignViewToObject(target.transform);
			GameObject.DestroyImmediate(target);
		}
	}
}
