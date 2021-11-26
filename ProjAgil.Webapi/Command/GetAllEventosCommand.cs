using System.Collections;
using System.Collections.Generic;
using MediatR;
using ProjAgil.Webapi.Dtos;

namespace ProjAgil.Webapi.Command
{
    public class GetAllEventosCommand: IRequest<IEnumerable<EventoDto>>
    {
        
    }
}