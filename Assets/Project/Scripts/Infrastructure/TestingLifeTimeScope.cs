using Mirror;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class TestingLifeTimeScope : LifetimeScope
{
    [SerializeField] private NetworkManager _networkManager;
    [SerializeField] private UIOrchestrator _uiOrchestrator;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<EntryPoint>();
        builder.Register<ILoginService, DefaultLoginService>(Lifetime.Singleton);
        builder.Register<IClientService, DefaultClientService>(Lifetime.Singleton);
        builder.RegisterInstance<NetworkManager>(_networkManager);
        builder.RegisterInstance<UIOrchestrator>(_uiOrchestrator);
    }
}
