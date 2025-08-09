using MediatR;


namespace EducationalPlatform.Application.Features.Articles.Commands
{
    public class DeleteArticleCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

}
