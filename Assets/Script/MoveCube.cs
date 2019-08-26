using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public Vector3 oldPos;
    public Vector3 newPos;
    public float speed;
    public float step;
    Boolean standStill = false;
    // Start is called before the first frame update
    void Start()
    {
        
        positionSaver();
        StartCoroutine(CubeCoroutine());
        
    }


    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;

        if (standStill == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, step);     
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, oldPos, step);
        }
    }

    void positionSaver()
    {
        oldPos = transform.position;
        newPos = new Vector3((oldPos.x + 200), oldPos.y, oldPos.z);
    }

    IEnumerator CubeCoroutine()
    {
        while (true)
        {
            standStill = false;
            yield return new WaitForSeconds(3f);
            standStill = true;
            yield return new WaitForSeconds(3f);
        }
    }

}
