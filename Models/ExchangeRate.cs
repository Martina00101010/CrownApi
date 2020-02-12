using System;
using System.ComponentModel.DataAnnotations;

public class Currency
{
    [Key]
    [MaxLength(4)]
    public string   Code { get; set; }

    public string   Name { get; set; }

    public string   Country { get; set; }
}

public class Exchange