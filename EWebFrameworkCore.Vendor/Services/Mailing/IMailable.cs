namespace EWebFrameworkCore.Vendor.Services.Mailing
{
    public interface IMailable: IDisposable
    {
        string? ResourceHTMLFile { get; }

        //
        // Summary:
        //     Receivers email address separated with comma for multiple receivers
        string[] Receiver { get; set; }

        //
        // Summary:
        //     Carbon Copy email address separated with comma for multiple receivers. Will be
        //     visible to all receivers
        string[]? CC { get; set; }

        //
        // Summary:
        //     Blind Carbon Copy email address separated with comma for multiple receivers.
        //     Will not be visible to any receiver
        string[]? BCC { get; set; }

        string Message { get; }

        string? Sender { get; set; }

        string Subject { get; }

        IMailable SetSender(string senderEmailAddress );
 
        string[]? LocalFileFullPathNames { get; set; }

        List<KeyValuePair<string, TemporaryFile>> DisposableFiles { get; set; }
    }
}
