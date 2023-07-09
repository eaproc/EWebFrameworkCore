namespace EWebFrameworkCore.Vendor.Services.Mailing
{
    public interface ISMTP: IDisposable
    {
        string Name { get; }

        string Sender { get; }

        string Host { get; }

        int Port { get; }

        string Username { get; }

        string Password { get; }

        bool SendEmail(IMailable mailable, bool fake = false);

        //bool SendViaHTTP(IMailable mailable, string SenderEmailAddress);

        //bool SendViaCustom(IMailable mailable, string SenderEmailAddress);
    }
}
