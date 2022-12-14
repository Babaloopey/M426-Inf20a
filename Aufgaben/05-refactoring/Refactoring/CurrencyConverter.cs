namespace Refactoring;

public class CurrencyConverter
{
    string ToCurrency { get; }

    public CurrencyConverter(string toCurrency)
    {
        this.ToCurrency = toCurrency;
    }

    public double ConvertTo(double amount)
    {
        switch (ToCurrency)
        {
            case "USD":
                return amount * 1.09;
            case "EUR":
                return amount * 0.96;
            case "GBP":
                return amount * 0.82;
            case "RUB":
                return amount * 79.78;
            default:
                throw new ArgumentException($"no exchange rate for {ToCurrency} available");
        }
    }
}