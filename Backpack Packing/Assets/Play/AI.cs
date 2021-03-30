using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject objball;
    public GameObject objbot;
    public Rigidbody2D rb;
    public float speed;
    private int y;
    private int fl;
    private int i=0;
    private void Start()
    {
        PlayerPrefs.SetInt("fl1", 0);
        fl = PlayerPrefs.GetInt("dif");
    }
    private void FixedUpdate()
    {
        if (objball.transform.position.y > 0)
        {
            if(i == fl)
            {
                rb.velocity = new Vector2(0f, 0f);
            }
            else if (objball.transform.position.x > objbot.transform.position.x && objbot.transform.position.x < 1.6f)
            {
                rb.velocity = new Vector2(1, 0) * speed;
            }
            else if (objball.transform.position.x < objbot.transform.position.x && objbot.transform.position.x > -1.6f)
            {
                rb.velocity = new Vector2(-1, 0) * speed;
            }
            if (PlayerPrefs.GetInt("fl1") == 1)
            {
                PlayerPrefs.SetInt("fl1", 0);
                i = 0;
            }
        }
        else
            rb.velocity = new Vector2(0f, 0f);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (objbot.transform.position.x > -1.6f && objbot.transform.position.x < 1.6f)
        {
                if (i <= 10 && i != fl)
                    i++;
        }
    }
}
