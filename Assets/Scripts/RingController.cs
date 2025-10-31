using UnityEngine;

public class RingController : MonoBehaviour
{
    [SerializeField, Header("_elapsedTime到達時間")]
    float _targetTime = 6f;

    [SerializeField, Header("Ringの初期値")] float _startScale = 0f;

    [SerializeField, Header("Ringの大きさ")] float _ringScale = 10f;

    Transform _ringTransform = default;

    /// <summary> 経過時間 </summary>
    float _elapsedTime = 0f;

    /// <summary> 成長パラメータ </summary>
    float _growthParameter = 0f;


    void Awake()
    {
        _ringTransform = this.transform;
    }


    void Update()
    {
        //経過時間/目標時間の計算をすることで進行度を求める
        float timeProgress = _elapsedTime / _targetTime;

        _elapsedTime += Time.deltaTime;
        if (timeProgress >= 1)
        {
            enabled = false;
        }

        //_startScale（初期値）から_ringScale（最大値）数値範囲の中から経過時間と同じ割合の数値を算出し_growthParameterに渡している
        _growthParameter = Mathf.Lerp(_startScale, _ringScale, timeProgress);
        //上で計算した数値をTransform.localScaleのx,yに代入する
        _ringTransform.localScale = new Vector2(_growthParameter, _growthParameter);
    }
}