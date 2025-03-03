using DevIO.Business.Models;

namespace DevIO.Business.Interfaces;

public interface IProdutoService
{
    Task Adicionar(Produto produto);
    Task Atualizar(Produto produto);
    Task Remover(Guid id);
}