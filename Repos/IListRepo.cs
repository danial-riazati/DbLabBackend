using DbLabBackend.DataProvide;
using DbLabBackend.Models;

namespace DbLabBackend.Repos
{
    public interface IListRepo
    {
        public Task<IResult> GetList();
        public Task<IResult> AddItem(AddItemDTO dto);
        public Task<IResult> UpdateItem(UpdateItemDTO dto);
        public Task<IResult> RemoveItem(int id);

        public Task<IResult> GetHistory(int id);


    }
}