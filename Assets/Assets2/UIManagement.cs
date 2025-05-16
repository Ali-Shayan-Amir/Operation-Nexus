using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Controls;
    public GameObject PauseMenu; // NEW

    private bool isPaused = false;

    void Start()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Controls.SetActive(false);
        PauseMenu.SetActive(false); // Make sure it starts hidden
        Time.timeScale = 1f; // Ensure time is normal
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void SettingsBtn()
    {
        Settings.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void StartGameBtn()
    {
        SceneManager.LoadScene("Assets/_Barking_Dog/3D Free Modular Kit/Test_Map.unity");
    }

    public void QuitGameBtn()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void ControlsBtn()
    {
        Controls.SetActive(true);
        Settings.SetActive(false);
    }

    public void BackToMainMenuBtn()
    {
        MainMenu.SetActive(true);
        Settings.SetActive(false);
        Controls.SetActive(false);
    }
}
