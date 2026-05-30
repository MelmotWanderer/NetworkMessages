using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class LoginUI : MonoBehaviour
{
    [SerializeField] private Button _serverButton;
    [SerializeField] private Button _hostButton;
    [SerializeField] private Button _clientButton;
    
    private ILoginService _loginService;
    
    [Inject]
    private void Construct(ILoginService loginService)
    {
        _loginService = loginService;
    }

    public void RegisterListeners()
    {
        _serverButton.onClick.AddListener(OnClickServerButton);
        _hostButton.onClick.AddListener(OnClickHostButton);
        _clientButton.onClick.AddListener(OnClickClientButton);
    }

    private void OnClickServerButton() => _loginService.StartServer();
    
    private void OnClickHostButton() => _loginService.StartHost();
    
    private void OnClickClientButton() => _loginService.StartClient();
}