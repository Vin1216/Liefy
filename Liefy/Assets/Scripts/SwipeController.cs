using UnityEngine;
using DG.Tweening;

public class SwipeController : MonoBehaviour
{
    [SerializeField] int totalpages;
    int currentpage;
    Vector3 TargetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform PagesRect;
    [SerializeField] float tweenDuration;

    private void Awake()
    {
        currentpage = 1;
        TargetPos = PagesRect.localPosition;
    }

    public void Next()
    {
        if (currentpage < totalpages)
        {
            currentpage++;
            TargetPos -= pageStep; // add the distance between pages to TargetPos to result in the next page
            MovePage();
        }
    }

    public void Previous()
    {
        if(currentpage > 1)
        {
            currentpage--;
            TargetPos += pageStep;
            MovePage();
        }
    }

    void MovePage()
    {
        PagesRect.DOAnchorPosX(TargetPos.x, tweenDuration);
    }
}
