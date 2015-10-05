using UnityEngine;
using System.Collections;

public class RotateCameraScript : MonoBehaviour
{
    float yRot;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        yRot += 0.5f;
        Camera.main.transform.rotation = Quaternion.Euler(0, yRot, 0);
	}
}
