using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    [SerializeField]
    private Part[] parts;

    private void Start()
    {
        foreach(Part part in parts)
        {
            part.Init(this);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack1();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack2();
        }
    }

    //Horrible naming, but this opens two functions for interchangable attacks
    public void Attack1()
    {
        StartCoroutine(parts[0].ExecuteAttack());
    }
    public void Attack2()
    {
        StartCoroutine(parts[1].ExecuteAttack());
    }
}
