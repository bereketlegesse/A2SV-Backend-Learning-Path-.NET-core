using System.Collections.Generic;
using System.Threading.Tasks;
using day10.Domain;

namespace day10.Application.Interfaces;
public interface ICommentRepository
{
    Task<IEnumerable<CommentType>> GetCommentsByPostId(int PostId);
    Task<int> CreateComment(CommentType comment);
    Task UpdateComment(CommentType comment);
    Task DeleteComment(int CommentId);
}
