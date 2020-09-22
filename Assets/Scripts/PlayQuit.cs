using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{    
    public void Singleplayer() {
        SceneManager.LoadScene("Singleplayer");
    }

    public void Multiplayer() {
        SceneManager.LoadScene("Multiplayer");
    }

    public void Quit() {
        Application.Quit();
    }
}