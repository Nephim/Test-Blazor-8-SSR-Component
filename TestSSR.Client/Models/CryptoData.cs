namespace TestSSR.Client.Models;

public class CryptoData
{
    public List<CryptoCurrency> Data { get; set; } = new();
    public long Timestamp { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is CryptoData other)
        {
            return Timestamp == other.Timestamp &&
                   Data.SequenceEqual(other.Data);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Timestamp, Data);
    }
}

public class CryptoCurrency
{
    public string Id { get; set; } = string.Empty;
    public string Rank { get; set; } = string.Empty;
    public string Symbol { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Supply { get; set; }
    public decimal? MaxSupply { get; set; }
    public decimal MarketCapUsd { get; set; }
    public decimal VolumeUsd24Hr { get; set; }
    public decimal PriceUsd { get; set; }
    public decimal ChangePercent24Hr { get; set; }
    public decimal? Vwap24Hr { get; set; }
    public string Explorer { get; set; } = string.Empty;

    public override bool Equals(object? obj)
    {
        if (obj is CryptoCurrency other)
        {
            return Id == other.Id &&
                   Rank == other.Rank &&
                   Symbol == other.Symbol &&
                   Name == other.Name &&
                   Supply == other.Supply &&
                   MaxSupply == other.MaxSupply &&
                   MarketCapUsd == other.MarketCapUsd &&
                   VolumeUsd24Hr == other.VolumeUsd24Hr &&
                   PriceUsd == other.PriceUsd &&
                   ChangePercent24Hr == other.ChangePercent24Hr &&
                   Vwap24Hr == other.Vwap24Hr &&
                   Explorer == other.Explorer;
        }

        return false;
    }

    public override int GetHashCode()
    {
        // Combine the first set of properties
        int hash1 = HashCode.Combine(Id, Rank, Symbol, Name, Supply, MaxSupply);

        // Combine the second set of properties
        int hash2 = HashCode.Combine(MarketCapUsd, VolumeUsd24Hr, PriceUsd, ChangePercent24Hr, Vwap24Hr, Explorer);

        // Combine the two hashes into the final hash code
        return HashCode.Combine(hash1, hash2);
    }

}