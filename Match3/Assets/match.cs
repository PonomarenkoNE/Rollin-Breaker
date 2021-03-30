using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;
public class match : MonoBehaviour
{
    public GameObject ball;
    public GameObject bomb;
    public GameObject square;
    public GameObject ruby;
    public GameObject saphire;
    public GameObject diam;
    public GameObject izum;
    private float j = -2f,l=2.7f;
    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3271311", false);
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            StartCoroutine(showbannerwhenready());
        }
        if(PlayerPrefs.GetInt("level") == 0)
        {
            PlayerPrefs.SetInt("level", 1);
        }
        PlayerPrefs.SetInt("numr",0);
        PlayerPrefs.SetInt("numb", 0);
        PlayerPrefs.SetInt("numy", 0);
        PlayerPrefs.SetInt("numg", 0);
        PlayerPrefs.SetInt("bomb", 0);
        PlayerPrefs.SetInt("win", 0);
        PlayerPrefs.SetInt("red", 0);
        PlayerPrefs.SetInt("blue", 0);
        PlayerPrefs.SetInt("yellow", 0);
        PlayerPrefs.SetInt("green", 0);
        PlayerPrefs.SetInt("red1", 0);
        PlayerPrefs.SetInt("blue1", 0);
        PlayerPrefs.SetInt("yellow1", 0);
        PlayerPrefs.SetInt("green1", 0);
        PlayerPrefs.SetString("t1",task());
        PlayerPrefs.SetString("t2",task());
        PlayerPrefs.SetString("t3",task());
        PlayerPrefs.SetInt("tap", 3);
        PlayerPrefs.SetInt("num", 30);
        switch (PlayerPrefs.GetInt("up2"))
        {
            case 1:
                ball = square;
                break;
            case 2:
                ball = izum;
                break;
            case 3:
                ball = saphire;
                break;
            case 4:
                ball = ruby;
                break;
            case 5:
                ball = diam;
                break;
            default:
                ball = square;
                break;
        }
        for (int i = 0; i <= 30; i++)
        {
            if (i % 10 == 0)
            {
                l += -0.5f;
                j = -2f;
            }
            Instantiate(ball, new Vector3(j, l, 0), Quaternion.identity);
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("num") - 1);
            j += 0.4f;
        }
    }
    string task()
    {
        float fl = Random.Range(0f, 4f);
        if (fl <= 1f && PlayerPrefs.GetInt("red1")!=1)
        {
            PlayerPrefs.SetInt("red1", 1);
            return "red";
        }
        else if (fl > 1f && fl <= 2f && PlayerPrefs.GetInt("blue1") != 1)
        {
            PlayerPrefs.SetInt("blue1", 1);
            return "blue";
        }
        else if (fl > 2f && fl <= 3f && PlayerPrefs.GetInt("yellow1") != 1)
        {
            PlayerPrefs.SetInt("yellow1", 1);
            return "yellow";
        }
        else if (fl > 3f && fl <= 4f && PlayerPrefs.GetInt("green1") != 1)
        {
            PlayerPrefs.SetInt("green1", 1);
            return "green";
        }
        else
        {
            return task();
        }
    }
    IEnumerator showbannerwhenready()
    {
        while (!Advertisement.IsReady("3271311"))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show("3271311");
    }
    private void Update()
    {
        StartCoroutine(showbannerwhenready());
        if (PlayerPrefs.GetInt("num") > 0)
        {
            if (PlayerPrefs.GetInt("bomb") == 1)
            {
                Instantiate(bomb, new Vector3(0, 3, 0), Quaternion.identity);
               PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("num") - 1);
             PlayerPrefs.SetInt("bomb", 0);
           }
            else
            {
                Instantiate(ball, new Vector3(0, 2, 0), Quaternion.identity);
                PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("num") - 1);
            }
        }
    }
}
