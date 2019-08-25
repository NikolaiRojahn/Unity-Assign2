using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    GameObject plane;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != plane)
        {
            Destroy(other);
            print("Destroying other");
        }
    }
}
