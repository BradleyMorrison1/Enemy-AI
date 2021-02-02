using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 moveDirection = Vector3.back;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall") || other.CompareTag("Enemy"))
        {
            Debug.Log("Hit Wall");

            if (moveDirection == Vector3.back)
            {
                moveDirection = Vector3.forward;
            }

            else
            {
                moveDirection = Vector3.back;
            }
        }
    }

    private void FixedUpdate()
    {
        gameObject.transform.position += (moveDirection) * Time.deltaTime * moveSpeed;
    }
}
