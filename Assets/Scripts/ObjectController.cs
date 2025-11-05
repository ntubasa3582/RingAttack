using UnityEngine;
//時間経過でオブジェクトを生成するメソッド
public class ObjectController : MonoBehaviour
{
    [SerializeField] GameObject _circle;
    
    /// <summary> 経過時間を補完する変数 </summary>
    float _elapsedTime = default;

    void Update()
    {
        _elapsedTime += Time.deltaTime;
    }

    void Event()
    {
        
    }
    
    
}
