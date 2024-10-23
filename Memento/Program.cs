namespace Memento;

public class Player
{
    private string characterName = "Player";
    private int health = 100;
    private int kills = 0;
    private int deaths = 0;

    public PlayerMemento SaveState()
    {
        return new PlayerMemento(characterName, health, kills, deaths);
    }

    public void RestoreState(PlayerMemento memento)
    {
        characterName = memento.CharacterName;
        health = memento.Health;
        kills = memento.Kills;
        deaths = memento.Deaths;
    }
}

public class PlayerMemento
{
    public string CharacterName { get; set; }
    public int Health { get; set; }
    public int Kills { get; set; }
    public int Deaths { get; set; }

    public PlayerMemento(string characterName, int health, int kills, int deaths)
    {
        this.CharacterName = characterName;
        this.Health = health;
        this.Kills = kills;
        this.Deaths = deaths;
    }
}

public class SaveProgress
{
    public Stack<PlayerMemento> saveStack { get; private set; } = new();
}

class Program
{
    static void Main(string[] args)
    {
        var player = new Player();
        var saves = new SaveProgress();
        
        saves.saveStack.Push(player.SaveState());
        
        // - some operations with player, for example hp loss -
     
        player.RestoreState(saves.saveStack.Pop());
        
        // - player finally did something - 
        
        saves.saveStack.Push(player.SaveState());
    }
}