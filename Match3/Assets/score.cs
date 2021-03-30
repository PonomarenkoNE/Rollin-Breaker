using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text taps;
    public Text level;
    public Text t1;
    public Text t2;
    public Text t3;
    private int sc = 0;
    private AudioSource bon, reg;
    private void Start()
    {
        bon = GetComponent<AudioSource>();
        reg = taps.GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if(PlayerPrefs.GetInt("tap") <= 0)
        {
            Application.LoadLevel("lose");
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + sc/1000);
        }
        if(PlayerPrefs.GetInt("win") >= 3)
        {
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10 + sc / 1000);
            Application.LoadLevel("win");
        }
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("numbuf") < 3 && PlayerPrefs.GetInt("numbuf")>0)
        {
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") - 1);
            sc += PlayerPrefs.GetInt("numbuf") * 1;
        }
        else if(PlayerPrefs.GetInt("numbuf") == 3)
        {
            if (PlayerPrefs.GetInt("mut") == 0)
                reg.Play();
            sc += PlayerPrefs.GetInt("numbuf") * 10;
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("numbuf"));
            if (PlayerPrefs.GetInt("bomb") == 2)
                PlayerPrefs.SetInt("bomb", 0);
        }
        else if(PlayerPrefs.GetInt("numbuf") == 4)
        {
            if (PlayerPrefs.GetInt("mut") == 0)
                reg.Play();
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") + 2);
            sc += PlayerPrefs.GetInt("numbuf") * 50;
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("numbuf"));
            if (PlayerPrefs.GetInt("bomb") == 2)
                PlayerPrefs.SetInt("bomb", 0);
        }
        else if(PlayerPrefs.GetInt("numbuf") == 5)
        {
            if (PlayerPrefs.GetInt("mut") == 0)
                bon.Play();
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") + 2);
            sc += PlayerPrefs.GetInt("numbuf") * 100;
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("numbuf")+1);
            if (PlayerPrefs.GetInt("bomb") == 2)
                PlayerPrefs.SetInt("bomb", 0);
        }
        else if (PlayerPrefs.GetInt("numbuf") == 6)
        {
            if (PlayerPrefs.GetInt("mut") == 0)
                bon.Play();
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") + 2);
            sc += PlayerPrefs.GetInt("numbuf") * 100;
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("numbuf")+1);
            if (PlayerPrefs.GetInt("bomb") == 2)
                PlayerPrefs.SetInt("bomb", 0);
        }
        else if(PlayerPrefs.GetInt("numbuf") >= 7)
        {
            if (PlayerPrefs.GetInt("mut") == 0)
                bon.Play();
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") + 2);
            sc += PlayerPrefs.GetInt("numbuf") * 100;
            PlayerPrefs.SetInt("num", PlayerPrefs.GetInt("numbuf")+1);
            if (PlayerPrefs.GetInt("bomb") == 2)
                PlayerPrefs.SetInt("bomb", 0);
            else
            PlayerPrefs.SetInt("bomb", 1);
        }
        PlayerPrefs.SetInt("numbuf",0);
        task(PlayerPrefs.GetString("t1"), t1);
        task(PlayerPrefs.GetString("t2"), t2);
        task(PlayerPrefs.GetString("t3"), t3);
        level.GetComponent<Text>().text = "Level " + PlayerPrefs.GetInt("level").ToString();
        GetComponent<Text>().text = "Score: " + sc.ToString();
        taps.GetComponent<Text>().text = "Taps: " + PlayerPrefs.GetInt("tap").ToString();
        PlayerPrefs.SetInt("lastscore", sc);
        if(PlayerPrefs.GetInt("sc") < sc)
        {
            PlayerPrefs.SetInt("sc", sc);
        }
    }
    void task(string col,Text t)
    {
        switch (col)
        {
            case "red":
                if (PlayerPrefs.GetInt("red") < 10)
                {
                    t.GetComponent<Text>().text = "Red " + PlayerPrefs.GetInt("red").ToString() + "/10";
                }
                else
                {
                    if (PlayerPrefs.GetString("t1") == "red")
                    {
                        PlayerPrefs.SetString("t1", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t2") == "red")
                    {
                        PlayerPrefs.SetString("t2", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t3") == "red")
                    {
                        PlayerPrefs.SetString("t3", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    
                }
                break;
            case "blue":
                if (PlayerPrefs.GetInt("blue") < 10)
                {
                    t.GetComponent<Text>().text = "Blue " + PlayerPrefs.GetInt("blue").ToString() + "/10";
                }
                else
                {
                    if (PlayerPrefs.GetString("t1") == "blue")
                    {
                        PlayerPrefs.SetString("t1", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t2") == "blue")
                    {
                        PlayerPrefs.SetString("t2", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t3") == "blue")
                    {
                        PlayerPrefs.SetString("t3", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                }
                break;
            case "yellow":
                if (PlayerPrefs.GetInt("yellow") < 10)
                {
                    t.GetComponent<Text>().text = "Yellow " + PlayerPrefs.GetInt("yellow").ToString() + "/10";
                }
                else
                {
                    if (PlayerPrefs.GetString("t1") == "yellow")
                    {
                        PlayerPrefs.SetString("t1", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t2") == "yellow")
                    {
                        PlayerPrefs.SetString("t2", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t3") == "yellow")
                    {
                        PlayerPrefs.SetString("t3", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                }
                break;
            case "green":
                if (PlayerPrefs.GetInt("green") < 10)
                {
                    t.GetComponent<Text>().text = "Green " + PlayerPrefs.GetInt("green").ToString() + "/10";
                }
                else
                {
                    if (PlayerPrefs.GetString("t1") == "green")
                    {
                        PlayerPrefs.SetString("t1", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t2") == "green")
                    {
                        PlayerPrefs.SetString("t2", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                    if (PlayerPrefs.GetString("t3") == "green")
                    {
                        PlayerPrefs.SetString("t3", "tr");
                        PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                        t.GetComponent<Text>().text = "Completed";
                    }
                }
                break;
            case "nothing":
                if (PlayerPrefs.GetString("t1") == "nothing")
                {
                    PlayerPrefs.SetString("t1", "tr");
                    PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                    Destroy(t);
                }
                if (PlayerPrefs.GetString("t2") == "nothing")
                {
                    PlayerPrefs.SetString("t2", "tr");
                    PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                    Destroy(t);
                }
                if (PlayerPrefs.GetString("t3") == "nothing")
                {
                    PlayerPrefs.SetString("t3", "tr");
                    PlayerPrefs.SetInt("win", PlayerPrefs.GetInt("win") + 1);
                    Destroy(t);
                }
                break;

        }
    }
}
