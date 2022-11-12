namespace GenericRepository
{
    public interface IUnitOfWork // you need to inherite from this interface in your dbContext Class 
    {
        int SaveChanges();
    }
}
