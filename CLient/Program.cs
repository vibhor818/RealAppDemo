using System.Net.Http.Json;

ConsumeService();
Console.ReadLine();

async Task ConsumeService()
{
    var client=new HttpClient();
    var response = await client.GetAsync("http://localhost:5185/api/Customer");
    var result = await response.Content.ReadFromJsonAsync<IEnumerable<CustomerInfo>>();

    foreach (var item in result)
    {
        Console.WriteLine(item.CustomerId+"   "+item.CustomerName+"   "+item.CustomerAddress);
    }
}

public class CustomerInfo
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
}