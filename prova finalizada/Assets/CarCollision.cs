using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private Vector2 startPos;
    [SerializeField] private Transform ball;

    void Start() 
    {
        startPos = ball.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ball.position = startPos;
            print("Começa denovo kkk!");
        }
    }
}