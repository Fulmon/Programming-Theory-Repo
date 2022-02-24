using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Object : MonoBehaviour
{
    public float objSpeed;

    protected Rigidbody Rb;

    //ENCAPSULATION
    protected Vector3 vecTarget { get; set; }

    //POLYMORPHISM
    protected virtual void Move()
    {
        Rb.AddForce(vecTarget * objSpeed * Time.deltaTime, ForceMode.Acceleration);
    }

    private void OnTriggerStay(Collider other)
    {
        vecTarget = other.gameObject.transform.position - transform.position;
    }
}
