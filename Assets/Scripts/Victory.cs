using UnityEngine;

public class VictoryZone : MonoBehaviour
{
    public GameObject victoryMessage; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victoryMessage.SetActive(true); 
            Invoke("HideVictoryMessage", 4f); 
        }
    }

    private void HideVictoryMessage()
    {
        victoryMessage.SetActive(false);
    }
}


