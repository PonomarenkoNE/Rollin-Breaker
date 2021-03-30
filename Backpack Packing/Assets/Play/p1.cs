using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    private Vector3 mOffset;
    public GameObject obj;
    float a;
    void OnMouseDown()
    {
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        return Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, obj.transform.position.y));
    }
    void OnMouseDrag()
    {
        /*if (obj.transform.position.x > -2.25 && obj.transform.position.x < 2.25)
            transform.position = GetMouseAsWorldPoint() + mOffset;
        else if (obj.transform.position.x < -2.25)
            transform.position = new Vector2(-2.24f,obj.transform.position.y);
        else if (obj.transform.position.x > 2.25)
            transform.position = new Vector2(2.24f, obj.transform.position.y);*/
        if (obj.transform.position.x > -1.75 && obj.transform.position.x < 1.75)
            transform.position = GetMouseAsWorldPoint() + mOffset;
        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > -1.75 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 1.75)
            transform.position = GetMouseAsWorldPoint() + mOffset;
    }
}
