using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    /// <summary> アイテムプレハブ入れてね </summary>
    [SerializeField] GameObject _itemPrefab;

    /// <summary> 生成間隔 </summary>
    [SerializeField] float _spawnInterval = 1f;

    float _elapsedTime = default;

    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_spawnInterval < _elapsedTime)
        {
            _elapsedTime = 0;
            Instantiate(_itemPrefab, new Vector3(Random.Range(-8.4f, 8.4f), Random.Range(-4.5f, 4.5f), 0),
                Quaternion.identity);
        }
    }
}