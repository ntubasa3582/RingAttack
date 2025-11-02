using UnityEngine;

public class ClickInstance : MonoBehaviour
{
    [SerializeField] GameObject _ringPrefab;

    // 範囲を定数として定義しておくと、より管理しやすい
    private const float MinX = -10f;
    private const float MaxX = 10f;
    private const float MinY = -5f;
    private const float MaxY = 5f;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
            // 範囲外の座標に制限をかける
            float clampedX = Mathf.Clamp(mousePoint.x, MinX, MaxX);
            float clampedY = Mathf.Clamp(mousePoint.y, MinY, MaxY);

            // 制限後の座標が元の座標と一致すれば、範囲内である
            if (mousePoint.x == clampedX && mousePoint.y == clampedY)
            {
                Instantiate(_ringPrefab, mousePoint, _ringPrefab.transform.rotation);
            }
        }
    }
}