// See https://aka.ms/new-console-template for more information
var dt = getData();
Console.WriteLine("Name={0},Id={1}",dt.Name,dt.Id);

static Customer getData()
{
    return new Customer()
    {
        Name = "John Doe",
        Id = 12345
    };
}

class Customer
{ 
    public int Id { get; set; }
    public string? Name { get; set; }
}