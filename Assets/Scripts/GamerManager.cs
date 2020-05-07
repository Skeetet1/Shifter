using UnityEngine;
using UnityEngine.SceneManagement;



    public class GamerManager : MonoBehaviour
    {
        public float restartDelay = 1f;

        public GameObject completeLevelUI;


        public void CompleteLevel()
        {

            completeLevelUI.SetActive(true);

        }


        bool gameHasEnded = false;
        public void EndGame()
        {



            if (gameHasEnded == false)
            {

                gameHasEnded = true;
                Debug.Log("GAME OVER");
                Invoke("Restart", restartDelay);
            }
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }


    }
