using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleKill : MonoBehaviour

{
	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject); // Destroy object the script is attached to
	}
}
