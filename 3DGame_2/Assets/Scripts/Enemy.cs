using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 怪物血量
    /// </summary>
    [Header("血量")]
    public float hp = 50;

    // 認識屬性 Property
    // 可以設定權限：唯讀、允許所有權限
    // get 取得
    // set 設定
    // 不會顯示在屬性面板上

    // 允許所有權限
    /// <summary>
    /// 攻擊力
    /// </summary>
    public int attack { get; set; }

    // public float def { get; }

    public float def
    {
        get
        {
            return 77.5f;
        }
    }

    public int lv = 5;

    // 錯誤：無法在欄位指定後方使用欄位
    // public int mp = lv * 8;
    public int mp
    {
        get
        {
            return lv * 8;
        }
    }

    private float _damage;

    public float damage
    {
        set
        {
            _damage = Mathf.Clamp(value - def, 1, 999999);
        }
        get
        {
            return _damage;
        }
    }
}
