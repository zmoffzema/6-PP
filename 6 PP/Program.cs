using System;
using System.Text;

class PasswordGenerator
{
    static void Main()
    {
        Console.WriteLine("Генератор паролей");

        // Запрашиваем длину пароля у пользователя
        Console.Write("Введите длину пароля: ");
        int length;
        if (int.TryParse(Console.ReadLine(), out length) && length > 0)
        {
            // Генерируем пароль
            string password = GeneratePassword(length);
            Console.WriteLine($"Сгенерированный пароль: {password}");
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректную длину пароля.");
        }
    }

    static string GeneratePassword(int length)
    {
        const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
        const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        const string specialChars = "!@#$%^&*()-_=+<>?";

        string allChars = lowerChars + upperChars + digits + specialChars;
        StringBuilder password = new StringBuilder();
        Random rand = new Random();

        // Генерируем пароль случайным образом
        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(allChars.Length);
            password.Append(allChars[index]);
        }

        return password.ToString();
    }
}