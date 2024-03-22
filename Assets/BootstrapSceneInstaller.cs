using UnityEngine;
using Zenject;

public class BootstrapSceneInstaller : MonoInstaller
{
    [SerializeField] private LoadingSceneManager loadingSceneManager;
    public override void InstallBindings()
    {
        Container.Bind<LoadingSceneManager>().FromInstance(loadingSceneManager).AsSingle();
    }
}
