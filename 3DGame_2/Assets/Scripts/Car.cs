using UnityEngine;

public class Car : MonoBehaviour
{
    public void Drive(float speed, string sound = "咻咻咻", string dir = "前方")
    {
        print("開車時速：" + speed);
        print("(開車音效)" + sound);
        print("開車方向：" + dir);
    }

    public bool Cool()
    {
        print("開啟空調");
        return true;
    }

    public void Fly()
    {
        print("車子飛行");
    }
    public void Fly(int height)
    {
        print("車子飛行高度：" + height);
    }
}
