namespace Demo.DAL.Models;
public class BaseEntity
{
    public int Id { get; set; } // PK 
    public bool IsDeleted { get; set; }//عشان لو مسحته مثلا ومش عاوز احذفه من الداتا بيز
    public int CreatedBy { get; set; } // user Id
    public DateTime CreatedOn { get; set; } // 
    public int LastModifiedBy { get; set; } // User Id 
    public DateTime LastModifiedOn { get; set; }
}
