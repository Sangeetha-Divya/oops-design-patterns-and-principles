interface player
{
    public void play(string type, string name);
}
interface advance_player
{
    public void playVlc(String name);
    public void playMp4(String name);
}
class vlcplayer : advance_player
{
    public void playMp4(string name)
    {
    }

    public void playVlc(string name)
    {
        System.Console.WriteLine("name: " + name);
    }
}
class mp4player : advance_player
{
    public void playMp4(string name)
    {
        System.Console.WriteLine("name: " + name);
    }

    public void playVlc(string name)
    {
    }
}
class adapter : player
{
    advance_player Advance_Player;
    private string type;

    public adapter(string type)
    {
        if (type == "vlc")
        {
            Advance_Player = new vlcplayer();
        }
        else if (type == "mp4")
        {
            Advance_Player = new mp4player();
        }
    }

    public void play(string type, string name)
    {
        if (type == "vlc")
        {
            Advance_Player.playVlc(name);
        }
        else if (type == "mp4")
        {
            Advance_Player.playMp4(name);
        }
    }
}
class AudioPlayer : player
{
    adapter Adapter;
    public void play(String type, String name)
    {
    if (type=="mp3")
    {
        System.Console.WriteLine("Playing mp3 file. Name: " + name);
    }
    else if (type=="mp4" || type=="vlc")
    {
        Adapter = new adapter(type);
        Adapter.play(type, name);
    }
    else
    {
        System.Console.WriteLine("Invalid media. " + type + " format not supported");
    }
    }   
}
public class program
{
    public static void Main(String[] args)
    {
        AudioPlayer audioPlayer = new AudioPlayer();

        audioPlayer.play("mp3", "beyond the horizon.mp3");
        audioPlayer.play("mp4", "alone.mp4");
        audioPlayer.play("vlc", "far far away.vlc");
        audioPlayer.play("avi", "mind me.avi");
    }
}
