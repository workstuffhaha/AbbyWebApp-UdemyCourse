using System;
using System.ComponentModel.DataAnnotations;

namespace AbbyWebApp.Model;

public class Categroy
{
    // we will name 3 columns here 
    // we need to create properties, and the shortcut for that is prop and tab
    [Key]
    public int Id { get; set; } //primary key
    [Required]
    public string Name { get; set; }// should be required, can not be a null property
    // how to add these rules?
    public int DisplayOrder { get; set; }


}
