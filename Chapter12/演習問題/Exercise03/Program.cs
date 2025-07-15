﻿using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var employees = Deserialize("employees.json");
            if (employees is not null) {
                ToXmlFile(employees);
            }
        }

        static Employee[]? Deserialize(string filePath) {
            var options = new JsonSerializerOptions {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                NumberHandling =
                    JsonNumberHandling.AllowNamedFloatingPointLiterals |
                    JsonNumberHandling.AllowReadingFromString
            };
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Employee[]>(jsonString, options);

        }

        static void ToXmlFile(Employee[] employees) {
            using (var writer = XmlWriter.Create("employees.xml")) {
                var serializer = new XmlSerializer(employees.GetType());
                serializer.Serialize(writer, employees);
            }

        }
    }

    [XmlRoot("Employees")]
    public record Employee {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime HireDate { get; set; }
    }
}
