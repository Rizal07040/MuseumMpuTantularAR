using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading_scene : MonoBehaviour
{
    public Image loadingfill;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Scans");

        while (!loading.isDone)
        {
            loadingfill.fillAmount = loading.progress/0.9f;
            yield return null;
        }
    }
}
