using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthSystem : MonoBehaviour {

	private int health;
	private int maxHealth;
	private bool isHit;
	public Image healthbar;
	private bool isRunning;
	public GameObject hud;
	private Animator animator;
	private float rTimer;
	private float dTime;

	// Use this for initialization
	void Start () {
		animator = hud.GetComponent<Animator>();
		maxHealth = 2;
		health = maxHealth;
		isHit = false;
		isRunning = false;
		dTime = 5f;
	
	}

	void Update (){
		transform.position = GameObject.FindWithTag("Player").transform.position;
		float Chealth = (float)health / 5;
		//Debug.Log("CRRENT HEALTH: "+ Chealth);
		if (health <= maxHealth && health >= 0){
			healthbar.rectTransform.localScale = new Vector3(Chealth, healthbar.rectTransform.localScale.y, healthbar.rectTransform.localScale.z);
		}

		if (health <= 0){
			//call the game over screen here, pause the game and go to the main menu after a delay
			//Time.timeScale = 0.0f;
			animator.SetBool("GameOver", true);
			rTimer += Time.deltaTime;
			if(rTimer >= dTime){
                
                Application.LoadLevel("Main Menu");
            }

		}
	}
		
	void OnTriggerEnter(Collider Col){

		if (Col.CompareTag("Enemy")){
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
