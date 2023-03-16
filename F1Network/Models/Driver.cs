namespace F1Network.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PictureURL { get; set; }
        public string Description { get; set; }
        
        //Relations
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
