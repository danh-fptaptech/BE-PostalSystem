namespace TARS_Delivery.Providers;

public class OtpProvider : IOtpProvider
{
    public string Generate(string possibleCharacters, int outputSize)
    {
        int n = possibleCharacters.Length;

        Random rand = new();

        string otp = "";

        for (int i = 0; i < outputSize; i++)
        {
            otp += possibleCharacters[rand.Next() % n];
        }

        return otp;
    }
}
