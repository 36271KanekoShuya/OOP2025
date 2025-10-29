
using System.Security.Cryptography.X509Certificates;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            Console.WriteLine(Library.Books.MaxBy(x => x.Price));
        }

        private static void Exercise1_3() {
            Library.Books
                .GroupBy(b => b.PublishedYear)
                .OrderBy(b => b.Key)
                .Select(b => new {
                    PublishedYear = b.Key,
                    Count = b.Count(),
                })
                .ToList().ForEach(b => Console.WriteLine(b));
        }

        private static void Exercise1_4() {
            var books = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price);

            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title}");
            }
        }

        private static void Exercise1_5() {
            Library.Books
                .Where(b => b.PublishedYear == 2022)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name)
                .Distinct()
                .ToList().ForEach(b => Console.WriteLine(b));
        }

        private static void Exercise1_6() {
            var groupedBooks = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.Title,
                    Category = category.Name,
                })
                .GroupBy(b => b.Category)
                .OrderBy(g => g.Key)
                .Select(g => new {
                    CategoryName = g.Key,
                    Books = g.OrderBy(x => x.Title)
                });

            foreach (var group in groupedBooks) {
                Console.WriteLine($"# {group.CategoryName}");
                foreach (var book in group.Books) {
                    Console.WriteLine($"   {book.Title}");
                }
                Console.WriteLine();
            }
        }

        private static void Exercise1_7() {
            var groupedBooks = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                book.Title,
                Category = category.Name,
                book.PublishedYear,
                })
                .Where(b => b.Category == "Development")
                .GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key)
                .Select(g => new {
                    CategoryName = g.Key,
                    Books = g.OrderBy(x => x.Title)
                });

            foreach (var group in groupedBooks) {
                Console.WriteLine($"# {group.CategoryName}");
                foreach (var book in group.Books) {
                    Console.WriteLine($"   {book.Title}");
                }
            }
        }


        private static void Exercise1_8() {
            Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new {
                    Category = c.Name,
                    Count = books.Count()
                })
                .Where(b => b.Count >= 4)
                .ToList().ForEach(b => Console.WriteLine(b.Category));
        }
    }
}
