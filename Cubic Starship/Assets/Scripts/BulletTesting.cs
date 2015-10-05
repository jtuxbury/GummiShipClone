using UnityEngine;
using System.Collections;

public class BulletTesting : MonoBehaviour
{
    Vector3 viewportPos;
    Vector3 direction;
    Rigidbody thisRidgedBody;
	// Use this for initialization
	void Start ()
    {
        thisRidgedBody = this.GetComponent<Rigidbody>();
        direction = transform.forward + transform.right;
        viewportPos = Camera.main.WorldToViewportPoint(this.transform.position);
        //this.transform.position += new Vector3(-0.2f, 0, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
        viewportPos = Camera.main.WorldToViewportPoint(this.transform.position);
        viewportPos += new Vector3(0, 0, 0.5f);
        this.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
        DestroySelf();
	}
    void DestroySelf()
    {
        Destroy(gameObject, 2f);
    }

    
}
