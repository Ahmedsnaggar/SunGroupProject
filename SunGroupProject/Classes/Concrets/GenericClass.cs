namespace SunGroupProject.Classes.Concrets
{
    public class GenericClass<T>
    {
       private List<T> List = new List<T>();

        public void addItem(T item)
        {
            List.Add(item);
        }
        public void removeItem(T item) 
        {
            List.Remove(item);
        }
        public List<T> GetAllItems()
        {
        return List; 
        }
    }
}
