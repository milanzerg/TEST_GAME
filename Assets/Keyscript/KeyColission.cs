using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class KeyColission : MonoBehaviour
{
    
    static public bool keyis = false;
   

     public GameObject[] keys = new GameObject[1];
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControl>())
        {
            keys[0].GetComponent<SpriteRenderer>().enabled = false;
            keyis = true;
        }
        
    }
}
