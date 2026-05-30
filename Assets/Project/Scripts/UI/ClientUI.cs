using Mirror;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class ClientUI : NetworkBehaviour
{
    [SerializeField] private Button _registerButton;

    private IClientService _clientService;
    
    [Inject]
    private void Construct(IClientService clientService) => _clientService = clientService;
    
    public void RegisterListeners() => _registerButton.onClick.AddListener(OnClickRegisterButton);

    private void OnClickRegisterButton()
    {
        if (isClient == false)
        {
            Debug.Log("<color=red>This is not a client!</color>");
            return;
        }
        CommandRegister();   
    }

    [Command(requiresAuthority = false)]
    private void CommandRegister(NetworkConnectionToClient sender = null)
    {
        _clientService.RegisterClient(sender);
        NotifyServer();
    }

    [Server]
    private void NotifyServer() => _clientService.NotifyServer();
}

