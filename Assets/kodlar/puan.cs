using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puan : MonoBehaviour
{
    public float puann = 0;
    //public Text txt;
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "kus")
        {
            puann++;
        }
    }
}
