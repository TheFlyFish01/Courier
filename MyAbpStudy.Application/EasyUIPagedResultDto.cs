using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
namespace Abp.Application.Services.Dto
{
    public class EasyUIPagedResultDto<T>
    {
        public EasyUIPagedResultDto() { }
        public EasyUIPagedResultDto(int totalCount, IReadOnlyList<T> items)
        {
            total = items.Count;
            rows = items;
            totalCount = items.Count;
        }

        public int total { get; set; }
        public IReadOnlyList<T> rows { get; set; }
    }
}
