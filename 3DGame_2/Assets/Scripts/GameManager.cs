using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 陣列：儲存多筆相同類型的資料
    [Header("地板陣列")]
    public Transform[] terrains;
    [Header("地板移動速度"), Range(1f, 50f)]
    public float speedTerrain = 1.5f;
    [Header("畫面物件")]
    public GameObject pass;
    public GameObject lose;

    public bool passLv;

    public void Lose()
    {
        lose.SetActive(true);
    }

    public void Win()
    {
        passLv = true;
        pass.SetActive(true);
    }

    public void NextLv()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// 移動地板
    /// </summary>
    private void MoveTerrain()
    {
        // 移動
        //terrains[0].Translate(0, 0, -speedTerrain * Time.deltaTime);
        //terrains[1].Translate(0, 0, -speedTerrain * Time.deltaTime);

        // 如果 地板.z 小於 100
        //if(terrains[0].position.z <= -100)
        //{
        //    // 另一塊地板的前方 100 位置
        //    terrains[0].position = new Vector3(0, 0, terrains[1].position.z + 100);
        //}

        //if(terrains[1].position.z <= -100)
        //{
        //    terrains[1].position = new Vector3(0, 0, terrains[0].position.z + 100);
        //}
        
        for (int i = 0; i < terrains.Length; i++)
        {
            // 如果 地板.z 小於 100
            if (terrains[i].position.z <= -100)
            {
                // 另一塊地板的前方 100 位置
                terrains[i].position = new Vector3(0, 0, terrains[1 - i].position.z + 100);
            }
            // 移動
            terrains[i].Translate(0, 0, -speedTerrain * Time.deltaTime);
        }
    }

    /// <summary>
    /// 固定禎數
    /// </summary>
    private void FixedUpdate()
    {
        MoveTerrain();
    }
}
