﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomizerCrosses : MonoBehaviour
{

    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    public GameObject backCanvas;

    float _t;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Popup();
        }

        _t += Time.deltaTime;

        if (_t >= 1f)
        {
            Popup();
            _t = 0f;
        }

    }


    public void Popup()
    {


        //spawnPoints = GameObject.FindGameObjectsWithTag("point");
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        print(currentPoint.name);


        //GameObject spawned = currentPoint;
        //spawned.transform.position = new Vector3(Random.value, Random.value, 0);


        GameObject spawned = Instantiate(currentPoint, new Vector3(Random.Range(0f, 1000.0f), Random.Range(0f, 400.0f)), Quaternion.identity);
        spawned.transform.parent = backCanvas.transform;

        //currentPoint.transform.parent = Back_Canvas.transform;
    }



}
