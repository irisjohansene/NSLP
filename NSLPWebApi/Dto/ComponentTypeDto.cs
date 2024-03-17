namespace NSLPWebApi.Dto
{
    public class ComponentTypeDto
    {
        public int ComponentTypeId { get; set; }
        public string Name { get; set; }
        public List<ComponentSubTypeDto> SubTypes { get; set; }
    }
}
