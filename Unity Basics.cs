using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityBasics : MonoBehaviour
{
    //- Start is called before the first frame update
    void Start()
    {
    }

    //- Update is called once per frame
    void Update()
    {
    }
}           //! base skeleton of a c# script in unity



//+ GameObject Manipulation

Instantiate(gameObject);    /// creating a game-object "spawning it"
Destroy(gameObject);    /// destroying/deleting a game-object

//- Accesing Components of Unity

Rigidbody rb;
rb = GetComponent<Rigidbody>();
/// Component that allows a GameObject to react to real-time physics

AudioSource audios;
audios = GetComponent<AudioSource>();
/// Component for playing back sounds in a 3D environment


//- Vectors

/// (x, y, z)
Vector3.right; /// (1, 0, 0)  
Vector3.left; /// (-1, 0, 0)
Vector3.up; /// (0, 1, 0)   
Vector3.down; /// (0, -1, 0)
Vector3.forward; /// (0, 0, 1)
Vector3.back; /// (0, 0, -1) 
Vector3.zero; /// (0, 0, 0)  
Vector3.one; /// (1, 1, 1)


//+ Rigidbody 

rb.AddForce() /// adds Force to a direction; e.g. up * 400
rb.velocity = Vector3; 

//+ Physics Event

//- both objects need a collider and atleast one of them a rigidbody
private void OnCollisionEnter(Collision hit) { }      /// just hit the game-object
private void OnCollisionStay(Collision hit) { }       /// keeps hitting the game-object
private void OnCollisionExit(Collision hit) { }       /// stopped hitting game-object


//+ Key Input


if (Input.GetKeyDown(KeyCode.X)) { }       /// key was pressed
if (Input.GetKeyUp(KeyCode.X)) { }      /// key was released
if (Input.GetKey(KeyCode.X)) { }      /// key being held down

