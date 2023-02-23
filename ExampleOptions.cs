namespace OptionsValidation;

public class ExampleOptions
{
    public const string SectionName = "Example";

    public string LogLevel { get; init; }
    public int Retries { get; init; }
}
