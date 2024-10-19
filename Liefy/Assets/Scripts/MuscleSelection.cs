using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class MuscleSelection : MonoBehaviour
{
    [SerializeField] RectTransform rt;

    Vector3 targetScale = new Vector3(2, 2, 0);

    [SerializeField] Vector3 startpos;
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
        Debug.Log(startpos);
    }

    public void MoveToCorner()
    {
        TargetPos = new Vector2(0 + rt.rect.width + CornerOffset, 0 - rt.rect.height - CornerOffset * 2.5f);
        rt.DOScale(TargetScale, ScaleTweenDuration);
        StartCoroutine(DelayedMovement(MovementDelay));
    }

    public void MoveToStartPos()
    {
        TargetPos = startpos;
        rt.DOScale(startscale, ScaleTweenDuration);
        StartCoroutine(DelayedMovement(MovementDelay));
    }

    private IEnumerator DelayedMovement(float delay)
    {
        yield return new WaitForSeconds(delay);
        rt.DOAnchorPos(TargetPos, MovementTweenDuration);
    }
}
