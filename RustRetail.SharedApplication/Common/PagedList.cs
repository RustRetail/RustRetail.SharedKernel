﻿namespace RustRetail.SharedApplication.Common
{
    public class PagedList<T> where T : class
    {
        public List<T> Items { get; } = new List<T>();

        public int PageNumber { get; }

        public int PageSize { get; }

        public int TotalCount { get; set; }

        public bool HasNextPage => PageNumber * PageSize < TotalCount;

        public bool HasPreviousPage => PageNumber > 1;

        private PagedList(
            List<T> items,
            int pageNumber,
            int pageSize,
            int totalCount)
        {
            Items = items;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalCount = totalCount;
        }
    }
}
