using System.Collections;
using UnityEngine;

public class BodySideManager : MonoBehaviour
{
    GameObject[] FrontMuscles;
    GameObject[] BackMuscles;

    private void Start()
    {
        FrontMuscles = GameObject.FindGameObjectsWithTag("Front");
        BackMuscles = GameObject.FindGameObjectsWithTag("Back");
        StartCoroutine(InitialDisableBack());
    }

    public void DisableFrontButtons()
    {
        foreach (GameObject Muscle in FrontMuscles)
        {
            Muscle.SetActive(false);
        }
    }
    public void EnableFrontButtons()
    {
        foreach (GameObject Muscle in FrontMuscles)
        {
            Muscle.SetActive(true);
        }
    }
    public void DisableBackButtons()
    {
        foreach (GameObject Muscle in BackMuscles)
        {
            Muscle.SetActive(false);
        }
    }
    public void EnableBackButtons()
    {
        foreach (GameObject Muscle in BackMuscles)
        {
            Muscle.SetActive(true);
        }
    }

    private IEnumerator InitialDisableBack()
    {
        yield return new WaitForSeconds(0.5f);
        DisableBackButtons();
    }
}
