using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kusdokunma : MonoBehaviour
{
    public Text txt;
    public float puan =0;
    public GameObject olumsahne;
    void Update()
    {
        if (gameObject.transform.position.y > 4.773f)
        {
            Destroy(gameObject);
            olumsahne.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "dead")
        {
            Destroy(gameObject);
            olumsahne.SetActive(true);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger")
        {
            puan++;
            txt.text = puan.ToString();
        }
    }
}
