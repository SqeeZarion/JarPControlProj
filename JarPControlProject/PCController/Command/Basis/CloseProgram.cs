using System.Diagnostics;
using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class CloseProgram : CommandInterface
{
    private PCControl pcControl;
    private CommandResult<String> result;

    public CloseProgram(PCControl pcControl)
    {
        this.pcControl = pcControl;
    }

    public CommandResult<String> Execute(String programName)
    {
        if (pcControl.OpenProgram.Contains(programName))
        {
            try
            {
                // Close the program
                // You can use Process.Kill() or Process.CloseMainWindow() methods

                Process[] processes = Process.GetProcessesByName(programName);
                foreach (Process p in processes)
                {
                    p.CloseMainWindow();
                }

                pcControl.OpenProgram.Remove(programName);

                result = new CommandResult<String>("Succeed!", "Program " + programName + " closed successfully.", true);
            }
            catch (Exception e)
            {
                result = new CommandResult<String>("Failed!", "Failed to close program. Error: " + e.Message, false);
            }
        }
        else
            result = new CommandResult<String>("Failed!", "Program " + programName + " is not open.", false);

        return result;
    }
}