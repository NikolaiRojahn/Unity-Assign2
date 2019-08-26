using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    private const int V = 0;
    GameObject car;
    Vector3 resetPosition = new Vector3(25f, 0f, 25f);
    Quaternion rotatePosition = new Quaternion();


    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("Car");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetGame()
    {
        print("Button clicked");

        //car.transform.position = resetPosition;
        //car.transform.rotation = rotatePosition;
        TimerScript.timer = 40;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
