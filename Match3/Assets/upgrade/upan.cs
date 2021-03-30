using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upan : MonoBehaviour
{
    public GameObject an1;
    public GameObject an2;
    public GameObject an3;
    public GameObject an4;
    public GameObject an5;
    public GameObject an6;
    public GameObject diam;
    public Text cost;
    private void Start()
    {
        if(PlayerPrefs.GetInt("up1")== 0 || PlayerPrefs.GetInt("up1") == 1)
        {
            PlayerPrefs.SetInt("up1", 2);
        }
        switch (PlayerPrefs.GetInt("up1"))
        {
            case 1:
                an2 = Instantiate(an2, an1.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-50";
                Destroy(an1);
                break;
            case 2:
                an3 = Instantiate(an3, an1.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-250";
                Destroy(an2);
                break;
            case 3:
                an4 = Instantiate(an4, an1.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-300";
                Destroy(an3);
                break;
            case 4:
                an5 = Instantiate(an5, an1.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-400";
                Destroy(an4);
                break;
            case 5:
                an6 = Instantiate(an6, an1.transform.position, Quaternion.identity);
                cost.GetComponent<Text>().text = "-500";
                Destroy(an5);
                break;
            case 6:
                cost.GetComponent<Text>().text = "Maximum";
                Destroy(an6);
                Destroy(diam);
                break;
        }
    }
    private void OnMouseDown()
    {
        switch (PlayerPrefs.GetInt("up1"))
        {
            case 1:
                if (PlayerPrefs.GetInt("money") >= 50)
                {
                    PlayerPrefs.SetInt("up1", 2);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 50);
                    Start();
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("money") >= 250)
                {
                    PlayerPrefs.SetInt("up1", 3);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 250);
                    Start();
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("money") >= 300)
                {
                    PlayerPrefs.SetInt("up1", 4);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 300);
                    Start();
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("money") >= 400)
                {
                    PlayerPrefs.SetInt("up1", 5);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 400);
                    Start();
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("money") >= 500)
                {
                    PlayerPrefs.SetInt("up1", 6);
                    PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 500);
                    Start();
                }
                break;
        }
    }
}
