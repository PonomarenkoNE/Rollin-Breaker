using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public GameObject bol;
    private Color c;
    private Vector4 red = new Vector4(1, 0, 0, 1);
    private Vector4 blue = new Vector4(0, 0, 1, 1);
    private Vector4 yellow = new Vector4(1, 0.92f, 0.016f, 1);
    private Vector4 green = new Vector4(0, 1, 0, 1);
    private float fl = 0;
    private int fl1 = 0,i=0;
    private int fl2 = 1;
    private string str;
    private AudioSource au;
    private void Start()
    {
        au = GetComponent<AudioSource>();
        PlayerPrefs.SetInt("numbuf", 0);
        if (bol.gameObject.name != "bomb(Clone)")
        {
            PlayerPrefs.SetInt("fl", 0);
            fl = Random.Range(0f, 4f);
            if (fl <= 1f)
            {
                c = red;
                fl1 = 1;
                PlayerPrefs.SetInt("numr", PlayerPrefs.GetInt("numr") + 1);
            }
            else if (fl > 1f && fl <= 2f)
            {
                c = blue;
                fl1 = 2;
                PlayerPrefs.SetInt("numb", PlayerPrefs.GetInt("numb") + 1);
            }
            else if (fl > 2f && fl <= 3f)
            {
                c = yellow;
                fl1 = 3;
                PlayerPrefs.SetInt("numy", PlayerPrefs.GetInt("numy") + 1);
            }
            else if (fl > 3f && fl <= 4f)
            {
                c = green;
                fl1 = 4;
                PlayerPrefs.SetInt("numg", PlayerPrefs.GetInt("numg") + 1);
            }
            bol.GetComponent<SpriteRenderer>().material.color = c;
        }
        else
        {
            if (PlayerPrefs.GetInt("fl") == 1)
            {
                c = red;
                fl1 = 1;
            }
            else if (PlayerPrefs.GetInt("fl") == 2)
            {
                c = blue;
                fl1 = 2;
            }
            else if (PlayerPrefs.GetInt("fl") == 3)
            {
                c = yellow;
                fl1 = 3;
            }
            else if (PlayerPrefs.GetInt("fl") == 4)
            {
                c = green;
                fl1 = 4;
            }
            bol.GetComponent<SpriteRenderer>().material.color = c;
            PlayerPrefs.SetInt("fl", 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (i == 0)
        {
            if(PlayerPrefs.GetInt("mut")==0)
            au.Play();
            i = -2;
        }
        else
        {
            i++;
        }
    }
    private void OnMouseDown()
    {
        if (bol.gameObject.name != "bomb(Clone)")
        {
            PlayerPrefs.SetInt("i", 0);
            PlayerPrefs.SetInt("fl", fl1);
            bol.gameObject.name = "tr";
        }
        else
        {
            PlayerPrefs.SetInt("fl", fl1);
            PlayerPrefs.SetInt("bomb", 2);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (PlayerPrefs.GetInt("bomb") == 2)
        {
            if(PlayerPrefs.GetInt("fl") == fl1)
            {
                if(fl1 == 1)
                {
                    PlayerPrefs.SetInt("numbuf", PlayerPrefs.GetInt("numr")+2);
                    PlayerPrefs.SetInt("red", PlayerPrefs.GetInt("red") + PlayerPrefs.GetInt("numbuf"));
                }
                else if(fl1 == 2)
                {
                    PlayerPrefs.SetInt("numbuf", PlayerPrefs.GetInt("numb")+2);
                    PlayerPrefs.SetInt("blue", PlayerPrefs.GetInt("blue") + PlayerPrefs.GetInt("numbuf"));
                }
                else if(fl1 == 3)
                {
                    PlayerPrefs.SetInt("numbuf", PlayerPrefs.GetInt("numy")+2);
                    PlayerPrefs.SetInt("yellow", PlayerPrefs.GetInt("yellow") + PlayerPrefs.GetInt("numbuf"));
                }
                else if(fl1 == 4)
                {
                    PlayerPrefs.SetInt("numbuf", PlayerPrefs.GetInt("numg") + 2);
                    PlayerPrefs.SetInt("green", PlayerPrefs.GetInt("green") + PlayerPrefs.GetInt("numbuf"));
                }
                Destroy(bol);
            }
        }
        if(collision.gameObject.GetComponent<SpriteRenderer>().material.color == c)
        {
            if(PlayerPrefs.GetInt("fl") == fl1)
            {
                if(collision.gameObject.name == "tr" && bol.gameObject.name != "tr")
                {
                    bol.gameObject.name = "tr";
                    PlayerPrefs.SetInt("i", PlayerPrefs.GetInt("i")+1);
                }
            }
        }
        if(PlayerPrefs.GetInt("i") == -1)
        {
            if(collision.gameObject.name == "tr")
            {
                collision.gameObject.name = "netr";
            }
            if(bol.gameObject.name == "tr")
            {
                bol.gameObject.name = "netr";
            }
        }
    }
    private void OnMouseUp()
    {
        if (PlayerPrefs.GetInt("i") >= 2)
        {
            switch (fl1)
            {
                case 1:
                    PlayerPrefs.SetInt("red", PlayerPrefs.GetInt("red") + PlayerPrefs.GetInt("i") +1);
                    break;
                case 2:
                    PlayerPrefs.SetInt("blue", PlayerPrefs.GetInt("blue") + PlayerPrefs.GetInt("i") +1);
                    break;
                case 3:
                    PlayerPrefs.SetInt("yellow", PlayerPrefs.GetInt("yellow") + PlayerPrefs.GetInt("i") +1);
                    break;
                case 4:
                    PlayerPrefs.SetInt("green", PlayerPrefs.GetInt("green") + PlayerPrefs.GetInt("i") +1);
                    break;
            }
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") - 1);
            if (fl1 == 1)
            {
                PlayerPrefs.SetInt("numr", PlayerPrefs.GetInt("numr") - 1);
            }
            else if (fl1 == 2)
            {
                PlayerPrefs.SetInt("numb", PlayerPrefs.GetInt("numb") - 1);
            }
            else if (fl1 == 3)
            {
                PlayerPrefs.SetInt("numy", PlayerPrefs.GetInt("numy") - 1);
            }
            else if (fl1 == 4)
            {
                PlayerPrefs.SetInt("numg", PlayerPrefs.GetInt("numg") - 1);
            }
            Destroy(bol);
            PlayerPrefs.SetInt("i", 0);
        }
        else
        {
            PlayerPrefs.SetInt("tap", PlayerPrefs.GetInt("tap") - 1);
            PlayerPrefs.SetInt("i", -1);
            PlayerPrefs.SetInt("fl", -1);
            bol.gameObject.name = "netr";
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().material.color == c)
        {
            if (PlayerPrefs.GetInt("fl") == fl1)
            {
                if (bol.gameObject.name == "tr" && PlayerPrefs.GetInt("i") != -1)
                {
                    bol.gameObject.name = "tr1";
                    PlayerPrefs.SetInt("numbuf", PlayerPrefs.GetInt("numbuf") + 1);
                    if (fl1 == 1)
                    {
                        PlayerPrefs.SetInt("numr", PlayerPrefs.GetInt("numr")-1);
                    }
                    else if (fl1 == 2)
                    {
                        PlayerPrefs.SetInt("numb", PlayerPrefs.GetInt("numb")-1);
                    }
                    else if (fl1 == 3)
                    {
                        PlayerPrefs.SetInt("numy", PlayerPrefs.GetInt("numy")-1);
                    }
                    else if (fl1 == 4)
                    {
                        PlayerPrefs.SetInt("numg", PlayerPrefs.GetInt("numg")-1);
                    }
                    Destroy(bol);
                }
                else
                    PlayerPrefs.SetInt("i", 0);
            }
        }
    }
}
