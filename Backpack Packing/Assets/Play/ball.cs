using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Vector2 direction;
    public float acc;
    public Rigidbody2D rb;
    void Start()
    {
        rb.AddForce(direction.normalized * acc, ForceMode2D.Impulse);
        PlayerPrefs.SetInt("sc1", 0);
        PlayerPrefs.SetInt("sc2", 0);
    }
    /*public float speed;
    public GameObject obj;
    public Vector3 vec1;
    public Vector3 vec2;
    public Vector3 vec3;
    public Vector3 vec4;
    public int a=1;
    private string ch;
    void FixedUpdate()
    {
        switch (a)
        {
            case 1:
                obj.transform.Translate(vec1 * speed * Time.deltaTime);
                break;
            case 2:
                obj.transform.Translate(vec2 * speed * Time.deltaTime);
                break;
            case 3:
                obj.transform.Translate(vec3 * speed * Time.deltaTime);
                break;
            case 4:
                obj.transform.Translate(vec4 * speed * Time.deltaTime);
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ch = collision.gameObject.name;
        if(ch != "upborder" && ch != "downborder")
        switch (a)
        {
            case 1:
                a = 3;
                break;
            case 2:
                a = 4;
                break;
            case 3:
                a = 1;
                break;
            case 4:
                a = 2;
                break;
        }
        else
            switch (a)
            {
                case 1:
                    a = 4;
                    break;
                case 2:
                    a = 3;
                    break;
                case 3:
                    a = 2;
                    break;
                case 4:
                    a = 1;
                    break;
            }
    }*/
}
