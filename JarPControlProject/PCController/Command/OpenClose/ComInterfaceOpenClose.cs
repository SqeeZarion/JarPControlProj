namespace JarPControlProject.PCController.Command;

public interface ComInterfaceOpenClose
{
    public CommandResult<String> Execute(String programName);
}