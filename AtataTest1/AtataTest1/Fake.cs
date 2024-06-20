using Newtonsoft.Json; // You can replace with your preferred JSON serializer
using System.Net;

namespace AtataTest1;

public class FakeApiTests
{
    private HttpClient _client;

    [SetUp]
    public void Setup()
    {
        _client = new HttpClient();
    }

    [Test]
    public async Task TestGetUsers_ReturnsSuccess()
    {
        // Arrange
        string url = "https://reqres.in/api/users?page=2";

        // Act
        HttpResponseMessage response = await _client.GetAsync(url);
        // Assert
        response.EnsureSuccessStatusCode(); // Throws exception for non-success codes
        Assert.That(HttpStatusCode.OK == response.StatusCode);

        string content = await response.Content.ReadAsStringAsync();
        ListUser listUser = JsonConvert.DeserializeObject<ListUser>(content); // Assuming JSON response

        // Add more assertions on the response data if needed
        Assert.That(listUser != null); // Basic check for non-empty response
    }

}

public class ListUser
{
    public int Page { get; set; }
    public int PerPage { get; set; }
}
