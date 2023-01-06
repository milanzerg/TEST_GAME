using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    private PlayerScript playerScript;
    float startTime = 0f;
    float shieldTime = 3f;

    void Start()
    {
        playerScript = target.gameObject.GetComponent<PlayerScript>();
    }

    void Update()
    {
        startTime = startTime + 0.1f;
        if (startTime > shieldTime)
        {
            playerScript.Shield = false;
            startTime = 0f;
        }
        if (Vector3.Distance(transform.position, target.position) > 1.1f && Vector3.Distance(transform.position, target.position) < 8f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (Vector3.Distance(transform.position, target.position) <= 1.1f && playerScript.Shield == false)
        {
            playerScript.HP--;
            playerScript.Shield = true;
            startTime = Time.time;
        }
    }
}
