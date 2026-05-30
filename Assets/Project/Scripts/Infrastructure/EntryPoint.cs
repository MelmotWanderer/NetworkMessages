using VContainer.Unity;

public class EntryPoint : IStartable
{
    private readonly UIOrchestrator _uiOrchestrator;
    
    public EntryPoint(UIOrchestrator uiOrchestrator)
    {
        _uiOrchestrator = uiOrchestrator;
    }
    
    public void Start() => _uiOrchestrator.Initialize();    
}
