using exercicio10.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio10.Pages
{
    public class AddProductModel : PageModel
    {
        public static List<Produto> ProdutosCadastrados { get; set; } = new();

        [BindProperty]
        public Produto NovoProduto { get; set; } = new();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(NovoProduto.Nome))
            {
                ProdutosCadastrados.Add(NovoProduto);
                ModelState.Clear();
                NovoProduto = new();
            }
        }
    }
}
