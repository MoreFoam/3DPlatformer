using UnityEngine;
using UnityEngine.UI; 
using System.Collections;
//Works in PlayerController
//Lucas (or other members) if you plan on using this, "count" displays collectibles picked up, "thingyCount" displays the amount overall
//"Pick Up" without the quotes is the reference tag, and OnTriggerEnter is what deletes the current Collectible collected...
public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private int count; 
	private int thingyCount;

	private Rigidbody rb;
//Aside from FixedUpdate all other functions/c-placements are needed.
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		GUpdate ();
		SetCountText ();
		winText.text = "";

	}
//Counts all instances/duplicates of the collectible and stores them in "thingyCount". Hope this helps Lucas
	void GUpdate () {

		GameObject[] thingyToFind = GameObject.FindGameObjectsWithTag ("Pick Up");

		thingyCount = thingyToFind.Length;

	}
//********************
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
//********************
//This will destroy the orbs as they are collected and place the amount destroyed into "count".
	void OnTriggerEnter (Collider other)
	{
		//Destroy (other.gameObject);

		//De-activate other object
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
//********************
//Displayed current orbs collected vs amount on map and a win message[I used winText as a debugger but you could probably
// change the string to "All collected" or something] 
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString () + " / " + thingyCount;
		if (count >= thingyCount)
		{
			winText.text = "You win";
		}
	}
}
