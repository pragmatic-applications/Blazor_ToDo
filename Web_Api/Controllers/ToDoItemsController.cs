using System.Threading.Tasks;

using AppConfigSettings;

using Domain;

using Interfaces;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

using PageFeatures;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        public ToDoItemsController(AppSettings options, IUnitOfWork unitOfWork)
        {
            this.Options = options;
            this.UnitOfWork = unitOfWork;
        }

        protected AppSettings Options { get; set; }
        protected readonly IUnitOfWork UnitOfWork;

        // GET: api/ToDoItems
        [HttpGet]
        [AllowAnonymous]
        public async Task<PagedList<ToDoItem>> Get([FromQuery] EntityParameter entityParameter)
        {
            var items = await this.UnitOfWork.ToDoItemRepository.GetPagedList(entityParameter);
            this.Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(items.PagerData));

            return items;
        }

        // GET: api/ToDoItems/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItem>> Get(int id)
        {
            var item = await this.UnitOfWork.ToDoItemRepository.FindEntityAsync(id);

            return item == null ? this.NotFound() : item;
        }

        // POST: api/ToDoItems
        [HttpPost]
        public async Task<ActionResult<ToDoItem>> Post(ToDoItem item)
        {
            await this.UnitOfWork.ToDoItemRepository.AddAsync(item);
            await this.UnitOfWork.SaveChangesAsync();

            return this.CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        // PUT: api/ToDoItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ToDoItem item)
        {
            if(id != item.Id) { return this.BadRequest(); }

            this.UnitOfWork.ToDoItemRepository.Update(item);

            try
            {
                await this.UnitOfWork.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!(await this.UnitOfWork.ToDoItemRepository.SuccessAsync(id)))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.NoContent();
        }

        // DELETE: api/ToDoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDoItem>> Delete(int id)
        {
            var item = await this.UnitOfWork.ToDoItemRepository.FindEntityAsync(id);

            if(item == null)
            {
                return this.NotFound();
            }

            //if(item is null)
            //{
            //    return this.NotFound();
            //}

            this.UnitOfWork.ToDoItemRepository.Remove(item);
            await this.UnitOfWork.SaveChangesAsync();

            return item;
        }
    }
}
