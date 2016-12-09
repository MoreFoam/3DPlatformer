using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthSystem : MonoBehaviour {

	private int health;
	private int maxHealth;
	private bool isHit;
	public Image healthbar;
	private bool isRunning;
    public AudioClip ouch;

    // Use this for initialization
    void Start () {
		maxHealth = 5;
		health = maxHealth;
		isHit = false;
		isRunning = false;
	
	}

	void Update (){
		transform.position = GameObject.FindWithTag("Player").transform.position;
		float Chealth = (float)health / 5;
		//Debug.Log("CRRENT HEALTH: "+ Chealth);
		if (health <= maxHealth && health != 0){
			healthbar.rectTransform.localScale = new Vector3(Chealth, healthbar.rectTransform.localScale.y, healthbar.rectTransform.localScale.z);
		}
	}
		
	void OnTriggerEnter(Collider Col){

		if (Col.CompareTag("Enemy")){
            GetComponent<AudioSource>().PlayOneShot(ouch);
            Debug.Log("isHit ValueAOnCollision: " + isHit);
			Debug.Log("isRunning " + isRunning);
			if (!isRunning){
				StartCoroutine("waitUpSon");
			}
		}
	}

	IEnumerator waitUpSon(){
		isRunning = true;
			
		
		if (health > 0){

			if (health <= maxHealth){
				health = health - 1;
				Debug.Log("YOU WERE HIT! Current health: " + health.ToString());
				yield return new WaitForSeconds(3);
				Debug.Log("TEST");
				isRunning = false;
				yield break;

				//Debug.Log("isHit ValueB4: " + isHit);
			}
			Debug.Log("isHit ValueAftr: " + isHit);
			
			//yield break;
		}
	}
}
