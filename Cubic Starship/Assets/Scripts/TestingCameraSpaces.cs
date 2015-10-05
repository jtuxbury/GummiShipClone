using UnityEngine;
using System.Collections;

public class TestingCameraSpaces : MonoBehaviour
{
    public GameObject screenPosTestObject;
    public GameObject viewportPosTestObject;
    private Vector3 screenPos;
    private Vector3 viewportPos;
	// Use this for initialization
	void Start ()
    {
        screenPos = Camera.main.WorldToScreenPoint(screenPosTestObject.transform.position);
        screenPosTestObject.transform.position = screenPos;
        viewportPos = Camera.main.WorldToViewportPoint(viewportPosTestObject.transform.position);
        viewportPosTestObject.transform.position = viewportPos;
	}
	
	// Update is called once per frame
	//void Update ()
 //   {
 //       if (Input.GetKeyDown(KeyCode.Space))
 //       {
 //           Debug.Log("World Space Position: " + this.transform.position);
 //           Debug.Log("Screen Space Position: " + screenPos);
 //           Debug.Log("Viewport Space Position: " + viewportPos);
 //       }
 //       //if (Input.GetKeyDown(KeyCode.Q))
 //       //{
 //       //    screenPos = Camera.main.WorldToScreenPoint(screenPosTestObject.transform.position);
 //       //    screenPos += new Vector3(-1, 0, 0);
 //       //    screenPosTestObject.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
 //       //}
 //       //if (Input.GetKeyDown(KeyCode.A))
 //       //{
 //       //    screenPos = Camera.main.WorldToScreenPoint(screenPosTestObject.transform.position);
 //       //    screenPos += new Vector3(1, 0, 0);
 //       //    screenPosTestObject.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
 //       //}
 //       //if (Input.GetKeyDown(KeyCode.Z))
 //       //{
 //       //    screenPos = Camera.main.WorldToScreenPoint(screenPosTestObject.transform.position);
 //       //    screenPos += new Vector3(0, 0, 1);
 //       //    screenPosTestObject.transform.position = Camera.main.ScreenToWorldPoint(screenPos);
 //       //}
 //       if (Input.GetKey(KeyCode.A))
 //       {
 //           viewportPos = Camera.main.WorldToViewportPoint(viewportPosTestObject.transform.position);
 //           viewportPos += new Vector3(-0.05f, 0, 0);
 //           viewportPosTestObject.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
 //       }
 //       if (Input.GetKey(KeyCode.D))
 //       {
 //           viewportPos = Camera.main.WorldToViewportPoint(viewportPosTestObject.transform.position);
 //           viewportPos += new Vector3(0.05f, 0, 0);
 //           viewportPosTestObject.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
 //       }
 //       if (Input.GetKey(KeyCode.W))
 //       {
 //           viewportPos = Camera.main.WorldToViewportPoint(viewportPosTestObject.transform.position);
 //           viewportPos += new Vector3(0, 0, 0.2f);
 //           viewportPosTestObject.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);  
 //       }
 //       if (Input.GetKey(KeyCode.S))
 //       {
 //           viewportPos = Camera.main.WorldToViewportPoint(viewportPosTestObject.transform.position);
 //           viewportPos += new Vector3(0, 0, -0.2f);
 //           viewportPosTestObject.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
 //       }
 //       //if (Input.GetKeyDown(KeyCode.C))
 //       //{
 //       //    transform.position += new Vector3(0, 0, 1);
 //       //}
 //       //RemoveObject();
 //   }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            Destroy(gameObject);
        }
    }
    
}
