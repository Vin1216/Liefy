using UnityEngine;
using DG.Tweening;

public class MuscleScreenSetup : MonoBehaviour
{
    [SerializeField] float CornerOffset = 50f;
    [SerializeField] RectTransform rt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rt.anchoredPosition = new Vector3(0 + rt.rect.width + CornerOffset, 0 - rt.rect.height - CornerOffset * 2.5f, 2);
        Debug.Log(new Vector3(0 + rt.rect.width + CornerOffset, 0 - rt.rect.height - CornerOffset * 2.5f, 2));
    }
}
