using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bullefForce = 20f;

    float span = 1f,delta = 0f;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if((Input.GetMouseButtonDown(1)||Input.GetKeyDown(KeyCode.Joystick1Button3))&& delta > span)
        {
            shoot();
            delta = 0f;
        }

    }

    void shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        bullet.GetComponent<skyShooting>().firePoint = firePoint;
        bullet.GetComponent<skyShooting>().bulletPrefab = bulletPrefab;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up*bullefForce,ForceMode2D.Impulse);
    }
}
