using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade2 : MonoBehaviour
{
    public GameObject fadeObject;
    GameObject other;
    Animator _animator;
    //Image fadeImage;
    int lag = 2;

	// Use this for initialization
	void Start ()
    {
        _animator = GetComponent<Animator>();
        //fadeImage = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hostage")
        {
            Debug.Log("a");
            fadeObject.SetActive(true);
            _animator.Play("fadeout");
            Destroy(gameObject, lag);
        }
    }
}
