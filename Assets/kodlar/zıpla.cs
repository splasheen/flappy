using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zıpla : MonoBehaviour
{
    float kuvvet = 5;
    Rigidbody2D rgb2;
    private void Start()
    {
        rgb2 = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rgb2.AddForce(Vector3.up* kuvvet,ForceMode2D.Impulse);
        }
    }
}
