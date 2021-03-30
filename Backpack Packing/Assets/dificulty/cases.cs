using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cases : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "easy":
                PlayerPrefs.SetInt("dif", 1);
                Application.LoadLevel("play");
                break;
            case "normal":
                PlayerPrefs.SetInt("dif", 2);
                Application.LoadLevel("play");
                break;
            case "hard":
                PlayerPrefs.SetInt("dif", 3);
                Application.LoadLevel("play");
                break;
            case "impossible":
                PlayerPrefs.SetInt("dif", -1);
                Application.LoadLevel("play");
                break;
        }
    }
}
