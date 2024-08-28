using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar5 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car5;
    public GameObject pos9, pos10;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos10.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car5.position == pos9.transform.position)
        {
            nextPos = pos10.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car5.position, nextPos, moveSpeed * Time.deltaTime);
    }
}
