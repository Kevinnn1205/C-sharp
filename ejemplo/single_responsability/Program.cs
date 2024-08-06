// sigle responsability

using System;

// La clase User tiene la única responsabilidad de representar los datos de un usuario (nombre y correo electrónico).
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

// Clase UserPrinter: Se encarga de imprimir la información del usuario.
public class UserPrinter
{
    // Método para imprimir la información del usuario.
    public void PrintUserInfo(User user)
    {
        Console.WriteLine($"User: {user.Name}, Email: {user.Email}");
    }
}

// Clase Program: Punto de entrada de la aplicación.
public class Program
{
    public static void Main(string[] args)
    {
        // Creación de un nuevo usuario.
        User user = new User("Jane Doe", "jane.doe@example.com");

        // Creación de un impresor de usuarios y uso del método para imprimir la información del usuario.
        UserPrinter userPrinter = new UserPrinter();
        userPrinter.PrintUserInfo(user);
    }
}
