using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillOnButton : MonoBehaviour {

    Image img;
    public Image One;
    public Image Two;

    float _t = 0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(transform.childCount == 0f)
        {
            Destroy(gameObject);
        }

        img = GetComponent<Image>();

        _t += Time.deltaTime;

        if (_t >= 0.5f)
        {
            if (img == One)
            {
                img = Two;
                _t = 0f;
            }
            else
            {
                img = One;
                _t = 0f;
            }

        }

    }
}
