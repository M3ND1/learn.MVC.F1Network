namespace F1Network.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string PictureURL { get; set; }
        public string Description { get; set; }
        public List<Driver> Drivers { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
