using System.Collections;

namespace Pustok0.Areas.Admin.ViewModels
{
    public class PaginatonVM<T> where T : IEnumerable
    {
        public int TotalCount { get; }
        public T Items { get; }
        public PaginatonVM(int totalCount, T items)
        {
            TotalCount = totalCount;
            Items = items;
        }
    }
}

