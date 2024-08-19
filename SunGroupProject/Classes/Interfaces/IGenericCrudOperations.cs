namespace SunGroupProject.Classes.Interfaces
{
    public interface IGenericCrudOperations<T>
    {
        public List<T> GetAll();
        public T GetById(T item);
        public T Add(T item);
        public T Update(T item, T OldItem);
        public void Delete(T item);
    }
}
