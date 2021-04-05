
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 0f;
    public float WalkSpeed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float RunSpeed = 12f;

    public Transform GroundCheck;
    public float groundDistance = 0.04f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
         
        controller.Move(move * moveSpeed * Time.deltaTime);

{
        if(Input.GetKey (KeyCode.LeftShift))

      

            moveSpeed = RunSpeed;
            else
              moveSpeed = WalkSpeed;
            

           
        
      

    
        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        
    }
}

}