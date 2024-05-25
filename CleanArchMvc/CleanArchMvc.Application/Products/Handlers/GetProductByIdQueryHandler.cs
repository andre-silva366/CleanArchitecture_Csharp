using CleanArchMvc.Application.Products.Queries;
using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _produtoRepository;

        public GetProductByIdQueryHandler(IProductRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetByIdAsync(request.Id);
        }
    }
}
