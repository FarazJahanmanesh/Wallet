namespace Domain.Commons;



//this class for stacture of all entities
public class BaseEntity<T>
{
    public T Id{ get; set; }
    public bool IsDeleted { get; set; }
}
public class BaseEntity: BaseEntity<long>
{
}
