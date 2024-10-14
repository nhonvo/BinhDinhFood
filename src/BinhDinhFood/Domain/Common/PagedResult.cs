namespace BinhDinhFood.Domain.Common;

public class PagedResult<T> : PagedResultBase
{
    public List<T> Items { set; get; }
}

