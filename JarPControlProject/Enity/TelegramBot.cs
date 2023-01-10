namespace JarPControlProject.Enity;

public class TelegramBot
{
    // A field containing the bot's token to access the Telegram API
    private String token;

    // Field containing the ID of the chat from which the commands will be received
    private long chatId;

    public TelegramBot(String token, long chatId) {
        this.token = token;
        this.chatId = chatId;
    }
}
