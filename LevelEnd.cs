using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().completeLevel(); 
    }
}
