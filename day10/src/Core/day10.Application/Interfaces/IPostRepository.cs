using System.Collections.Generic;
using System.Threading.Tasks;
using day10.Domain;


namespace day10.Application.Interfaces{
public interface IPostRepository
{
    Task<IEnumerable<PostType>> GetAllPosts();
    Task<PostType> GetPostById(int PostId);
    Task<int> CreatePost(PostType post);
    Task UpdatePost(PostType post);
    Task DeletePost(int id);
}
}