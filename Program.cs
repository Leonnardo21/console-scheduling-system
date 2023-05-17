using Microsoft.EntityFrameworkCore;
using SchedulingSystem.Data;
using SchedulingSystem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using var context = new SchedulingSystemContext();

        // CreateUsers(context);
        // ReadUsers(context);
        // UpdateUsers(context, 4);
        // DeleteUsers(context, 1);


    }

    public static void CreateUsers(SchedulingSystemContext context)
    {
        context.Users.Add(new User
        {
            Name = "Leonardo de Souza",
            Email = "leonardo@gmail.com",
            Phone = "8589779652",
            PasswordHash = Guid.NewGuid().ToString()
        });
        context.SaveChanges();
    }
    public static void ReadUsers(SchedulingSystemContext context)
    {
        var users = context
            .Users
            .AsNoTracking()
            .ToList();

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Name}");
        }
    }
    public static void UpdateUsers(SchedulingSystemContext context, int id)
    {
        var user = context
            .Users
            .Where(x => x.Id == id)
            .FirstOrDefault();

        user.Name = "Leonardo de Souza";
        user.Email = "leosouza1392@gmail.com";
        user.Phone = "8589779652";
        user.PasswordHash = Guid.NewGuid().ToString();

        context.Update(user);
        context.SaveChanges();
        Console.WriteLine($"Cadastro do usuário(a) {user.Name} atualizado!");

    }
    public static void DeleteUsers(SchedulingSystemContext context, int id)
    {
        var user = context
                 .Users
                 .Where(x => x.Id == id)
                 .FirstOrDefault();
        context.Users.Remove(user!);
        context.SaveChanges();
        Console.WriteLine("Usuário(a) removido!");
    }
}