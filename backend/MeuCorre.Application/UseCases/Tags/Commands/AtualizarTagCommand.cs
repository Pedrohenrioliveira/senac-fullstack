using MediatR;
using MeuCorre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class AtualizarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "O Id do usuário é obrigatório")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "O Id da tag é obrigatório")]
        public required Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public required Guid Nome { get; set; }

        public string? Cor { get; set; }
    }

    internal class AtualizarTagCommandHandler : IRequestHandler<AtualizarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
