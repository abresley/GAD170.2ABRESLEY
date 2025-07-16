using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleKill : MonoBehaviour

{
	void OnTriggerEnter(Collider other)
	{
		// Check if the colliding object has a specific name
		if (other.gameObject.CompareTag("KillZone"))
		{
			Destroy(gameObject); // Destroy object the script is attached to
		}
	}
}