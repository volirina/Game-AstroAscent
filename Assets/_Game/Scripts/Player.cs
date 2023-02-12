using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            GameManager.Instance.IncrementDeaths();
        }
        if (other.CompareTag("LevelTwo"))
        {
            GameManager.Instance.LoadLevelTwo();
        }

        if (other.CompareTag("LevelThree"))
        {
            GameManager.Instance.LoadLevelThree();
        }

        if (other.CompareTag("WinGame"))
        {
            GameManager.Instance.WinLevel();
        }
    }
}
