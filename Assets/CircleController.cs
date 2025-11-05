using System;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class CircleController : MonoBehaviour
{
    Transform _transform;

    void Awake()
    {
        _transform = transform;
    }
    
    void Start()
    {
        Event1();
    }
    
    async void Event1()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));
        _transform.DOScale(new Vector3(5, 5, 5), 1.3f).SetEase(Ease.OutQuint).OnComplete(() => Event2());
    }

    async void Event2()
    {
        _transform.DOMoveX(-6f, 0.7f).SetEase(Ease.InQuint);
        _transform.DOScale(1f, 0.7f).SetEase(Ease.OutQuad);
    }
}
