using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade4 : MonoBehaviour
{
    float red, green, blue, alfa; //Image(1) -> Inspecter -> Image -> Colorにおいてred, green, blue ,alfaは0~255.しかし、スクリプト上では0.0~1.0f
    float speed = 0.01f; //上記の色の範囲に合わせて
    float lag = 4.0f;

    // Use this for initialization
    void Start ()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<Image>().color = new Color(red, green, blue, alfa);
        //alfa += speed;
	}

    void fadeOut()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa += speed;
        Invoke("fadeIn", lag);
    }

    void fadeIn()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa -= speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hostage")
        {
            Debug.Log("a");
            //GetComponent<Image>().color = new Color(red, green, blue, alfa);
            //alfa += speed;
            //SteamVR_Fade.Start(fadeColor, fadeTime, tf);
            //tf = false;
            //Destroy(other.gameObject, lag); //これで人質一人一人にスクリプト用意しなくても、接触したオブジェクト（人質）を消してくれる
            //Invoke("Clear", lag);
        }
    }
}
