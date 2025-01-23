class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Início do processamento assíncrono...");

        // Criando tarefas assíncronas com async e await
        Task<string> tarefa1 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 1", 2000));
        Task<string> tarefa2 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 2", 3000));
        Task<string> tarefa3 = Task.Run(() => OperacaoAssincrona("OPERAÇÃO 3", 1000));

        // Aguardando todas as tarefas com await e pegando os resultados
        string[] resultados = await Task.WhenAll(tarefa1, tarefa2, tarefa3);

        // Imprimindo os resultados retornados pelas operações
        foreach (var resultado in resultados)
        {
            Console.WriteLine(resultado);
        }

        Console.WriteLine("Processamento concluído!");

        // Espera para o usuário ver o resultado
        Console.WriteLine("Pressione Enter para finalizar...");
        Console.ReadLine();
    }

    // Método para simular operação assíncrona com retorno
    static async Task<string> OperacaoAssincrona(string nomeOperacao, int tempoEspera)
    {
        Console.WriteLine($"{nomeOperacao} - Iniciando...");
        await Task.Delay(tempoEspera); // Simula o tempo de espera (assíncrono)
        return $"{nomeOperacao} - Concluído após {tempoEspera} ms."; // Retorno com status da operação
    }
}
