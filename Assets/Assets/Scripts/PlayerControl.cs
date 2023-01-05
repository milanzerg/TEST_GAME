using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UIElements;

public class PlayerControl : MonoBehaviour
{
    public GameObject[] player = new GameObject[1];
    public float speed = 5.0f;

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speed * v);

        float h = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed * h);

    }
}