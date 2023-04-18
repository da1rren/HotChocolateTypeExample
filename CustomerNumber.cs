namespace HC.CustomerNumberScalar;

using HotChocolate.Language;

public class CustomerNumber
{
    public string? Id { get; set; }
}

public sealed class CustomerNumberType : ScalarType<CustomerNumber, StringValueNode>
{
    public CustomerNumberType() : base(nameof(CustomerNumber))
    {
    }

    public override object? Deserialize(object? resultValue)
    {
        return base.Deserialize(resultValue);
    }

    public override object? Serialize(object? runtimeValue)
    {
        if (runtimeValue is CustomerNumber customerNumber)
        {
            return customerNumber?.Id;
        }
        
        return base.Serialize(runtimeValue);
    }

    public override IValueNode ParseResult(object? resultValue)
    {
        if (resultValue is CustomerNumber s)
        {
            return new StringValueNode(null, s?.Id, false);
        }

        throw new Exception("Test");
    }

    protected override CustomerNumber ParseLiteral(StringValueNode valueSyntax)
    {
        return new CustomerNumber {Id = valueSyntax.Value};
    }

    protected override StringValueNode ParseValue(CustomerNumber runtimeValue)
    {
        return new StringValueNode(runtimeValue.Id);
    }
}
