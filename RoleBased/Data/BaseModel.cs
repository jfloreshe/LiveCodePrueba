namespace RoleBased.Data;

public class BaseModel
{
    public string LogUserCreation { get; set; }
    public string? LogUserModification { get; set; }
    public DateTime LogDateCreation { get; set; }
    public DateTime? LogDateModification { get; set;}
}
