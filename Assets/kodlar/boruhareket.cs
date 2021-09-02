using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boruhareket : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        if (transform.position.x <= -3.43)
        {
            Destroy(gameObject);
        }
        
    }
}
