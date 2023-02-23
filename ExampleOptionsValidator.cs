using FluentValidation;

namespace OptionsValidation;

public class ExampleOptionsValidator : AbstractValidator<ExampleOptions>
{
    public ExampleOptionsValidator()
    {
        RuleFor(options => options.LogLevel)
            .IsEnumName(typeof(LogLevel));

        RuleFor(options => options.Retries)
            .InclusiveBetween(1, 9);
    }
}
