namespace WeatherApplication.Models
{
    public class WeatherModel
    {
        public Location location { get; set; }
        public Current current { get; set; }
    }
    public class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string localtime { get; set; }
    }
    public class Current
    {
        public int temp_c { get; set; }
        public int temp_f { get; set; }
    }
}
