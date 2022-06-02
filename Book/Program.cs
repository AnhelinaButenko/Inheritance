using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Title("Kfghjkl"), new Author("Sfghjk"), new Content("Dfghj GHJK yhuJIuio"));

            book.Show();
        }
    }
}
