using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    
    //bool is checking whether it's true or false
    private bool jumpKeyWasPressed;
    private float horizontalInput;

    
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        // tjek om space er presset ned
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space is pressed down");
            jumpKeyWasPressed = true;

            // 

            horizontalInput = Input.GetAxis("Horizontal");
        }
        

    }

    // FixedUpdate is called every time some physics updates 
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 1)
       

        if(jumpKeyWasPressed)

        GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.VelocityChange);
        if (jumpKeyWasPressed)
            jumpKeyWasPressed = false;
       

    }
  
}
