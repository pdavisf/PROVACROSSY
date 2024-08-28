using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class MoveCar : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car;
    public GameObject pos1, pos2;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos2.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car.position == pos1.transform.position)
        {
            nextPos = pos2.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car.position, nextPos, moveSpeed * Time.deltaTime);
    }
    
}
