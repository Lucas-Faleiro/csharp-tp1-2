using exercicio12.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio12.Pages
{
    public class CadastroEventosModel : PageModel
    {
        public Action<Event> Evento;

        [BindProperty]
        public Event NovoEvento { get; set; } = new();

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Evento += NovoEvento.avisaNoConsole;
            Evento?.Invoke(NovoEvento);
            ModelState.Clear();
            NovoEvento = new();
        }
    }
}
