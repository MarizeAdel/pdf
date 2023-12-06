using System;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PdfPage { get; set; }
    public Admin Admin { get; set; }
    public Person[] people { get; set; }
}
