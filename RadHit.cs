using UnityEngine;
using System.Collections;

public class RadHit : MonoBehaviour {
	public float myTimer = 295.0f;
	public float limitTimer = 300.0f;
	public bool inRad = false;
	// Use this for initialization
	public string EnemyToKill = "enemy";
	private bool Endit = false;
	void Start () {
		//gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
		

	void Update () 
	{
		//if (Input.GetKeyDown (KeyCode.M)) {
			//gameObject.SetActive (true);
		//}
		if (inRad==true){
		myTimer+=Time.deltaTime;
		//timer.text = "Time :" + (int)myTimer;

		if (myTimer >= limitTimer)
			{
			Debug.Log("GAME OVER");
			Endit = true;
			}

		}
	
	}
void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag (EnemyToKill)) {
			inRad = true;
			//hitAmount_Cur++;
	}
		if (Endit == true) {
			other.gameObject.SetActive (false);
			gameObject.SetActive (false);
			inRad = false;
			//EndM();
		}
    

//	if (hitAmount_Cur >= hitAmount_Max)
//	{
//		gameObject.SetActive (false);
//		// You got hit too many times, it's over
//		Debug.Log("Shit, I'm dead");
//		//	gameObject.SetActive (false);
//		//Destroy(gameObject);
//	}

}
		void OnTriggerExit(Collider other) {
			inRad = false;}
}
//void EndM(){
//	}
