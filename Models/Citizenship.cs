using System.ComponentModel.DataAnnotations;

namespace CRM.Models;
public class Citizenship 
{
    public int ID { get; set;}
    
    public string Name {get; set;}
    public string Birthplace {get; set;}
    public string District {get; set;}
    public int Ward {get; set;}
    [DataType(DataType.Date)]
    public DateTime Birthdate {get; set;}
    public string FatherName {get; set;}
    public string Address {get; set;}
    public int CitizenshipNumber {get; set;}
    public string PermanentAddrress{get; set;}
    public string Gender {get; set;}
    [DataType(DataType.Date)]
    public DateTime CitizenshipRegisterDate {get; set;}
}