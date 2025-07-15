﻿using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var jsonString = File.ReadAllText("novelist.json");
            var novelist = Deserialize(jsonString);
            if (novelist is not null) {
                Console.WriteLine(novelist);
                foreach (var item in novelist.Masterpieces) {
                    Console.WriteLine(item);
                }
            }
        }

        static Novelist? Deserialize(string jsonString) {
            var options = new JsonSerializerOptions {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                NumberHandling =
                    JsonNumberHandling.AllowNamedFloatingPointLiterals |
                    JsonNumberHandling.AllowReadingFromString
            };
            return JsonSerializer.Deserialize<Novelist>(jsonString, options);
        }
    }

    public record Novelist {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("birth")]
        public DateTime Birthday { get; init; }
        public string[] Masterpieces { get; init; } = [];
    }
}
