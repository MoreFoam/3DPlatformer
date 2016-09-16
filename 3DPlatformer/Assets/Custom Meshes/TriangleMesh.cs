﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TriangleMesh : MonoBehaviour {
	
	Vector3[] newVertices;
	Vector2[] newUV;
	int[] newTriangles;
	public float scale;
	public float degrees;
	float lastscale;
	
	// Use this for initialization
	void Start () {
		createMesh (scale);
	}
	
	// Update is called once per frame
	void Update () {
		if (scale != lastscale)
			createMesh (scale);
	}
	
	void createMesh(float scale) {
		
		lastscale = scale;
		
		newVertices = new Vector3[] {
			new Vector3 (0f,0f, .01f),
			new Vector3 (-scale, 0f, .01f),
			new Vector3 (-scale, degrees/45*-scale, .01f)
		};
		
		newUV = new Vector2[] {
			new Vector2 (0f, 0f),
			new Vector2 (-1f, 0f),
			new Vector2 (-1f, degrees/45*1f)
		};
		
		newTriangles = new int[] {0,1,2};
		
		Mesh Tmesh = new Mesh ();
		Tmesh.vertices = newVertices;
		Tmesh.uv = newUV;
		Tmesh.triangles = newTriangles;
		
		GetComponent<MeshFilter>().mesh = Tmesh;
		GetComponent<MeshCollider> ().sharedMesh = null;
		GetComponent<MeshCollider> ().sharedMesh = Tmesh;
	}
}