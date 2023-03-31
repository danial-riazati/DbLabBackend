using DbLabBackend.DataProvide;
using DbLabBackend.Models;

namespace DbLabBackend.Repos
{
    public class ListRepo : IListRepo
    {
        private readonly ApplicationDbContext _context;

        public ListRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IResult> AddItem(AddItemDTO dto)
        {
            Item item = new() { Date = DateTime.Now, Value = dto.Value };
            await _context.AddAsync<Item>(item);

            await _context.SaveChangesAsync();

            return Results.Ok();
        }

        public async Task<IResult> GetHistory(int id)
        {
            var history = (from i in _context.ItemHistories
                           where i.Item.Id == id
                           orderby i.Date
                           select i).ToList();
            
            return Results.Ok(history);
        }

        public async Task<IResult> GetList()
        {
            var items = (from i in _context.Items
                         select i).ToList();

            if (items.Count == 0)
                return Results.NotFound();

            return Results.Ok(items);

        }

        public async Task<IResult> RemoveItem(int id)
        {
            var item = (from i in _context.Items
                        where i.Id == id

                        select i).FirstOrDefault();

            if (item == null)
                return Results.NotFound();

            item.isRemoved = true;
            item.Date = DateTime.Now;
            await _context.SaveChangesAsync();
            return Results.Ok();
        }

        public async Task<IResult> UpdateItem(UpdateItemDTO dto)
        {
            var item = (from i in _context.Items
                        where i.Id == dto.Id
                        select i).FirstOrDefault();

            if (item == null)
                return Results.NotFound();
            var newDate = DateTime.Now;
            ItemHistory newItemHistory = new() { Item = item, Date = newDate, Value = item.Value };
            await _context.AddAsync<ItemHistory>(newItemHistory);

            item.Value = dto.NewValue;
            item.Date = newDate;
            await _context.SaveChangesAsync();

            return Results.Ok();

        }
    }
}