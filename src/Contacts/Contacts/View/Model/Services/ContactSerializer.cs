using Contacts.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Сериализация и десериализация контактов <see cref="Contact"></see>
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Путь файла.
        /// </summary>
        private static string _filePath = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Возвращает и задаёт путь json файла. Должен быть с расширением .json.
        /// </summary>
        public static string FilePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                string extension = Path.GetExtension(value);
                if (string.Equals(extension, ".json", StringComparison.OrdinalIgnoreCase))
                {
                    _filePath = value;
                }
            }
        }

        /// <summary>
        /// Сохранение контакта в файл. 
        /// </summary>
        /// <param name="contact">Экземпляр класса <see cref="Contact"/>.</param>
        public static void SaveContact(Contact contact)
        {
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            }
            string jsonData = JsonConvert.SerializeObject(contact);
            File.WriteAllText(FilePath, jsonData);
        }

        /// <summary>
        /// Загрузка данных контакта из .json файла.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Contact"/>.</returns>
        public static Contact LoadContact()
        {
            if (!File.Exists(FilePath))
            {
                return new Contact();
            }
            string jsonData = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<Contact>(jsonData);
        }
    }
}