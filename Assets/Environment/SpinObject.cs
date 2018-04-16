using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour {

    [SerializeField] float xSpeed = 0f;

    [SerializeField] float ySpeed = 0f;

    [SerializeField] float zSpeed = 0f;

    void Update()
    {
        SpinInX();

        SpinInY(); 

        SpinInZ();
    }

    private void SpinInX()
    {
        transform.Rotate(Vector3.right, xSpeed * Time.deltaTime);
    }

    private void SpinInY()
    {
        transform.Rotate(Vector3.up, ySpeed * Time.deltaTime);
    }

    private void SpinInZ()
    {
        transform.Rotate(Vector3.forward, zSpeed * Time.deltaTime);
    }
}
