using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminhareket : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.x <= -2)
        {
            gameObject.transform.position = new Vector2(2,gameObject.transform.position.y);
        }
        
            gameObject.transform.position += Vector3.left * Time.deltaTime * 2;
    }
}
