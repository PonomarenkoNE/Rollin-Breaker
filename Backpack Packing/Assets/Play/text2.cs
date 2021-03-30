using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class text2 : MonoBehaviour
{
    void Update()
    {
        GetComponent <Text>().text = PlayerPrefs.GetInt("sc2").ToString();
    }
}
