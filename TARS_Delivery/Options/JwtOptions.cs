namespace TARS_Delivery.Options;

internal class JwtOptions
{
    public const string Jwt = "Jwt";

    public string Issuer { get; init; } = string.Empty;

    public string Audience { get; init; } = string.Empty;

    public string SecretKey { get; init; } = string.Empty;
}
