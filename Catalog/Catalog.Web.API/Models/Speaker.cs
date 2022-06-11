namespace Catalog.Web.API.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Twitter { get; set; }
        public string GitHub { get; set; }
        public string Blog { get; set; }
        public string Company { get; set; }
        //YAGNI: You Ain't Gonna Need It
        
    }
}
