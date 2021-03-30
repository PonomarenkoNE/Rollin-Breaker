using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2 : MonoBehaviour
{
    public Vector2 direction;
    public float acc;
    public Rigidbody2D rb;
    public GameObject objball;
    private GameObject inst_obj;
    private int sc = 0;
    private int fl = 0;
    private void OnTriggerOut2D(Collider2D collision)
    {
        if (fl == 1)
        {
            fl = 0;
            rb.AddForce(direction.normalized * acc, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objball.transform.position = new Vector2(0, 0);
        fl = 1;
        sc++;
        PlayerPrefs.SetInt("sc2", sc);
        PlayerPrefs.SetInt("fl1", 1);
        if(sc == 10)
        {
            Application.LoadLevel("win");
        }
    }
}
