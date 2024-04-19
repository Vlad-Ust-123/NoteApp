using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace NoteApp
{
    /// <summary>
    /// Класс для управления сохранением и загрузкой проектов.
    /// </summary>
    public static class ProjectManager 
    {
        private const string FilePath = @"C:\Users\Пользователь\Desktop\Note_path";



        /// <summary>
        /// Сохраняет данные в файл в формате JSON.
        /// </summary>
        /// <typeparam name="T">Тип данных для сериализации.</typeparam>
        /// <param name="data">Данные для сохранения.</param>
        public static void SaveToFile<T>(T data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(FilePath, json);
                Console.WriteLine("Данные успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных в файл: {ex.Message}");
            }
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <typeparam name="T">Тип данных для десериализации.</typeparam>
        /// <returns>Загруженные данные.</returns>
        public static T LoadFromFile<T>()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    T data = JsonConvert.DeserializeObject<T>(json);
                    Console.WriteLine("Данные успешно загружены из файла.");
                    return data;
                }
                else
                {
                    Console.WriteLine("Файл данных не найден.");
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных из файла: {ex.Message}");
                return default(T);
            }

            
        }

    }
}
 
