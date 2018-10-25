using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_Close : MonoBehaviour
{
    public GameObject window;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Goal")
        {
            window.SetActive(false);
        }
    }
}