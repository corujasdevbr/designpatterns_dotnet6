namespace Adapter
{
    internal class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            listaAlunos.ForEach(x => Console.WriteLine($"Aluno {x.Nome} " +
                    $"- Valor da mensalidade R$ {x.Mensalidade}"));
        }
    }
}
