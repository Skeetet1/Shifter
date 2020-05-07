using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody rb;
    public Joystick joystick;
         // creates a window on the inspector to control value 
         public float forwardForce_Up =   50f;
        public float forwardForce_Down = -50; 
        public float forwardForce_Left =  -50;
        public float forwardForce_Right = 50f;
       
      
    void FixedUpdate()
    {

        //Time.deltaTime allows the frame rates to be even on all systems


        //Up
        if (joystick.Vertical >= .2f)
        {

            //adds force to an object rb.AddForce(X,Y,Z*Time.deltaTime);
            rb.AddForce(0, 0, forwardForce_Up * Time.deltaTime, ForceMode.VelocityChange);
        }

        //Down
        else if (joystick.Vertical <= -.5f)
        {

            rb.AddForce(0, 0, forwardForce_Down * Time.deltaTime, ForceMode.VelocityChange);
        }
       
    
    //Left

      if (joystick.Horizontal <= -.5f)
        {
       
       rb.AddForce(forwardForce_Left*Time.deltaTime,0,0, ForceMode.VelocityChange);
	   }
        
    
   // Right
    else if (joystick.Horizontal >= .5f){
       
       rb.AddForce(forwardForce_Right*Time.deltaTime,0,0, ForceMode.VelocityChange);
	   }




       if (rb.position.y <  -5f){
       FindObjectOfType<GamerManager>().EndGame();

	   }
        
    }
    
}
