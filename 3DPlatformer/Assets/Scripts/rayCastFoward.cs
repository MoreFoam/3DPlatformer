using UnityEngine;
using System.Collections;

public class rayCastFoward : MonoBehaviour
{
    public float theDistance;
    public float maxDistance;
    public chest _chest;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Use"))
        {
            RaycastHit hit;
            float theDistance;
            GameObject target;

            //Debug Raycast in editor to see
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 5;

            if (Physics.Raycast(transform.position, (forward), out hit))
            {
                target = hit.collider.gameObject;
                theDistance = hit.distance;
                print(theDistance + " " + target.name);
                if (theDistance <= maxDistance)
                {
                    _chest = target.GetComponent<chest>();
                    if (_chest)
                    {
                        _chest.chestToggle();
                    }
                }
            }
        }
	}
}
