using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Options;
using smmsmsmmss.Models;

public class Application
{
    public void Run()
    {
        using (var dbContext = new NorthwindContext())
        {
            foreach (var user in dbContext.Customers.Where(u => u.ContactName.StartsWith("A")).OrderBy(u => u.City))
            {
                Console.WriteLine($"{user.CustomerId}: {user.City} - {user.ContactName} -- {user.Country}");
            }


        }
    }
}