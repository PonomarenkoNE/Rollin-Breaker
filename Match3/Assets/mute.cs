using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour
{
    public Sprite blue, red, mut,unmut;
    public GameObject mu;
    private void Start()
    {
        if (PlayerPrefs.GetInt("mut") == 0)
        {
            mu.GetComponent<SpriteRenderer>().sprite = unmut;
        }
        else
        {
            mu.GetComponent<SpriteRenderer>().sprite = mut;
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = red;

        if (PlayerPrefs.GetInt("mut") == 0)
        {
            mu.GetComponent<SpriteRenderer>().sprite = mut;
            PlayerPrefs.SetInt("mut", 1);
        }
        else
        {
            mu.GetComponent<SpriteRenderer>().sprite = unmut;
            PlayerPrefs.SetInt("mut", 0);
        }
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = blue;
    }
}
