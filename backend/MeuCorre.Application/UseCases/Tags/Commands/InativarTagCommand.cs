using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    class InativarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "É necessário informar o ID da Tag")]
        public required Guid Id { get; set; }
    }


    internal class InativarTagCommandHandler : IRequestHandler<InativarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(InativarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}