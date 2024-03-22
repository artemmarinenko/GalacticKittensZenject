using System.Collections;
using UnityEngine;
using Zenject;

/*
    Script to go to the Menu scene after the loading manager is load.
*/
public class GoToMenu : MonoBehaviour
{
    private LoadingSceneManager m_loadingSceneManager;
    [Inject]
    private void Construct(LoadingSceneManager loadingSceneManager)
    {
        m_loadingSceneManager = loadingSceneManager;
    }
    IEnumerator Start()
    {
        // Wait for the loading scene manager to start
        yield return new WaitUntil(() => m_loadingSceneManager != null);

        // Load the menu
        m_loadingSceneManager.LoadScene(SceneName.Menu, false);
    }
}