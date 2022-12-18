using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public static LoadingUI GetLoading()
    {
        return FindObjectOfType<LoadingUI>();
    }
    public void LoadScene(string sceneName)
    {
        StartCoroutine(ILoadScene(sceneName));
    }
    private IEnumerator ILoadScene(string sceneName)
    {
        canvasGroup.alpha = 1;
        var asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        while(!asyncOperation.isDone)
            yield return null;

        canvasGroup.alpha = 0;
    }
}
