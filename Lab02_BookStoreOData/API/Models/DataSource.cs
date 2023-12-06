namespace API.Models
{
    public class DataSource
    {
        private static IList<Book> listBooks { get; set; }

        public static IList<Book> GetBooks()
        {
            if (listBooks != null)
            {
                return listBooks;
            }

            listBooks = new List<Book>();
            listBooks.Add(new Book
            {
                Id = 1,
                ISBN = "917-0-321-82758-1",
                Title = "Ma Muchilis",
                Price = 5m,
                Location = new Address
                {
                    City = "HCM City",
                    Street = "D2 , Thu Duc District"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addison-Wesley",
                    Category = Category.Book
                }
            });
            listBooks.Add(new Book
            {
                Id = 2,
                ISBN = "117-0-321-87548-1",
                Title = "Wark Sichaelis",
                Price = 100m,
                Location = new Address
                {
                    City = "Hanoi City",
                    Street = "69 Vu Trong Phung, Thanh Xuan"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addison-Wesley",
                    Category = Category.Book
                }
            });
            listBooks.Add(new Book
            {
                Id = 3,
                ISBN = "987-0-321-87758-1",
                Title = "Mark Michaelis",
                Price = 59.99m,
                Location = new Address
                {
                    City = "HCM City",
                    Street = "D2 , Thu Duc District"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Ossison Pesley",
                    Category = Category.EBook
                }
            });
            listBooks.Add(new Book
            {
                Id = 4,
                ISBN = "912-5-321-11758-1",
                Title = "Tar Haelis",
                Price = 20.19m,
                Location = new Address
                {
                    City = "HCM City",
                    Street = "D2 , Thu Duc District"
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addison-Wesley",
                    Category = Category.Book
                }
            });
            return listBooks;
        }
    }
}
