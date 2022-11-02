using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private float movmentSpeed = 5;
    //bool is checking whether it's true or false
    // also yes and no
    //true is 1 
    // false is 0
    private bool jumpKeyWasPressed;
    private float horizontalInput;

    public string playerName;
    public int jumpLevel;
    public int jump;
    

    // Start is called before the first frame update
    void Start()
    {
         playerName = "Time";
        Debug.Log($"The players name is:  " + playerName);

        jump = 2;
        jumpLevel = 1;

        



    }

   

    // Update is called once per frame
    void Update()
    {
       
        // tjek om space er presset ned
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space is pressed down");
            jumpKeyWasPressed = true;

            jumpLevel = jumpLevel + jump;
            CharacterVal(playerName , jumpLevel);
            // 

            horizontalInput = Input.GetAxis("Horizontal");

            

            

           Debug.Log("jump/space key was pressed add 1 to" + jumpLevel);

            





        }
        

    }

    // FixedUpdate is called every time some physics updates 
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput*movmentSpeed, GetComponent<Rigidbody>().velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 1)
       

        if(jumpKeyWasPressed)

        GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.VelocityChange);
        if (jumpKeyWasPressed)
            jumpKeyWasPressed = false;
       

    }

    void CharacterVal(string a,int b)
    {
        
       Debug.Log("name" + a + "jump level" +b);
    }
  
}
