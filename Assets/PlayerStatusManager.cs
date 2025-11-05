using UnityEngine;

//プレイヤーのスコアとスピードを管理するクラス
public class PlayerStatusManager : MonoBehaviour
{
    public int PlayerScore { get; set; } = 0;
    public float PlayerMoveSpeed { get; set; } = 0;
    public static PlayerStatusManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // 初回生成時にインスタンスを設定
        }
        else
        {
            Destroy(gameObject); // 2つ目以降のインスタンスを破棄
        }
    }
}