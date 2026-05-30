using System.Collections.Generic;
using Mirror;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class DefaultClientService : IClientService
{
    private readonly IObjectResolver _resolver;
    private List<NetworkConnectionToClient> _connections;

    public DefaultClientService(IObjectResolver objectResolver)
    {
        _resolver = objectResolver;
        _connections = new List<NetworkConnectionToClient>();
    }
    
    public void RegisterClient(NetworkConnectionToClient sender)
    {
        var info = _resolver.Instantiate(Resources.Load<ClientRegisterInformation>("Prefabs/ClientRegistrationInformation"));
        NetworkServer.Spawn(info.gameObject);
        _connections.Add(sender);
    }

    public void NotifyServer()
    {
        HelloMessage helloMessage = new HelloMessage
        {
            message = "Hello Client!"
        };
        foreach (var connection in _connections)
        {
            connection.Send(helloMessage);
        }
    }
}