using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void GoToStart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void GoToCharacters()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Stop()
    {
        Application.Quit();
    }
}