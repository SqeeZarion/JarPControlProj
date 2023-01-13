using System.Diagnostics;
using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class OpenProgram : CommandInterface
{
    private PCControl pcControl;

    public OpenProgram(PCControl pcControl)
    {
        this.pcControl = pcControl;
    }

    public CommandResult<String> Execute(String programName)
    {
        // Check if the program is already open
        if (!pcControl.OpenProgram.Contains(programName))
        {
            try
            {
                // Open the program
                Process.Start(programName);
                pcControl.OpenProgram.Add(programName);
                Console.WriteLine("Program " + programName + " opened successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to open program. Error: " + e.Message);
            }
        }
        else
            Console.WriteLine("Program " + programName + " is already open.");

        CommandResult<String> result = new CommandResult<String>("Succeed!!!!!", "Deleting works!", true);
        return result;
    }
}