using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Sprite blue, red;

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = red;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = blue;
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                PlayerPrefs.SetInt("tap", 3);
                Application.LoadLevel("play");
                break;
            case "cust":
                Application.LoadLevel("upgrade");
                break;
        }
    }
}
