using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите путь к исходному текстовому файлу:");
            string? sourceFilePath = Console.ReadLine();

            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Ошибка: указанный файл не существует.");
                return;
            }

            Console.WriteLine("Введите путь и имя нового файла:");
            string? destinationFilePath = Console.ReadLine();

            string fileContent = File.ReadAllText(sourceFilePath);

            string upperCaseContent = fileContent.ToUpper();

            File.WriteAllText(destinationFilePath, upperCaseContent);

            Console.WriteLine($"Файл успешно скопирован в '{destinationFilePath}' с преобразованием символов в верхний регистр.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
