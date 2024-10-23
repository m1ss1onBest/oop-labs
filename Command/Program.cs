namespace Command;

class Program
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("On");
        }

        public void Off()
        {
            Console.WriteLine("Off");
        }
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }

    public class RemoteControl
    {
        private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                _commandHistory.Pop().Undo();
            }
        }
    }
    
    static void Main(string[] args)
    {
        var light = new Light();

        var lightOn = new LightOnCommand(light);
        var lightOff = new LightOffCommand(light);

        var remoteControl = new RemoteControl();
        
        remoteControl.ExecuteCommand(lightOn);
        remoteControl.ExecuteCommand(lightOff);
        remoteControl.UndoLastCommand();
    }
}