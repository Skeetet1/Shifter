using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

   void OnCollisionEnter (Collision collisionInfo)
   {


   if (collisionInfo.collider.tag == "Obstacle")
   {

  movement.enabled = false ;  //Disable player movement 

  FindObjectOfType<GamerManager>().EndGame();
   

   }
   
   
   }



}
