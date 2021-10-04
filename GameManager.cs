using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{ 
    public bool endGame = false;
    public GameObject completeLevelUI; 
    public void completeLevel()
    {
        completeLevelUI.SetActive(true); 
    }
    public void EndGame()
    {
        if (endGame == false)
        {
            endGame = true;
            Debug.Log("BLYAT GO TO GULAG");
            Invoke("Restart", 1.25f);
        }

    }   
    public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }

    
}