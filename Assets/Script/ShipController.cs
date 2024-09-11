using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int HealthPoint;
    //[SerializeField] List<WeaponModule> weaponsmodules = newList<WeaponModule>();

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            MovingForwardBackward();
            Debug.Log("Z");
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovingLeftRight();
            Debug.Log("D");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            MovingUpDown();
            Debug.Log("Up");
        }
    }

    //manage movement left-right / forward-backward (up down)
    void MovingForwardBackward()
    {
        Vector3 position = transform.position;
        position += transform.forward;
        transform.position = position;
    }
    void MovingLeftRight()
    {
        Vector3 position = transform.position;
        position += transform.right;
        transform.position = position;
    }
    void MovingUpDown()
    {
        Vector3 position = transform.position;
        position += transform.up;
        transform.position = position;
    }

    //manage orientation of the ship
    void RotateBarrel()
    {

    }
    void RotateLeftRight()
    {

    }
    void RotateUpDown()
    {

    }

    //do an up down fct
}
