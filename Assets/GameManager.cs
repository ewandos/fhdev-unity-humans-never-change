using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerManager playerManager;

    private void Start()
    {
        playerManager.health.deathEvent += () => { Invoke(nameof(OnPlayerDeath), 1f);};
    }

    private void OnPlayerDeath()
    {
        SceneManager.LoadScene(1);
    }
}