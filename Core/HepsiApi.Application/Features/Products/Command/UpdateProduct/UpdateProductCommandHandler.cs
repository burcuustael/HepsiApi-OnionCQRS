using HepsiApi.Application.Interfaces.AutoMapper;
using HepsiApi.Application.Interfaces.UnitOfWorks;
using HepsiApi.Domain.Entities;
using MediatR;

namespace HepsiApi.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UpdateProductCommandHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Product,UpdateProductCommandRequest>(request);

            var productCategories = await unitOfWork.GetReadRepository<ProductCategory>()
                .GetAllAsync(x=>x.ProductId==product.Id);

            await unitOfWork.GetWriteRepository<ProductCategory>()
        }
    }
}
