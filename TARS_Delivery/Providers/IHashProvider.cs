namespace TARS_Delivery.Providers;

internal interface IHashProvider
{
    string Hash(string input);

    bool Verify(string input, string hashedString);
}
