using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }
}

public class Ticket
{
    public int TicketId { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static List<User> users = new List<User>();
    static List<Ticket> tickets = new List<Ticket>();
    static User currentUser = null;

    static void Main(string[] args)
    {
        users.Add(new User { Username = "admin", Password = "admin", Balance = 1000 });
        tickets.Add(new Ticket { TicketId = 1, Destination = "Baku", Price = 50 });
        tickets.Add(new Ticket { TicketId = 2, Destination = "Turkey", Price = 100 });

        while (true)
        {
            Console.WriteLine("Welcome to the Ticket System");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        currentUser = users.Find(u => u.Username == username && u.Password == password);

        if (currentUser != null)
        {
            Console.WriteLine($"Welcome {currentUser.Username}!");
            MainMenu();
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }

    static void Register()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        users.Add(new User { Username = username, Password = password, Balance = 0 });
        Console.WriteLine("Registration successful. Please login.");
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Buy Ticket");
            Console.WriteLine("2. View Balance");
            Console.WriteLine("3. Logout");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BuyTicket();
                    break;
                case "2":
                    ViewBalance();
                    break;
                case "3":
                    currentUser = null;
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void BuyTicket()
    {
        Console.WriteLine("Available Tickets:");
        foreach (Ticket ticket in tickets)
        {
            Console.WriteLine($"Ticket ID: {ticket.TicketId}, Destination: {ticket.Destination}, Price: {ticket.Price}");
        }

        Console.Write("Enter Ticket ID to buy: ");
        int ticketId = Convert.ToInt32(Console.ReadLine());
        Ticket selectedTicket = tickets.Find(t => t.TicketId == ticketId);

        if (selectedTicket != null && currentUser.Balance >= selectedTicket.Price)
        {
            currentUser.Balance -= selectedTicket.Price;
            Console.WriteLine("Ticket bought successfully!");
        }
        else
        {
            Console.WriteLine("Invalid ticket ID or insufficient balance.");
        }
    }

    static void ViewBalance()
    {
        Console.WriteLine($"Your balance: {currentUser.Balance}");
    }
}
