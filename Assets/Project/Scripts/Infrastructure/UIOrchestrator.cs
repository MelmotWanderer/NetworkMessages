using UnityEngine;
using VContainer;

public class UIOrchestrator : MonoBehaviour
{
    [SerializeField] private ClientUI _clientUI;
    [SerializeField] private LoginUI _loginUI;
    
    public void Initialize()
    {
        _clientUI.RegisterListeners();
        _loginUI.RegisterListeners();
    }
}
