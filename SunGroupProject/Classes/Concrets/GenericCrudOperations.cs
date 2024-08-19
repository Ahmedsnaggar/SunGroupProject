using SunGroupProject.Classes.Interfaces;

namespace SunGroupProject.Classes.Concrets
{
    public class GenericCrudOperations<T> : IGenericCrudOperations<T> 
    {
        private List<T> _ItemList = new List<T>();
        public T Add(T item)
        {
            _ItemList.Add(item);
            return item;
        }

        public void Delete(T item)
        {
            var CurrentItem = GetById(item);
            _ItemList.Remove(CurrentItem);
        }

        public List<T> GetAll()
        {
            return _ItemList;
        }

        public T GetById(T item)
        {
            return _ItemList.FirstOrDefault(item);
        }

        public T Update(T item, T OldItem)
        {
            var CurrentItem = GetById(OldItem);
            CurrentItem = item;
            return CurrentItem;
        }
    }
}
