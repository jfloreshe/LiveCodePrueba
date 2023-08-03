namespace RoleBased.Data;

public class Profile : BaseModel
{
    public Profile() 
    { 
        Users = new HashSet<User>();
    }
    public int IdProfile { get; set; }
    public string Description { get; set; } 
    public IEnumerable<User> Users { get; set; }
}
