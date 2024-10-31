using AutoMapper;
using ClothingStore.Application.Extensions;
using ClothingStore.Application.Interfaces;
using ClothingStore.Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace ClothingStore.Application.Features.Command
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<AddProductCommand> validationRules;
        public AddProductCommandHandler(IUnitOfWork uow, IMapper mapper, AbstractValidator<AddProductCommand> validationRules)
        {
            _uow = uow;
            _mapper = mapper;
            this.validationRules = validationRules;
        }
        public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await validationRules.ThrowIfValidationFailAsync(request);
            var productEntity = _mapper.Map<Product>(request);
            await _uow.ProductRepository.AddAsync(productEntity);
            await _uow.Commit();
        }
    }
}
