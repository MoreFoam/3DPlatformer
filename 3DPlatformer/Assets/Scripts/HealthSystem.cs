using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

	private int health;
	private int maxHealth;
	private bool isHit = false;

	// Use this for initialization
	void Start () {
		maxHealth = 3;
		health = maxHealth;
	
	}
		
	IEnumerator waitUpSon(){
		print("Hey man chill out!");
		yield return new WaitForSeconds(5);
	}

	void OnCollisionEnter(Collision Col){

		if (Col.gameObject.tag == "Enemy"){
			if (isHit){
				Debug.Log("You were previously hit!");
				StartCoroutine(waitUpSon());
				isHit = false;
			}
			else if (health > 0){

				if (health <= maxHealth){
					health = health - 1;
				}
				Debug.Log("YOU WERE HIT! Current health: " + health.ToString());
				isHit = true;
			}
		}

	}
}
