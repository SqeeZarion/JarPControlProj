using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class GetOpenPrograms
{
    private PCControl pcControl;
    private CommandResult<String> result;

    public GetOpenPrograms(PCControl pcControl)
    {
        this.pcControl = pcControl;
    }

    public void Execute()
    {
        Console.WriteLine("List of open programs:");
        foreach (String program in pcControl.OpenProgram)
            Console.WriteLine(program);
    }
}