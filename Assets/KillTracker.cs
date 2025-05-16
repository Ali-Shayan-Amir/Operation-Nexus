using UnityEngine;
using UnityEngine.SceneManagement;

public class KillTracker : MonoBehaviour
{
    public int killsToAdvance = 5;
    public string nextSceneName = "Level2";

    private int currentKills = 0;

    void Start()
    {
        // Reset kill count every time this scene is loaded
        currentKills = 0;
    }

    public void RegisterKill()
    {
        currentKills++;
        Debug.Log("Enemy killed. Count: " + currentKills);

        if (currentKills >= killsToAdvance)
        {
            SceneFaderWithLoading.instance.FadeToScene(nextSceneName);
        }
    }
}