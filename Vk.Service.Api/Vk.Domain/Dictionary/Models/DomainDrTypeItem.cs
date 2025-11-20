namespace Vk.Domain.Dictionary.Models
{
    public class DomainDrTypeItem
    {
        public int? IdType { get; set; }
        public int? IdParent { get; set; }
        public string Code { get; set; }
        public string Bcode { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid? TypeUuid { get; set; }
        public bool? TypeReal { get; set; }
        public int? TypeOrder { get; set; }
    }
}
