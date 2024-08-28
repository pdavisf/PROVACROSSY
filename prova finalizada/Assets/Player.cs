using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
 
    void Update()
    { 
        VerticalMove();
        HorizontalMove();
    }
    void VerticalMove()
    {
        Vector3 direction = new Vector3(0f,Input.GetAxis("Vertical"), 0f);
        transform.position += direction *Time.deltaTime*speed;
    }
    void HorizontalMove()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += direction *Time.deltaTime*speed;
    }
}