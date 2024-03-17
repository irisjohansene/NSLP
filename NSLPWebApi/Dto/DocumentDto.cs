namespace NSLPWebApi.Dto
{
    public class DocumentDto
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
    }
}
