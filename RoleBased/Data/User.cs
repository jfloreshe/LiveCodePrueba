namespace RoleBased.Data;

public class User : BaseModel
{
    public User()
    {
        Profiles = new HashSet<Profile>();
    }
    public int IdUser { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public string Gender { get; set; }
    public IEnumerable<Profile> Profiles { get; set; }
}
