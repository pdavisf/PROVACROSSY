using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCar4 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform Car4;
    public GameObject pos7, pos8;
    private Vector2 nextPos;

    void Start()
    {
        nextPos = pos8.transform.position;
    }
    void Update()
    {
        MovingCar();
    }
    void MovingCar()
    {
        if(Car4.position == pos7.transform.position)
        {
            nextPos = pos8.transform.position;
        }
        transform.position = Vector2.MoveTowards(Car4.position, nextPos, moveSpeed * Time.deltaTime);
    }
}
