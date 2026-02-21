using LearnBlazorBootstrap.Models;

namespace LearnBlazorBootstrap.Components.Pages;

public partial class Home
{
    private List<Person> People { get; set; } = new List<Person>();

    protected override void OnInitialized()
    {
        People = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 30 },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 25 },
            new Person { Id = 3, FirstName = "Bob", LastName = "Johnson", Age = 40 }
        };
    }
}
