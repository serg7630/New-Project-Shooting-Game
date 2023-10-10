using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditGravity : MonoBehaviour
{
    private new Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(0, 0, 2.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
