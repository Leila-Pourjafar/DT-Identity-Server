using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.SharedKernel;

[ComplexType]
public record PostalCode : object
{
    public const int MaxLength = 10;
    public PostalCode(long? value) : base()
    {
        SetValue(value: value);
    }

    [Column(name: nameof(PostalCode))]
    [MaxLength(length: MaxLength)]
    [Required(AllowEmptyStrings = false)]
    public long Value { get; private set; }

    public void SetValue(long? value)
    {
        if (value is null)
        {
            var errorMessage = string.Format(
                Resources.ValidationErrorMessages.Required,
                Resources.DataDictionary.PostalCode
                );

            throw new Exception(message: errorMessage);
        }

        if (Value != value)
        {
            Value = value.Value;
        }
    }
}
