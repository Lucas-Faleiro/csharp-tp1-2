namespace exercicio12.Model
{
    public class Event
    {
        public string titulo { get; set; }
        public DateOnly data { get; set; } = DateOnly.FromDateTime(DateTime.Today);
        public string local { get; set; }

        public void avisaNoConsole(Event e)
        {
            Console.WriteLine($"Evento {e.titulo} em {e.local} na data {e.data} foi criado com sucesso");
        }
    }
}
