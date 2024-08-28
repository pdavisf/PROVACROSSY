using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar2 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car2;
    public GameObject pos3, pos4;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos3.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car2.position == pos3.transform.position)
        {
            nextPos = pos4.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car2.position, nextPos, moveSpeed * Time.deltaTime);
    }
}
