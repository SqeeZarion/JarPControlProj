namespace JarPControlProject.PCController.Command;

public interface CommandInterface
{
    public CommandResult<String> Execute(String programName);
}