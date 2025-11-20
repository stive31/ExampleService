namespace Vk.Domain.Dictionary.Models;

public class DomainDrTypeRelation
{
    public int IdType1 { get; set; }
    public int IdType2 { get; set; }
    public string TypeCategoryCode { get; set; }
    public bool Must {  get; set; }
    public short Effect { get; set; }

    public override bool Equals(object? obj)
    {
        return this.IdType1 == ((DomainDrTypeRelation)obj).IdType1
            && this.IdType2 == ((DomainDrTypeRelation)obj).IdType2
            && this.TypeCategoryCode == ((DomainDrTypeRelation)obj).TypeCategoryCode
            && this.Must == ((DomainDrTypeRelation)obj).Must;
    }

    public override int GetHashCode()
    {
        int HashCode1 = this.IdType1.GetHashCode();
        int HashCode2 = this.IdType2.GetHashCode();
        int HashCode3 = this.TypeCategoryCode == null ? 0 : this.TypeCategoryCode.GetHashCode();
        int HashCode4 = this.Must.GetHashCode();

        return HashCode1 ^ HashCode2 ^ HashCode3 ^ HashCode4;
    }
}
