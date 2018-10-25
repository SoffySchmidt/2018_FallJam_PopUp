using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillOnButton : MonoBehaviour {

    Image img;
    public Sprite one;
    public Sprite two;

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

        if (_t >= 0.3f)
        {
            if (img.sprite == one)
            {
                img.sprite = two;
                _t = 0f;
            }
            else
            {
                img.sprite = one;
                _t = 0f;
            }

        }

    }
}
