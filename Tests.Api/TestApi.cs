using System.Net;
using System.Net.Http;

namespace Tests.Api;

[TestClass]
public class TestApi
{
    [TestMethod]
    public async Task TestReturnsExpectedResponse()
    {
        var client = new HttpClient();
        var result = await client.GetAsync("http://api:5075/Distance?startLatitude=4&startLongitude=4&endLatitude=4&endLongitude=4");
        result.EnsureSuccessStatusCode();
        var responseBody = await result.Content.ReadAsStringAsync();
        Assert.AreEqual("0", responseBody);
    }

    [TestMethod]
    public async Task TestReturnsErrorWithBadRequest()
    {
        var client = new HttpClient();
        var result = await clieghnt.GetAsync("http://api:5075/Distance?startLatitude=DEFINITELY_NOT_A_NUMBER");
        Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
    }
}