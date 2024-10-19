using UnityEngine;
using DG.Tweening;
using System.Collections;

public class TweenAnimation : MonoBehaviour
{
    [SerializeField] RectTransform rt;
    [SerializeField] float delay;
    [SerializeField] float TweenDuration;
    [SerializeField] Vector2 TargetPos;
    void Start()
    {
        StartCoroutine(DelayedTweenToPos(delay));
    }

    IEnumerator DelayedTweenToPos(float delay)
    {
        Debug.Log("Coroutine Started");
        yield return new WaitForSeconds(delay);
        rt.DOAnchorPosY(TargetPos.y, TweenDuration);
        Debug.Log("Coroutine Ended");
    }
}
