using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject player;
    public bool IsOpen;
    private PlayerScript keyScript;

    public void Start()
    {
        keyScript = player.GetComponent<PlayerScript>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
            if (keyScript.hasKey == true)
            {
                IsOpen = true;
                keyScript.hasKey = false;
            }
            if (IsOpen)
            {
                gameObject.transform.position = gameObject.transform.position - new Vector3(0, 4, 0);
                IsOpen = false;
            }
        }
    }
}
