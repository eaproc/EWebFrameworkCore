namespace EWebFrameworkCore.Dev
{
    public interface ISpeaker
    {
        string WordGenerated { get; }

        void Speak();
    }
}