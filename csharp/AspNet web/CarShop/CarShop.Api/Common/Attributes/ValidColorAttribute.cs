using System.ComponentModel.DataAnnotations;

namespace CarShop.Api.Common.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ValidColorAttribute : ValidationAttribute
{
    private readonly List<string> existColors = new List<string>()
    {
        "black",
        "white",
        "gray"
    };

    public override bool IsValid(object? value)
    {
        string str = value!.ToString()!;
        return existColors.Contains(str.ToLower());
    }
}
