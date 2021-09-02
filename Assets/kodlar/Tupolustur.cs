using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Tupolustur : MonoBehaviour
{
    public GameObject og;
    private void Start()
    {
        InvokeRepeating("boruolustur",0,3);
    }
    void boruolustur()
    {
        Vector3 vcr = new Vector3(gameObject.transform.position.x, Random.RandomRange(-1f, 2f));
        Instantiate(og, vcr, transform.rotation);
    }
}
