using SchedulingSystem.Data;
using SchedulingSystem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using var context = new SchedulingSystemContext();

        context.Users.Add(new User
        {
            Name = "Leonardo de Souza Rodrigues",
            Email = "leosouza1392@gmail.com",
            Phone = "85998067348",
            PasswordHash = Guid.NewGuid().ToString()
        });
        context.SaveChanges();
    }
}