namespace TARS_Delivery.Providers;

interface IOtpProvider
{
    string Generate(string possibleCharacters, int outputSize);
}
