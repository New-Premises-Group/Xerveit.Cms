using MapsterMapper;
using Xerveit.Core.Interfaces.Commands;
using Xerveit.Core.Interfaces.Repositories;
using Xerveit.Core.Interfaces.Services;

namespace Xerveit.Core.Common
{
    public abstract class AbstractCommandHandler : ICommandHandler
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        protected readonly IMediator _mediator;

        public AbstractCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _mediator = mediator;
        }

        public abstract Task<int> Handle<TRequest>(TRequest request);

        public abstract Task Undo();
    }
}
