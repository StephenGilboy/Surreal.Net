namespace Surreal.Net.Tests;

public class RpcClientTests
{
    [Fact]
    public async Task Open()
    {
        RpcClient client = new();
        await client.Open(ConfigHelper.Default.Endpoint!, true);
    }
    
    [Fact]
    public async Task Signin()
    {
        RpcClient client = new();
        await client.Open(ConfigHelper.Default.Endpoint!, true);
        await client.Send(new()
        {
            Method = "signin",
            Params = new List<object?>{ 
                new Dictionary<string, object?>()
                {
                    ["user"] = ConfigHelper.Default.Username,
                    ["pass"] = ConfigHelper.Default.Password
                }
            }
        });
    }

}