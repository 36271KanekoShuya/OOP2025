﻿using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var emp = new Employee {
                Id = 123,
                Name = "山田太郎",
                HireDate = new DateTime(2018, 10, 1),
            };
            var jsonString = Serialize(emp);
            Console.WriteLine(jsonString);
            var obj = Deserialize(jsonString);
            Console.WriteLine(obj);

            //問題12.1.2
            Employee[] employees = [
                new () {
                    Id = 123,
                    Name = "山田太郎",
                    HireDate = new DateTime(2018, 10, 1),
                },
                new () {
                    Id = 198,
                    Name = "田中華子",
                    HireDate = new DateTime(2020, 4, 1),
                },
            ];
            Serialize("employees.json", employees);
        }


        static string Serialize(Employee emp) {
            var options = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            };
            string jsonString = JsonSerializer.Serialize(emp, options);
            return jsonString;
        }
        static Employee? Deserialize(string text) {
            var options = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            var novelist = JsonSerializer.Deserialize<Employee>(text,options);
            return novelist;
        }

        //問題12.1.2
        //シリアル化してファイルへ出力する
        static void Serialize(string filePath, IEnumerable<Employee> employees) {

        }


    }
    public record Employee {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
    }
}
