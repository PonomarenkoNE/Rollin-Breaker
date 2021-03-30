using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    void Update()
    {
        GetComponent <Text>().text = PlayerPrefs.GetInt("sc1").ToString();
    }
}
