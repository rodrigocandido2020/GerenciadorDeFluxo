class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Início do processamento assíncrono...");

        // Simulando a execução de operações assíncronas com Threads
        Task tarefa1 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 1", 2000));
        Task tarefa2 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 2", 3000));
        Task tarefa3 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 3", 1000));

        // Aguardando todas as tarefas terminarem de forma manual
        Task.WhenAll(tarefa1, tarefa2, tarefa3).Wait();

        Console.WriteLine("Processamento concluído!");

        // Espera para o usuário ver o resultado
        Console.WriteLine("Pressione Enter para finalizar...");
        Console.ReadLine();
    }

    // Método para simular operação assíncrona
    static void OperacaoAssincrona(string nomeOperacao, int tempoEspera)
    {
        Console.WriteLine($"{nomeOperacao} - Iniciando...");
        Task.Delay(tempoEspera).Wait(); // Simula o tempo de espera (bloqueante, sem await)
        Console.WriteLine($"{nomeOperacao} - Concluído após {tempoEspera} ms.");
    }
}
