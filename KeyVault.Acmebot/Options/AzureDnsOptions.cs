namespace KeyVault.Acmebot.Options;

public class AzureDnsOptions
{
    public string SubscriptionId { get; set; }
    public string Environment { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string TenantId { get; set; }
}
