using MediatR;
using Org.BouncyCastle.Asn1.Ocsp;

namespace TraversalCoreProje.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
