using consumo;


GerenciaService gerenciaService = new();

var id = 1; 

Gerencia gerenciaEncontrada = await gerenciaService.GetGerenciaPorId(id); 

if (!gerenciaEncontrada.Verificacao)
{
    Console.WriteLine("Gerencia encontrada");
    Console.WriteLine(gerenciaEncontrada.Nome);
    Console.WriteLine(gerenciaEncontrada.Departamento);
}