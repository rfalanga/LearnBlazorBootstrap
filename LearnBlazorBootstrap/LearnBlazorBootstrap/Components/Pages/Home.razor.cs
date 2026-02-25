using LearnBlazorBootstrap.Models;

namespace LearnBlazorBootstrap.Components.Pages;

public partial class Home
{
    public IEnumerable<Person> People { get; set; } = default!;

    protected override void OnInitialized()
    {
        // Sample data for demonstration purposes
        People = GetPeople();
    }

    private static List<Person> GetPeople()
    {
        return
        [
            new Person { Id = 1, FirstName = "John", LastName = "Doe", Age = 30 },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 25 },
            new Person { Id = 3, FirstName = "Bob", LastName = "Johnson", Age = 40 },
            new Person { Id = 4, FirstName = "Alice", LastName = "Williams", Age = 28 },
            new Person { Id = 5, FirstName = "Charlie", LastName = "Brown", Age = 35 },
            new Person { Id = 6, FirstName = "Diana", LastName = "Davis", Age = 32 },
            new Person { Id = 7, FirstName = "Edward", LastName = "Miller", Age = 45 },
            new Person { Id = 8, FirstName = "Fiona", LastName = "Wilson", Age = 27 },
            new Person { Id = 9, FirstName = "George", LastName = "Moore", Age = 38 },
            new Person { Id = 10, FirstName = "Hannah", LastName = "Taylor", Age = 29 },
            new Person { Id = 11, FirstName = "Isaac", LastName = "Anderson", Age = 42 },
            new Person { Id = 12, FirstName = "Julia", LastName = "Thomas", Age = 31 },
            new Person { Id = 13, FirstName = "Kevin", LastName = "Jackson", Age = 36 },
            new Person { Id = 14, FirstName = "Laura", LastName = "White", Age = 26 },
            new Person { Id = 15, FirstName = "Michael", LastName = "Harris", Age = 44 },
            new Person { Id = 16, FirstName = "Nancy", LastName = "Martin", Age = 33 },
            new Person { Id = 17, FirstName = "Oliver", LastName = "Thompson", Age = 39 },
            new Person { Id = 18, FirstName = "Patricia", LastName = "Garcia", Age = 34 },
            new Person { Id = 19, FirstName = "Quinn", LastName = "Martinez", Age = 41 },
            new Person { Id = 20, FirstName = "Rachel", LastName = "Robinson", Age = 28 },
            new Person { Id = 21, FirstName = "Samuel", LastName = "Clark", Age = 37 },
            new Person { Id = 22, FirstName = "Teresa", LastName = "Rodriguez", Age = 30 },
            new Person { Id = 23, FirstName = "Ulysses", LastName = "Lewis", Age = 43 },
            new Person { Id = 24, FirstName = "Victoria", LastName = "Lee", Age = 29 },
            new Person { Id = 25, FirstName = "William", LastName = "Walker", Age = 35 }
        ];
    }
}
