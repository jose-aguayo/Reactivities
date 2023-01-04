using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers //namespaces are used to organize the classes 
{
    public class ActivitiesController : BaseApiController  //means that the class is implementing an interface
    {
        private readonly DataContext _context; //DataContext is the source of all entities mapped over a database connection.
        public ActivitiesController(DataContext context) //this is the constructor
        {
            _context = context;
        }
                  // [] it is a way of specifying attributes
        [HttpGet] //api/activities  definition of the http get method
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }


    }
}