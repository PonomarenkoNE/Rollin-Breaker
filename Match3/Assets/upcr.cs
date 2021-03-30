using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upcr : MonoBehaviour
{
    public GameObject an1;
    public GameObject an2;
    public GameObject an3;
    public GameObject an4;
    public GameObject an5;
    public GameObject diam;
    public Text cost;
    private void Start()
    {
        if (PlayerPrefs.GetInt("up2") == 0)
        {
            PlayerPrefs.SetInt("up2", 1);
        }
        switch (PlayerPrefs.GetInt("up2"))
        {
            case 1:
                an2 = Instantiate(an2, an2.transform.position, Quaternion.identity);
                Destroy(an1);
                cost.GetComponent<Text>().text = "-200";
                break;
            case 2:
                an3 = Instantiate(an3, an3.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-250";
                Destroy(an2);
                break;
            case 3:
                an4 = Instantiate(an4, an4.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-300";
                Destroy(an3);
                break;
            case 4:
                an5 = Instantiate(an5, an5.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-400";
                Destroy(an4);
                break;
            case 5:
                cost.GetComponent<Text>().text = "Maximum";
                Destroy(an5);
                Destroy(diam);
                break;
        }
    }
    private void OnMouseDown()
    {
        switch (PlayerPrefs.GetInt("up2"))
        {
            case 1:
                if (PlayerPrefs.GetInt("money") >= 200)
                {
                    PlayerPrefs.SetInt("up2", 2);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 200);
                    Start();
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("money") >= 250)
                {
                    PlayerPrefs.SetInt("up2", 3);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 250);
                    Start();
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("money") >= 300)
                {
                    PlayerPrefs.SetInt("up2", 4);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 300);
                    Start();
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("money") >= 400)
                {
                    PlayerPrefs.SetInt("up2", 5);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 400);
                    Start();
                }
                break;
        }
    }
}
