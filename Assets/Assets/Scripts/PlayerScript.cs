using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool hasKey = false;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "key")
        {
            hasKey = true;
            Destroy(collision.gameObject);
        }

    }

}
