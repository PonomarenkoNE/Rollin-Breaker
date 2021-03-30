using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "circle":
                switch (Application.loadedLevelName) {
                    case "play":
                        Application.LoadLevel("dificulty");
                        break;
                    case "dificulty":
                        Application.LoadLevel("menu");
                        break;
                    case "win":
                        Application.LoadLevel("menu");
                        break;
                }
                break;
        }
    }
}
