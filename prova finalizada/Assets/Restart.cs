using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private Vector2 prevPos;

    [SerializeField] Transform Car;
    void Start()
    {
        prevPos = Car.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Car.position = prevPos;
        }
    }

}
