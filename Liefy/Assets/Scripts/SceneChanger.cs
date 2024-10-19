using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    GameObject FadeObject;
    Animator animator;

    string SceneToLoad;
    
    private void Start()
    {
        FadeObject = GameObject.Find("BlackFade");
        animator = FadeObject.GetComponent<Animator>();
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(FadeObject);
    }

    public void FadeToScene(string sceneName)
    {
        SceneToLoad = sceneName;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
