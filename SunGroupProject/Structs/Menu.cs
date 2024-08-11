namespace SunGroupProject.Structs
{
    public struct Menu
    {

        public List<beverage> beveragesList = new List<beverage>();
        public Menu()
        {
            for (int i = 1; i <= 10; i++) {
                beverage beverage = new beverage();
                beverage.ID = i;
                beverage.Name = $"Beverage {i}";
                beveragesList.Add(beverage);
            }
        }
        public beverage this[int index]
        {
            get { return this.beveragesList[index]; }
            set { this.beveragesList[index] = value; }
        }
    }

    public struct beverage
    {
        public int ID;
        public string Name;
    }
}
