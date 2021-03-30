using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public Sprite blue, red;

    private void OnMouseDown()
    {
        GetComponent < SpriteRenderer >().sprite = red;
    }
    private void OnMouseUp()
    {
        GetComponent < SpriteRenderer >().sprite = blue;
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("dificulty");
                break;
        }
    }
}
