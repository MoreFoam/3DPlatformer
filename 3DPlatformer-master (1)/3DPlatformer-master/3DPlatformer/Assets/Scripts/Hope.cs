using UnityEngine;
using System.Collections;

public class G_orb : MonoBehaviour {
	void OnParticleCollision(GameObject other) {
		Rigidbody body = other.GetComponent<Rigidbody>();
		if (body) {
			Vector3 direction = other.transform.position - transform.position;
			direction = direction.normalized;
			body.AddForce(direction * 5);
		}
	}
}

