using MVCBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    interface IPRodutoRepository : IRespository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Fornecedor> ObterProdutoFornecedor(Guid id);
    }
}
