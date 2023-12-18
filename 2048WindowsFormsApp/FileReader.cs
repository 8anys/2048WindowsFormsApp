using System;
using System.IO;

namespace _2048WindowsFormsApp
{
    public class FileReader
    {
        public string ReadTextFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    return "Файл з правилами не знайдений.";
                }
            }
            catch (Exception ex)
            {
                return "Помилка при читанні файлу правил: " + ex.Message;
            }
        }
    }
}