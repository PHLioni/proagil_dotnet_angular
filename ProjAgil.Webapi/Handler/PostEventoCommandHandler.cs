using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProAgil.Repository;
using ProjAgil.Webapi.Command;
using ProjAgil.Webapi.Dtos;

namespace ProjAgil.Webapi.Handler
{
    public class PostEventoCommandHandler : IRequestHandler<PostEventoCommand, EventoDto>
    {
        private readonly IProAgilRespository _repo;
        private readonly IMapper _mapper;

        public PostEventoCommandHandler(IProAgilRespository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<EventoDto> Handle(PostEventoCommand request, CancellationToken cancellationToken)
        {
            //var evento = _mapper.Map<EventoDto>(request);
            _repo.Add(request);
            if (await _repo.SaveChangesAsync())
            {
                return _mapper.Map<EventoDto>(request);
            }
            else{
                return null;
            }
        }
    }
}