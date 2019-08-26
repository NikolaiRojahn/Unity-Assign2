using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AircraftCollide : MonoBehaviour
{
    float count;
    public Text t;
    public RectTransform score;
    private Vector3 punch;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        punch = new Vector3(2, 3, 0);
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
            score.DOPunchScale(punch, 3, 2, 1);
        }
        {
            t.text = "Score: " + count;
        }
    }


}
