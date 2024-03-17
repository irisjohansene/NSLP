namespace NSLPWebApi.Models
{
    public class ComponentType
    {
        public int ComponentTypeId { get; set; }
        public string Name { get; set; }
        public List<ComponentSubType> SubTypes { get; set; }
    }
}
