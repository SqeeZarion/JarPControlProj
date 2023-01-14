using JarPControlProj.Enity;

namespace JarPControlProject.PCController.Command;

public class IncreaseVolume : CommandInterface
{
    private PCControl pcControl;
    private CommandResult<String> result;

    public IncreaseVolume(PCControl pcControl)
    {
        this.pcControl = pcControl;
    }

    public CommandResult<String> Execute(String amountSTR)
    {
        int amount = int.Parse(amountSTR);

        if (pcControl.Volume + amount <= 100)
        {
            pcControl.Volume += amount;

            result = new CommandResult<String>("Succeed!", "Volume increased to: " + pcControl.Volume, true);
        }
        else
            result = new CommandResult<String>("Failed!", "Cannot increase volume above 100.", false);

        return result;
    }
}