
using UnityEngine;

public class FollowPLayer : MonoBehaviour
{

  public Transform player; 
  // stores 3 floats 
  
  
  public Vector3 offset;



    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.position + offset;

    }
}
