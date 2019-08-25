using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    GameObject bullet;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GameObject.Find("bullet");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos_world = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mousePos = new Vector3(mousePos_world.x, mousePos_world.y, transform.position.z);

            //Determine the direction we are looking at
            Vector3 direction = mousePos - transform.position;
            bullet.transform.rotation = Quaternion.LookRotation(transform.forward, direction);

            GameObject instBullet = Instantiate(bullet, transform.position, bullet.transform.rotation) as GameObject;
            
            //Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            //instBulletRigidbody.AddForce(Vector3.forward * speed * Time.deltaTime);
        }

    }

}
