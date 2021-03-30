using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotor : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;
    public GameObject circle5;
    public GameObject circle6;
    private GameObject circle;
    public GameObject but;
    public Sprite blue, red;
    public Text help;
    private int fl = 0,i=0;
    private void Awake()
    {
        print(PlayerPrefs.GetInt("up1"));
        if (but.gameObject.name == "left")
        {
            switch (PlayerPrefs.GetInt("up1"))
            {
                case 2:
                    circle = Instantiate(circle2, circle2.transform.position, Quaternion.identity); ;
                    break;
                case 3:
                    circle = Instantiate(circle3, circle3.transform.position, Quaternion.identity); ;
                    break;
                case 4:
                    circle = Instantiate(circle4, circle4.transform.position, Quaternion.identity); ;
                    break;
                case 5:
                    circle = Instantiate(circle5, circle5.transform.position, Quaternion.identity); ;
                    break;
                case 6:
                    circle = Instantiate(circle6, circle6.transform.position, Quaternion.identity); ;
                    break;
                default:
                    circle = Instantiate(circle2, circle1.transform.position, Quaternion.identity); ;
                    break;
            }
        }
    }
    private void Start()
    {
        if (but.gameObject.name == "right")
        {
            switch (PlayerPrefs.GetInt("up1"))
            {
                case 2:
                    circle = GameObject.FindGameObjectWithTag("2");
                    break;
                case 3:
                    circle = GameObject.FindGameObjectWithTag("3");
                    break;
                case 4:
                    circle = GameObject.FindGameObjectWithTag("4");
                    break;
                case 5:
                    circle = GameObject.FindGameObjectWithTag("5");
                    break;
                case 6:
                    circle = GameObject.FindGameObjectWithTag("6");
                    break;
                default:
                    circle = GameObject.FindGameObjectWithTag("2");
                    break;
            }
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = red;
    }
    private void OnMouseUpAsButton()
    {
        if (but.gameObject.name == "left")
        {
            circle.transform.Rotate(Vector3.forward, 2);
            fl = 1;
            Destroy(help);
        }
        if (but.gameObject.name == "right")
        {
            Destroy(help);
            circle.transform.Rotate(Vector3.forward, -2);
            fl = 1;

        }
    }
    private void Update()
    {
        if (fl == 1)
        {
            if (but.gameObject.name == "left")
            {
                circle.transform.Rotate(Vector3.forward, 2);
                i += 2;
                if (i == 30)
                    fl = 0;
            }
            if (but.gameObject.name == "right")
            {
                circle.transform.Rotate(Vector3.forward, -2);
                i += 2;
                if (i == 30)
                    fl = 0;
            }
        }
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = blue;
        i = 0;
    }
}
