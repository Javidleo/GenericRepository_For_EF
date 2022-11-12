using Microsoft.AspNetCore.Mvc.Filters;

namespace GenericRepository
{
    // for adding this filter to your application pipeline 
    // you need to add next lines to your startup class 
    //services.AddControllers(config => 
    //{
    //    config.Filters.Add<UnitOfWorkFilter>();
    //});

    public class UnitOfWorkFilter : IActionFilter
    {
        private readonly IUnitOfWork _unitOfWork;
        public UnitOfWorkFilter(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public void OnActionExecuted(ActionExecutedContext context)
        => _unitOfWork.SaveChanges();

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
