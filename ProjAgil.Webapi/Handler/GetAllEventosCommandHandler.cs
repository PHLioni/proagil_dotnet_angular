using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProAgil.Repository;
using ProjAgil.Webapi.Command;
using ProjAgil.Webapi.Dtos;

namespace ProjAgil.Webapi.Handler
{
    public class GetAllEventosCommandHandler : IRequestHandler<GetAllEventosCommand, IEnumerable<EventoDto>>
    {
        private readonly IProAgilRespository _repo;
        private readonly IMapper _mapper;

        public GetAllEventosCommandHandler(IProAgilRespository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EventoDto>> Handle(GetAllEventosCommand query, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllEventoAsync(false);
            return await Task.FromResult(_mapper.Map<List<EventoDto>>(result));
        }
    }
}