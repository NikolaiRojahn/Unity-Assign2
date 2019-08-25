using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AircraftCollide : MonoBehaviour
{
    float count;
    Text countText;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setCountText(0);
        countText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
            print("Collision with game point.");
            gameObject.GetComponent<AudioSource>().Play();
            
            setCountText(1);
        } else
        {
            print("Collision with the plane.");
        }
    }

    public void setCountText(float increase)
    {
        count = count + increase;
        countText.text = "Count: " + count.ToString();
    }

}
