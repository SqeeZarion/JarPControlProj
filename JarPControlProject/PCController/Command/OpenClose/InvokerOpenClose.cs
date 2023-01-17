namespace JarPControlProject.PCController.Command;

public class InvokerOpenClose
{
    private ComInterfaceOpenClose command;

    public InvokerOpenClose(ComInterfaceOpenClose command)
    {
        this.command = command;
    }

    public void doSmth()
    {
        try
        {
            command.Execute(@"D:\Program Files (x86)\Telegram Desktop\Telegram.exe");
        }
       
        catch (IOException e)
        {
            if (e.Source != null)
                Console.WriteLine("IOException source: {0}", e.Source);
            throw;
        }
    }
}