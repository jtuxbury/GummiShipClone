using UnityEngine;
using System.Collections;

public class ShipControls : MonoBehaviour
{
    private GameObject playerShip;
    public GameObject projectile;
    private Vector3 moveDirection;
    private Vector3 viewportPos;
    private float nextTimeToShoot = 0;
    public float shipMovementSpeed = 1;
    public int radiusFromCamera = 10;

    // Use this for initialization
    void Start()
    {
        playerShip = this.gameObject;
        Debug.Log("The playerShip is " + playerShip.name);
        moveDirection = Vector3.zero;
        Debug.Log("Screen Width: " + Screen.width + " Screen Height: " + Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
        GetAxisInput();
        KeepPlayerInBounds();
        FireShipsWeapon();
        Debug.DrawRay(transform.position, -transform.up,Color.black);
       // viewportPos = Camera.main.WorldToViewportPoint(this.transform.position);
        playerShip.transform.position += moveDirection * shipMovementSpeed * Time.deltaTime;
       // playerShip.transform.position = Camera.main.ViewportToWorldPoint(viewportPos);
    }
    /// <summary>
    /// Used to grab input values from the input manager
    /// </summary>
    private void GetAxisInput()
    {
        moveDirection.x = Input.GetAxis("ShipHorizontalMovement");
        moveDirection.y = Input.GetAxis("ShipVerticalMovement");
    }
    /// <summary>
    /// Used to keep the player in the camera screen bounds
    /// </summary>
    private void KeepPlayerInBounds()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position); //convert the player's position from world space to viewport space
        pos.x = Mathf.Clamp01(pos.x); //clamp the x value of the players position
        pos.y = Mathf.Clamp01(pos.y); //clamp the y value of the players position
        transform.position = Camera.main.ViewportToWorldPoint(pos); //convert the player's position back to world space from viewport space
    }
    private void CheckDistanceFromCamera()
    {
        if (Vector3.Distance(this.transform.position, Camera.main.transform.position) > radiusFromCamera)
        {
            this.transform.position = this.transform.position;
        }
        if (Vector3.Distance(this.transform.position, Camera.main.transform.position) < radiusFromCamera)
        {
            this.transform.position = this.transform.position;
        }
    }
    /// <summary>
    /// [TESTING METHOD]: Used to spawn projectiles and set them as a child of the ship so that they move with the ship as it moves
    /// </summary>
    void BulletCreation()
    {
        GameObject projectileClone = (GameObject)Instantiate(projectile, this.transform.position + new Vector3(0,-0.5f,0), transform.rotation);
        projectileClone.transform.SetParent(this.transform.parent);
    }
    /// <summary>
    /// [TESTING METHOD]: Used to fire projectiles from the ship's weapons at a set rate of fire (0.1 as of now). 
    /// Going to rewrite to called the weapon's fire method
    /// </summary>
    void FireShipsWeapon()
    {
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            if (nextTimeToShoot <= 0)
            {
                BulletCreation();
                nextTimeToShoot = 0.1f;
            }
            nextTimeToShoot -= Time.deltaTime;
        }
    }
    
}
