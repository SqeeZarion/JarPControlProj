namespace JarPControlProject.PCController.Command;

public class CommandResult<T>

{
    private T result;
    private String message;
    private Boolean isSucceed;

    public CommandResult(T Result, String Message, Boolean IsSucceed)
    {
        result = Result;
        message = Message;
        isSucceed = IsSucceed;
    }

    public T Result
    {
        get { return result; }
        set { result = value; }
    }

    public String Message
    {
        get { return message; }
        set { message = value; }
    }

    public Boolean IsSucceed
    {
        get { return isSucceed; }
        set { isSucceed = value; }
    }

    public String ResultToString()
    {
        return "CommandResult{" +
               "Result=" + Result +
               ", Message='" + Message + '\'' +
               ", IsSucceed=" + IsSucceed +
               '}';
    }
}