using System.Diagnostics;
using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class OpenProgram : CommandInterface
{
    private PCControl pcControl;
    private CommandResult<String> result;

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

                result = new CommandResult<String>("Succeed!", "Program" + programName + "opened successfully.!", true);
            }
            catch (Exception e)
            {
                result = new CommandResult<String>("Failed!", "Failed to open program. Error: " + e.Message, false);
            }
        }
        else
            result = new CommandResult<String>("Failed!", "Program " + programName + " is already open.", false);

        return result;
    }
}