using UnityEngine;

public class Dragon : MonoBehaviour
{
    [Header("移動速度"), Range(1, 1000)]
    public float speed = 300;
    [Header("虛擬搖桿")]
    public Joystick joy;

    // 第一種寫法：需要欄位
    // public Transform tra;

    /// <summary>
    /// 移動
    /// </summary>
    public void Move()
    {
        print("移動中");

        // 第一種寫法
        // tra.Translate(0, 0, 1);
        // Time.deltaTime 一禎的時間
        // Input.GetAxis("Vertical");
        // Input.GetAxis("Horizontal");
        // 水平：Horizontal

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        // 第二種寫法：僅限於 Transform
        transform.Translate(speed * Time.deltaTime * h, 0, speed * Time.deltaTime * v);

        float joyV = joy.Vertical;
        float joyH = joy.Horizontal;

        transform.Translate(speed * Time.deltaTime * joyH, 0, speed * Time.deltaTime * joyV);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, 30, 70);
        transform.position = pos;
    }

    private void Update()
    {
        Move();
    }
}
