using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sciptv0 : MonoBehaviour
{
    public float jumpForce;
    Rigidbody rb;
    bool isGrounded;
    //* Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //* Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.addForce(Vector3.up * jumpForce);
        }
    }
    private void OnMouseDown() {
        
    }
}