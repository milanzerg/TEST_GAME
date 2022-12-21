using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropenscript1 : KeyColission
{
    
    public GameObject[] doors = new GameObject[1];


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControl>())
        {
            if (KeyColission.keyis == true)
            {
                Destroy(doors[0]);
            }
            else
            {
                Debug.Log("ключа нет");
            }
        }
    }

}
