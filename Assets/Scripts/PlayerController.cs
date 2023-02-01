using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Rigidbody2D playerRB;
    //private float speed = 5; 
    //
    // Start is called before the first frame update
    //void Start()
    //{
    //    playerRB = GetComponent<Rigidbody2D>();
    //}
    //
    // Update is called once per frame
    //void Update()
    //{
    //    LookAtMouse();
    //    Move();
    //}
    //
    //Makes the player always look towards the mouse. Currently not implemented.
    //private void LookAtMouse()
    //{
    //    Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    transform.up = (Vector3)(mousePos - new Vector2(transform.position.x, transform.position.y));
    //}
    //
    //Moves the player to the mouse. Currently not working.
    //private void Move()
    //{
    //    var input = new Vector2(x: Input.GetAxisRaw("Horizontal"), y: Input.GetAxisRaw("Vertical"));
    //    playerRB.velocity = input.normalized * speed;
    //}
}   //
