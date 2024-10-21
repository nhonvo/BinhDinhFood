namespace BinhDinhFood.Application.Common.Models;

public class Pagination<T>
{
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalItemsCount
    {
        get
        {
            var temp = TotalPages / PageSize;
            return TotalPages % PageSize == 0 ? temp : temp;
        }
    }
    public int CurrentPage { get; set; }

    /// <summary>
    /// page number start from 0
    /// </summary>
    public bool Next => CurrentPage + 1 < TotalItemsCount;
    public bool Previous => CurrentPage > 0;
    public ICollection<T>? Items { get; set; }
}
