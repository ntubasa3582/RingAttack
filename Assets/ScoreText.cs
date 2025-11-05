using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    Text _text;

    void Awake()
    {
        _text = GetComponent<Text>();
    }
    
}
