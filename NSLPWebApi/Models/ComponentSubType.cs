namespace NSLPWebApi.Models
{
    public class ComponentSubType
    {
        public int ComponentSubTypeId { get; set; }
        public string Name { get; set; }
        public int ComponentTypeId { get; set; }
        public ComponentType ComponentType { get; set; }
    }
}
