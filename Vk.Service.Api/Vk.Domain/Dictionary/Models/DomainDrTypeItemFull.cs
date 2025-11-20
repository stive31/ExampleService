namespace Vk.Domain.Dictionary.Models
{
    public class DomainDrTypeItemFull : DomainDrTypeItem
    {
        /// <summary>
        /// Дополнительные параметры (варьируются)
        /// </summary>
        public Dictionary<string, object> AdditionalProperties { get; set; }
    }
}
