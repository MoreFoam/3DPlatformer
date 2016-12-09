using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectCount: MonoBehaviour
{ //HealthSystem

    private int pcount; //health
    private int maxPickup; //maxHealth
    private bool issHit; //isHit
    public Image counter; //healthbar
    private bool isRunning;

    // Use this for initialization
    void Start()
    {
        maxPickup = 10;
        pcount = 0;
        issHit = false;
        isRunning = false;

    }

    /*void Update (){
		transform.position = GameObject.FindWithTag("Player").transform.position;
		float Chealth = (float)health / 5;
		//Debug.Log("CRRENT HEALTH: "+ Chealth);
		if (pcount <= maxHealth && health != 0){
			healthbar.rectTransform.localScale = new Vector3(Chealth, healthbar.rectTransform.localScale.y, healthbar.rectTransform.localScale.z);
		}
	}*/

    void OnTriggerEnter(Collider Col)
    {

        if (Col.CompareTag("Pick Up"))
        {
            Debug.Log("isHit ValueAOnCollision: " + issHit);
            Debug.Log("isRunning " + isRunning);
            if (!isRunning)
            {
                StartCoroutine("waitUpSon");
            }
        }
    }

    IEnumerator waitUpSon()
    {
        isRunning = true;


        if (pcount >= 0)
        {

            if (pcount <= maxPickup)
            {
                pcount = pcount + 1;
                //Debug.Log("YOU WERE HIT! Current health: " + health.ToString());
                //yield return new WaitForSeconds(3);
                Debug.Log("TEST");
                isRunning = false;
                yield break;

                //Debug.Log("isHit ValueB4: " + isHit);
            }
            //Debug.Log("isHit ValueAftr: " + isHit);

            //yield break;
        }
    }
}
