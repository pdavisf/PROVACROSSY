using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCar6 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car6;
    public GameObject pos11, pos12;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos12.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car6.position == pos11.transform.position)
        {
            nextPos = pos12.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car6.position, nextPos, moveSpeed * Time.deltaTime);
    }
}
