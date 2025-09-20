namespace DVLD_DataAccessLayer.Dtos
{
    public class UserDto
    {
            public int UserID { get; set; }
            public int PersonID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
    }
}
