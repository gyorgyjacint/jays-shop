using Jaysbe.Models;

namespace Jaysbe.Contracts;

public class ProductUpdateRequest : Product
{
    public IFormFile? ThumbnailNew { get; set; }
    public ICollection<IFormFile>? PicturesNew { get; set; }
}