using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour
{
public void StartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
