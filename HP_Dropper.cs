using UnityEngine;
using System.Collections;

public class HP_Dropper : MonoBehaviour {


public GameObject prefab1;
public GameObject DeadTeller;
//public GameObject rotator; // attach an empty object that is at the same position as the object with this script
//public float distance;
public int amountOfObjectsToSpawn;
//public Vector3 rotatorAxis;
private bool Noon = true; //private GameObject C;
//public GameObject[] items = new GameObject[3];
public int radius = 1;
//	private int YON = items.Length;
// if conditions desired met
	public float dropRate = 0.25f;

			
		
void LateUpdate() {//if (myGameObject.activeSelf)
		if (Noon == true){
			Lu ();
		//Noon = false;
		}}

	void Lu(){
		if (DeadTeller.activeInHierarchy == false) {
			Noon = false;
			Vector3 center = transform.position;
			if (Random.Range (0f, 1f) <= dropRate) {
				for (int i = 0; i < amountOfObjectsToSpawn; i++) {
					if (DeadTeller != null) {
						int a = i * 30;
						Vector3 pos = RandomCircle (center, 1.0f, a);
						Instantiate (prefab1, pos, Quaternion.identity);


					}
				}
			}
			Destroy (DeadTeller);
		}
	}
 
Vector3 RandomCircle(Vector3 center, float radius,int a)
	{
		Debug.Log(a);
		float ang = a;
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
		pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
		pos.z = center.z;
		return pos;
	}}
