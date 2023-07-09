using EWebFrameworkCore.Vendor.Requests;

namespace EWebFrameworkCore.Vendor.Services.Mailing
{
    public class Mail : IMailable
    {
        //
        // Summary:
        //     Creates class and generates default HTML body, throws exception if file is not
        //     found
        public Mail(string subject): this(subject: subject, message: string.Empty)
        {}

        /// <summary>
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public Mail(string subject, string message) : this(subject: subject, message: message, replacableKeyWordsInMessage: new Dictionary<string, string>())
        {}

        /// <summary>
        /// Please, note that Keys are case sensitive.
        /// You can use keys like {{KEY}} with no space in your HTML file
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="replacableKeyWordsInMessage"></param>
        public Mail(string subject, string message, IDictionary<string, string> replacableKeyWordsInMessage)
        {
            Subject = subject;
            Message = message;
            SetResource();
            SetFinalHTML(replacableKeyWordsInMessage);
        }

        /// <summary>
        /// Default is semi colon
        /// </summary>
        public char EmailDelimiter { protected get; set; } = ';';

        //
        // Summary:
        //     Same as ToString(), it returns the generated HTML
        public string Message { get; private set; } = string.Empty;

        //
        // Summary:
        //     Subject of the message
        public string Subject { get; set; }

        public string[]? BCC { get; set; } = null;

        public Mail SetBcc(string bcc)
        {
            SetBcc(bcc.Split(EmailDelimiter));
            return this;
        }

        public Mail SetBcc(string[] bcc)
        {
            BCC = bcc;
            return this;
        }

        public string? GetBccAsString()
        {
            return BCC != null ? string.Join(EmailDelimiter, BCC) : null;
        }

        public string[]? CC { get; set; } = null;

        public string? GetCcAsString()
        {
            return CC != null ? string.Join(EmailDelimiter, CC) : null;
        }

        public Mail SetCc(string cc)
        {
            SetCc(cc.Split(EmailDelimiter));
            return this;
        }

        public Mail SetCc(string[] cc)
        {
            CC = cc;
            return this;
        }

        public string[] Receiver { get; set; } = Array.Empty<string>();

        public string GetReceiverAsString()
        {
            return Receiver.Any() ? string.Join(EmailDelimiter, Receiver) : string.Empty;
        }

        public Mail SetReceiver(string receiver)
        {
            SetReceiver(receiver.Split(EmailDelimiter));
            return this;
        }

        public Mail SetReceiver(string[] receiver)
        {
            if(receiver.Where(x => !RequestValidator.IsValidEmail(x)).Any()) throw new InvalidOperationException("Please, pass valid receivers");
            Receiver = receiver;
            return this;
        }

        /// <summary>
        /// AppDomain.CurrentDomain.BaseDirectory + "/App_Resources/mails/" + 
        ///  ResourceHTMLFile = Relative Path in above directory
        /// </summary>
        public virtual string? ResourceHTMLFile => null;

        private string? _resource;
        private bool disposedValue;

        public string? Resource { get => _resource; }

        /// <summary>
        /// This just loads the html file in memory
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private IMailable SetResource()
        {
            if (ResourceHTMLFile != null)
            {
                string text = ("mails/" + ResourceHTMLFile).ResourcesPath();
                if (!File.Exists(text))
                {
                    throw new FileNotFoundException("Unable to locate resource file for mail in " + text);
                }

                _resource = File.ReadAllText(text);
            }
            return this;
        }

        public string[]? LocalFileFullPathNames { get; set; }

        public Mail SetLocalFileFullPathNames(string[]? localFileFullPathNames)
        {
            if (localFileFullPathNames != null && localFileFullPathNames.Any() && localFileFullPathNames.Where(x => !File.Exists(x)).Any())
                throw new InvalidOperationException("Some of the files are not found. Files: " + string.Join(EmailDelimiter, localFileFullPathNames));
                
            LocalFileFullPathNames = localFileFullPathNames;
            return this;
        }

        public List<KeyValuePair<string, TemporaryFile>> DisposableFiles { get; set; } = new List<KeyValuePair<string, TemporaryFile>>();

        public Mail AddDisposableFile(string FileName, TemporaryFile temporaryFile)
        {
            this.DisposableFiles.Add(new KeyValuePair<string, TemporaryFile>(FileName, temporaryFile));
            return this;
        }

        public Mail AddDisposableFile(string FileName, string FileContent)
        {
            var v = new TemporaryFile(FileName.AppTempStore()).CreatePath();
            File.WriteAllText(v.FileFullPath, contents: FileContent);
            AddDisposableFile(FileName, v);
            return this;
        }

        public Mail AddDisposableFile(string FileName, byte[] FileContent)
        {
            var v = new TemporaryFile(FileName.AppTempStore()).CreatePath();
            File.WriteAllBytes(v.FileFullPath, bytes: FileContent);
            AddDisposableFile(FileName, v);
            return this;
        }

        public Mail SetDisposableFiles(string[]? localFileFullPathNames)
        {
            if (localFileFullPathNames != null && localFileFullPathNames.Any() && localFileFullPathNames.Where(x => !File.Exists(x)).Any())
                throw new InvalidOperationException("Some of the files are not found. Files: " + string.Join(EmailDelimiter, localFileFullPathNames));

            LocalFileFullPathNames = localFileFullPathNames;
            return this;
        }

        //
        // Summary:
        //     Generates the HTML Body
        //
        // Parameters:
        //   p:
        protected Mail SetFinalHTML()
        {
            return SetFinalHTML(new Dictionary<string, string>());
        }

        /// <summary>
        /// Please, note that Keys are case sensitive.
        /// You can use keys like {{KEY}} with no space in your HTML file
        /// </summary>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        protected Mail SetFinalHTML(IDictionary<string, string> valuePairs)
        {
            if(Resource != null ) Message = Resource;

            if (valuePairs.Any())
            {
                foreach (KeyValuePair<string, string> fieldInfo in valuePairs)
                {
                    Message = Message.Replace(GetVariableRepresentation(fieldInfo.Key), fieldInfo.Value);
                }
            }

            return this;
        }

        //
        // Summary:
        //     Sets HTML Variable with double curly brackets {{ }}
        //
        // Parameters:
        //   v:
        public static string GetVariableRepresentation(string variableKeyName )
        {
            return "{{" + variableKeyName + "}}";
        }

        //
        // Summary:
        //     Returns the Message body
        public override string ToString()
        {
            return Message;
        }

        public string? Sender { get; set; }

        public IMailable SetSender(string senderEmailAddress)
        {
            if (!RequestValidator.IsValidEmail(senderEmailAddress)) throw new InvalidProgramException("Please, pass a valid email address for the sender!");
            Sender = senderEmailAddress;
            return this;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    foreach(var t in DisposableFiles) { t.Value.Dispose(); }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Mail()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
