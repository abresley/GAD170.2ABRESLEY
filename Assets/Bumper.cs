using UnityEngine;

public class SizeIncreaseOnCollision : MonoBehaviour
{
	public float scaleIncreaseAmount = 1.1f; // How much to increase the scale by

	void OnCollisionEnter(Collision collision)
	{
		// Check if the collision is with the object you're interested in
		if (collision.gameObject.CompareTag("Player")) // Or use a specific tag/name
		{
			// Increase the scale
			transform.localScale *= scaleIncreaseAmount;
		}
	}
}