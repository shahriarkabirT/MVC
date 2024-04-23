using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class CustomerViewModel
{

    public List<Customer>? Id { get; set; }
    public SelectList? Name { get; set; }
    public string? CustomerGenre { get; set; }
    public string? SearchString { get; set; }
}
