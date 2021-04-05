using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
  
{
  
      public float gravity = -9.81f;
      Vector3 velocity; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
  transform.position += Vector3.forward * Time.deltaTime;
  velocity.y += gravity * Time.deltaTime;
     
}
}
