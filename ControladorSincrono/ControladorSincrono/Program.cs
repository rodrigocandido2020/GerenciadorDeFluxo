using System.Diagnostics;

Console.WriteLine("Início do processamento...");

// Passo 1
MedirTempo("OPERAÇÃO 1", CarregarDados);

// Passo 2
MedirTempo("OPERAÇÃO 2", ProcessarDados);

// Passo 3
MedirTempo("OPERAÇÃO 3", SalvarResultados);

Console.WriteLine("Processamento concluído!");

// Aguarda o usuário pressionar Enter para fechar o programa
Console.WriteLine("Pressione Enter para finalizar...");
Console.ReadLine();

// Método para medir o tempo de execução de uma operação
void MedirTempo(string nomeOperacao, Action operacao)
{
    Stopwatch stopwatch = Stopwatch.StartNew(); // Inicia a medição
    operacao(); // Executa a operação
    stopwatch.Stop(); // Para a medição
    Console.WriteLine($"{nomeOperacao} demorou {stopwatch.ElapsedMilliseconds} ms.");
}

// Método para carregar dados
void CarregarDados()
{
    Console.WriteLine("Iniciando operação 1");
    SimularEspera(2000); // Simula um atraso de 2 segundos
    Console.WriteLine("finalizando operação 1");
}

// Método para processar dados
void ProcessarDados()
{
    Console.WriteLine("Iniciando operação 2");
    SimularEspera(3000); // Simula um atraso de 3 segundos
    Console.WriteLine("finalizando operação 2");
}

// Método para salvar resultados
void SalvarResultados()
{
    Console.WriteLine("Iniciando operação 3");
    SimularEspera(1000); // Simula um atraso de 1 segundo
    Console.WriteLine("finalizando operação 3");
}

// Método para simular espera (em milissegundos)
void SimularEspera(int milissegundos)
{
    Thread.Sleep(milissegundos);
}
