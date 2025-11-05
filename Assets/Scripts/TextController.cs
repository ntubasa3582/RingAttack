using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class TextController : MonoBehaviour
{
    [SerializeField] float _durationValue = default;
    RectTransform _rectTransform = default;
    Text _text = default;

    void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _text = GetComponent<Text>();
    }

    void Start()
    {
        FadeOut();
    }

    void FadeOut()
    {
        _text.DOFade(0f, 1.3f).SetEase(Ease.OutQuad).OnComplete(FadeIn);
        _rectTransform.DOLocalRotate(new Vector3(0f, 0f, 45f), 2f).SetEase(Ease.OutQuint);
    }

    void FadeIn()
    {
        _text.DOFade(1f, 2f).SetEase(Ease.OutQuad).OnComplete(FadeOut);
        _rectTransform.DOLocalRotate(new Vector3(0f, 0f, 0f), 2f).SetEase(Ease.OutQuint);
    }
}
