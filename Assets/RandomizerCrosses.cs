using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomizerCrosses : MonoBehaviour
{

    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    public GameObject backCanvas;


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Popup();
        }
    }


    void Popup()
    {


        //spawnPoints = GameObject.FindGameObjectsWithTag("point");
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        print(currentPoint.name);


        //GameObject spawned = currentPoint;
        //spawned.transform.position = new Vector3(Random.value, Random.value, 0);


        GameObject spawned = Instantiate(currentPoint, new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-4.0f, 4.0f)), Quaternion.identity);
        spawned.transform.parent = backCanvas.transform;

        //currentPoint.transform.parent = Back_Canvas.transform;
    }



}
