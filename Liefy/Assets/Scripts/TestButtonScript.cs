using UnityEngine;
using UnityEngine.SceneManagement;

public class TestButtonScript : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
