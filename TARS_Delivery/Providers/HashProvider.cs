using System.Security.Cryptography;

namespace TARS_Delivery.Providers;

internal class HashProvider : IHashProvider
{
    private const int _saltSize = 16;
    private const int _outputSize = 32;
    private const int _iterations = 10000;
    private readonly HashAlgorithmName _algorithm = HashAlgorithmName.SHA256;
    private const char _segmentDelimiter = ':';

    public string Hash(string input)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(_saltSize);

        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
            input, 
            salt,
            _iterations,
            _algorithm,
            _outputSize);

        return string.Join(
            _segmentDelimiter,
            Convert.ToBase64String(hash),
            Convert.ToBase64String(salt),
            _iterations,
            _algorithm);
    }

    public bool Verify(string input, string hashedString)
    {
        string[] segments = hashedString.Split(_segmentDelimiter);

        byte[] hash = Convert.FromBase64String(segments[0]);
        byte[] salt = Convert.FromBase64String(segments[1]);

        int iterations = int.Parse(segments[2]);

        HashAlgorithmName algorithm = new(segments[3]);

        byte[] inputHash = Rfc2898DeriveBytes.Pbkdf2(
            input,
            salt,
            iterations,
            algorithm,
            hash.Length
        );

        return CryptographicOperations.FixedTimeEquals(inputHash, hash);
    }
}
