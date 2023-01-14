using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class DecreaseVolume : ComInterfaceOpenClose
{
    private PCControl pcControl;
    private CommandResult<String> result;

    public DecreaseVolume(PCControl pcControl)
    {
        this.pcControl = pcControl;
    }

    public CommandResult<String> Execute(String amountSTR)
    {
        int amount = int.Parse(amountSTR);

        if (pcControl.Volume - amount >= 0)
        {
            pcControl.Volume -= amount;

            result = new CommandResult<String>("Succeed!", "Volume decreased to: " + pcControl.Volume, true);
        }
        else
            result = new CommandResult<String>("Failed!!", "Cannot decrease volume below 0. ", false);

        return result;
    }
}