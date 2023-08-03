namespace RoleBased.DTO;

public class UserDTO
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Gender { get; init; }
    public List<ProfileDTO> Profiles { get; set; }
}
