using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public static class ContactSerializer
{
    public static void Serialize(string filePath, IEnumerable<Contact> contacts)
    {
        var serializer = new XmlSerializer(typeof(List<Contact>));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, new List<Contact>(contacts));
        }
    }

    public static List<Contact> Deserialize(string filePath)
    {
        var serializer = new XmlSerializer(typeof(List<Contact>));
        using (var reader = new StreamReader(filePath))
        {
            return (List<Contact>)serializer.Deserialize(reader);
        }
    }
}