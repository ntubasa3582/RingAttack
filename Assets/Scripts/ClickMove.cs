using UnityEngine;
//クリックした場所にプレイヤーを移動させる関数
public class ClickMove : MonoBehaviour
{
    /// <summary> プレイヤーのスピード </summary>
    [SerializeField] float _playerMoveSpeed;
    GameObject _playerGameObject;
    Transform _playerTransform;

    Vector3 _mousePoint;
    // 範囲を定数として定義しておくと、より管理しやすい
    float minX = -8.4f;
    float maxX = 8.4f;
    float minY = -4.5f;
    float maxY = 4.5f;
    

    void Awake()
    {
        _playerGameObject = GameObject.Find("Player");
        _playerTransform = _playerGameObject.GetComponent<Transform>();
    }
    


    void Update()
    {
        _mousePoint.x = Mathf.Clamp(_mousePoint.x, minX, maxX);
        _mousePoint.y = Mathf.Clamp(_mousePoint.y, minY, maxY);
        if (Input.GetMouseButtonDown(0))
        {
            _mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _mousePoint.z = 0;
        }

        if (_mousePoint != _playerTransform.position)
        {
            _playerTransform.position =
                Vector3.MoveTowards(_playerTransform.position, _mousePoint, _playerMoveSpeed * Time.deltaTime);
        }
    }
}