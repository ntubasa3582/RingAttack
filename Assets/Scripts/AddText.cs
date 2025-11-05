using UnityEngine;
using UnityEngine.UI;

public class AddText : MonoBehaviour
{
    [SerializeField] GameObject _text;

    void Start()
    {
        GameObject text = Instantiate(_text);
        text.transform.SetParent(transform);
        RectTransform rt = text.GetComponent<RectTransform>();
        rt.anchoredPosition = new Vector2(0, 0);
    }
}
