using Silk.NET.Windowing;

namespace MMOFromScratch;

public class WindowManager
{
    IWindow _window;
    
    public WindowManager()
    { }
    
    //maybe get the size of the players screen?
    public void CreateGameWindow()
    {
        _window = Window.Create(WindowOptions.Default);
        _window.Load += EngineEventsHandler.OnLoad;
        _window.Render += EngineEventsHandler.OnRender;
        _window.Update += EngineEventsHandler.OnUpdate;
        _window.Title = "MMOFromScratch";
        _window.Run();
    }
    
    
    public IWindow Get() => _window;
}