using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "Estudar C#", Description = "Aprender fundamentos do C#", Complete = false},
            new TaskItem { Id = 2, Title = "Estudar PostgreSQL", Description = "Criar tabelas e fazer consultas", Complete = false}
        };

        [HttpGet]
        public ActionResult<List<TaskItem>> GetTasks()
        {
            return Ok(tasks);
        }
    }
}