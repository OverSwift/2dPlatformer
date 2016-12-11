using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(SpriteCombiner))]
public class SpriteCombinerEditor : Editor {

	void OnSceneGUI() {

		SpriteCombiner sc = target as SpriteCombiner;

		if (Handles.Button (sc.transform.position + Vector3.up * 5, Quaternion.identity, 1, 1, Handles.CircleCap)) {
			sc.CombineChildren ();
		}
	}
}
