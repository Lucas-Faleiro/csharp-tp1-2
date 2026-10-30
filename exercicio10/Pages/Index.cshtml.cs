using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio10.Pages
{
    public class IndexModel : PageModel
    {
        public List<Model.Produto> Produtos { get; set; } = new List<Model.Produto>
        {
            new Model.Produto { Nome = "Produto 1", Preco = "10.00" },
            new Model.Produto { Nome = "Produto 2", Preco = "20.00" },
            new Model.Produto { Nome = "Produto 3", Preco = "30.00" }
        };
        public void OnGet()
        {
          
        }
    }
}
