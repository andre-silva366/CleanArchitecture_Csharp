using AutoMapper;
using CleanArchMvc.Application.Products.Queries;
using CleanArchMVC.Application.DTOs;
using CleanArchMVC.Application.Interfaces;
using CleanArchMVC.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Services
{
    public class ProductService : IProductService
    {
        //private IProductRepository _productRepository;
        private IMediator _mediator;
        private IMapper _mapper;

        public ProductService(IMediator mediator, IMapper mapper)
        {
           // _productRepository = produtoRepository ?? throw new ArgumentNullException(nameof(produtoRepository));
           _mediator = mediator;
           _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if(productsQuery == null)
            {
                throw new Exception($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var productsQuery = new GetProductByIdQuery(id);

            if (productsQuery == null)
            {
                throw new ApplicationException($"Entity could not be loaded.");
            }

            var result = await _mediator.Send(productsQuery);

            return _mapper.Map<ProductDTO>(result);
        }

        public async Task<ProductDTO> GetProductCategory(int? id)
        {
            var productsQuery = new GetProductByIdQuery(id);
            
            return _mapper.Map<ProductDTO>(produtoEntity); 

        }

        public async Task Add(ProductDTO productDTO)
        {
            var productsEntity = _mapper.Map<Product> (productDTO);
            await _productRepository.CreateAsync(productsEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product> (productDTO);
            await _productRepository.UpdateAsync(productEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(productEntity);
        }

        
    }
}
