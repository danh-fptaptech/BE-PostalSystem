namespace TARS_Delivery.Providers;

public interface IHashProvider
{
    string Hash(string input);

    bool Verify(string input, string hashedString);
}
