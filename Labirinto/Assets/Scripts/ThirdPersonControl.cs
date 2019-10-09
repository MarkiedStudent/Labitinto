using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonControl : MonoBehaviour
{
    Rigidbody rb;
    public float vel = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity=( moveVector * 10 );
        //transform.Translate(moveVector);
    }
}
