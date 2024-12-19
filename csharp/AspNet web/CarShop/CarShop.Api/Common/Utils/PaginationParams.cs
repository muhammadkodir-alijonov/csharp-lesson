namespace CarShop.Api.Common.Utils;
public class PaginationParams
{
    public PaginationParams(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
    public PaginationParams(int pageNumber)
    {
        PageNumber = pageNumber;
        PageSize = 30;
    }

    public int PageNumber { get; set; }

    public int PageSize { get; set; }
}
