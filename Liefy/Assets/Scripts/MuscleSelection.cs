using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;
using System;

public class MuscleSelection : MonoBehaviour
{
    [SerializeField] RectTransform rt;

    Vector3 targetScale = new Vector3(2, 2, 0);

    float startscale;

    [SerializeField] float CornerOffset;

    [SerializeField] float ScaleTweenDuration;
    [SerializeField] float MovementTweenDuration;
    [SerializeField] float TargetScale;
    [SerializeField] float MovementDelay;
    Vector2 TargetPos;
    private void Start()
    {
        startscale = rt.localScale.x;
    }

    public void MoveToCorner()
    {
        TargetPos = new Vector3(0 + rt.rect.width + CornerOffset, 0 - rt.rect.height - CornerOffset * 2.5f, 2);
        rt.DOScale(TargetScale, ScaleTweenDuration);
        StartCoroutine(DelayedMovement(MovementDelay, false));
        GameObject.Find("BlackFade").GetComponent<SceneChanger>().FadeToScene(gameObject.name);
    }

    public void ReturnToTitle()
    {
        gameObject.SetActive(false);
        GameObject.Find("BlackFade").GetComponent<SceneChanger>().FadeToScene("MainMenu");
    }

    private IEnumerator DelayedMovement(float delay, bool delete)
    {
        yield return new WaitForSeconds(delay);
        rt.DOAnchorPos(TargetPos, MovementTweenDuration);
        if (delete)
        {
            Destroy(gameObject);
        }
    }
}
