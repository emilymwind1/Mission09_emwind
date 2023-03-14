using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_emwind.Models;

namespace Mission09_emwind.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public CartModel (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }

        public void OnGet(Basket b)
        {
            basket = b;
        }

        public IActionResult onPost(int bookId)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket = new Basket();

            basket.AddItem(b, 1);

            return RedirectToPage(basket);
        }
    }
}
