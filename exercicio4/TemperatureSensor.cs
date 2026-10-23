namespace exercicio4
{
    internal class TemperatureSensor
    {
        public double temperatura { get; set; }

        public event Action<string> TemperaturaUltrapassada;


        public void alterarTemperatura(double temp)
        {
            temperatura = temp;
            Console.WriteLine($"Temperatura agora está em: {temperatura}");
            if (temperatura > 100)
            {
                TemperaturaUltrapassada($"ALERTA! Temperatura ultrapassou 100 graus");
            }
        }

        public void NotificarTemperatura(string mensagem)
        {
            Console.WriteLine($"{mensagem}: {temperatura}º atualmente");
        }

    }
}
