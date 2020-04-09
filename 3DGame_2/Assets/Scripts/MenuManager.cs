using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    [Header("載入畫面")]
    /// <summary>
    /// 載入畫面
    /// </summary>
    public GameObject panelLoading;

    [Header("載入畫面文字")]
    /// <summary>
    /// 載入畫面文字
    /// </summary>
    public Text textLoading;

    [Header("載入畫面Bar條")]
    /// <summary>
    /// 載入畫面Bar條
    /// </summary>
    public Image imgLoading;

    /// <summary>
    /// 開始載入遊戲場景
    /// </summary>
    public void StartLoading()
    {
        panelLoading.SetActive(true);

        StartCoroutine(Loading());
    }

    /// <summary>
    /// 協成方法：載入
    /// </summary>
    /// <returns></returns>
    private IEnumerator Loading()
    {
        // SceneManager.LoadScene("關卡1");
        AsyncOperation ao = SceneManager.LoadSceneAsync("關卡1");

        ao.allowSceneActivation = false;

        while (ao.progress < 1)
        {
            textLoading.text = (ao.progress / 0.9f * 100).ToString("F1") + " %";

            imgLoading.fillAmount = ao.progress / 0.9f;

            yield return null;

            if (ao.progress == 0.9f)
            {
                ao.allowSceneActivation = true;
            }
        }
    }
}
