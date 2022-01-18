using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer videoPlayer;
    private Image progressBar;

    private void Awake()
    {
        progressBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(videoPlayer.frameCount > 0)
        {
            progressBar.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
    }

    //void TrySkip(PointerEventData eventData)
    //{
    //    Vector2 localPoint;
    //    if(RectTransformUtility.ScreenPointToLocalPointInRectangle(
    //        progressBar.rectTransform, eventData.position, null, out localPoint))
    //    {
    //        float pct = Mathf.InverseLerp(progressBar.rectTransform.rect.xMin, progressBar.rectTransform.rect.xMax, localPoint.x);
    //        SkipToPercent(pct);
    //    }
    //}

    //void SkipToPercent(float pct)
    //{
    //    var frame = videoPlayer.frameCount * pct;
    //    videoPlayer.frame = (long)frame;
    //}

    //void IDragHandler.OnDrag(PointerEventData eventData)
    //{
    //    TrySkip(eventData);
    //}

    //void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    //{
    //    TrySkip(eventData);
    //}
}
