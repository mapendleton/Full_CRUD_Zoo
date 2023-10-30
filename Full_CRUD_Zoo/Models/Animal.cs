using System.ComponentModel.DataAnnotations.Schema;

namespace Full_Crud_Zoo.Models;

[Table("animals")]
public class Animal
{
    [Column("animal_id")]
    public long Id { get; set; }
    [Column("name")]
    public string? Name { get; set; }
    [Column("species")]
    public string? Species { get; set; }
    [Column("age")]
    public int Age { get; set; }
}