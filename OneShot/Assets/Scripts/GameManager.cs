using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int enemiesAlive = 0;
    public bool hasFired = false;

    void Awake()
    {
        Instance = this;

    }

    public void EnemyDied()
    {
        enemiesAlive--;
        if (enemiesAlive <= 0)
        {
            WinLevel();
        }
    }

    void WinLevel()
    {
        Debug.Log("LEVEL CLEARED!");
        Time.timeScale = 1f;
    }

    public void FailLevel()
    {
        Debug.Log("FAIL - TRY AGAIN!");
        Time.timeScale = 1f;
    }
}
