using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GamerManager gamerManager;
    
   void OnTriggerEnter()
    {
    gamerManager.CompleteLevel();

	}
}
