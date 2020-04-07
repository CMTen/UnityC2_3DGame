using UnityEngine;

public class CarManager : MonoBehaviour
{
    public Car car1;

    private void Start()
    {
        car1.Drive(99, dir: "後方");
        car1.Drive(999.9f);
        car1.Drive(10, "碰碰碰");

        print("汽車是否開啟空調：" + car1.Cool());

        car1.Fly();
        car1.Fly(999);
    }
}
