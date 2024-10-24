using System;

namespace API.Entities;

public class AppUser
{

    public int Id { get; set; }//integer primitif type

    public required string UserName { get; set; }//string referebce type

}
