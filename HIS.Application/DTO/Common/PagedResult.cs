using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.DTO.Common
{
    public sealed class PagedResult<T>
    {
        public IReadOnlyCollection<T> Items { get; init; }
            = [];

        public int PageNumber { get; init; }

        public int PageSize { get; init; }

        public int TotalCount { get; init; }

        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        public bool HasPreviousPage =>
            PageNumber > 1;

        public bool HasNextPage =>
            PageNumber < TotalPages;

        public static PagedResult<T> Create(
            IReadOnlyCollection<T> items,
            int pageNumber,
            int pageSize,
            int totalCount)
        {
            return new PagedResult<T>
            {
                Items = items,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }
    }
}
