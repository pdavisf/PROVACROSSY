using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoceCar3 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car3;
    public GameObject pos5, pos6;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos6.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car3.position == pos5.transform.position)
        {
            nextPos = pos6.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car3.position, nextPos, moveSpeed * Time.deltaTime);
    }
}
