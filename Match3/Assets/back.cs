using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public Text money;
    public Text add;
    public Sprite blue, red;
    private const string videoad = "ca-app-pub-6094702951680356/7658547332";
    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3271311", false);
        }
    }
    private void Update()
    {
        money.GetComponent<Text>().text = PlayerPrefs.GetInt("money").ToString();
        if(Application.loadedLevelName == "win")
        add.GetComponent<Text>().text = "+" + (10+(PlayerPrefs.GetInt("lastscore") /1000)).ToString();
        if (Application.loadedLevelName == "lose")
            add.GetComponent<Text>().text = "+" + (PlayerPrefs.GetInt("lastscore")/1000).ToString();
     }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = red;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = blue;
    }
    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetInt("win") != 3)
        {
            if (Advertisement.IsReady() && (Application.loadedLevelName == "lose" || Application.loadedLevelName == "win"))
            {
                Advertisement.Show();
            }
            Application.LoadLevel("menu");
            PlayerPrefs.SetInt("win", 0);
            PlayerPrefs.SetInt("tap", 3);
        }
        else
        {
            if (Advertisement.IsReady() && (Application.loadedLevelName == "lose" || Application.loadedLevelName == "win"))
            {
                Advertisement.Show();
            }
            Application.LoadLevel("play");
            PlayerPrefs.SetInt("win", 0);
            PlayerPrefs.SetInt("tap", 3);
        }
    }
}
