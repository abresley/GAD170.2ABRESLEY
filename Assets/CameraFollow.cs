using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target;
	public Transform follow;
	public Vector3 offset;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    follow.position = target.position + offset;
    }
}
