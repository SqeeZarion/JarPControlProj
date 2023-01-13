using JarPControlProject.PCController.Command;

namespace JarPControlProj.Enity;
using System.Collections;

public class PCControl
{
    // A field containing the name of the computer
    private String computerName;

    // A field containing a list of open desktop programs
    private List<String> openPrograms;

    // A field indicating whether music is playing
    private Boolean isMusicPlaying;

    // A field containing the current sound volume
    private int volume;

    public List<String> OpenProgram
    {
        get { return openPrograms;}
        set { openPrograms = value; }
    }

    public int Volume
    {
        get { return volume; }
        set { volume = value; }
    }

    private Boolean IsMusicPlaying
    {
        get { return isMusicPlaying; }
        set { isMusicPlaying = value; }
    }

    public PCControl(String computerName) {
        this.computerName = computerName;
        this.openPrograms = new List<string>();
        this.isMusicPlaying = false;
        this.volume = 50;
    }
}