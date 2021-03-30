using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    void Update()
    {
        if (PlayerPrefs.GetInt("sc1") < PlayerPrefs.GetInt("sc2"))
        {
            GetComponent<Text>().text = "You win!)";
        }
        else
            GetComponent<Text>().text = "You lose!(";
    }
}
