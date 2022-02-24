using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Object //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        Move();
    }

    //POLYMORPHISM
    protected override void Move()
    {
        Rb.AddForce(vecTarget * objSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
