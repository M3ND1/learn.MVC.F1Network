namespace F1Network.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureURL { get; set; }
        public string Description { get; set; }
        //relations
        public List<Driver> Drivers { get; set; }
        public List<Car> Cars { get; set; }
    }
}
