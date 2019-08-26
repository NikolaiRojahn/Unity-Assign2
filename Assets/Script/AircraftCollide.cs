using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AircraftCollide : MonoBehaviour
{
    float count;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Destroy(other.gameObject);
            print("Collision with game point.");
            gameObject.GetComponent<AudioSource>().Play();

            count++;
            
        }
        {
            t.text = "Score: " + count;
        }
    }


}
