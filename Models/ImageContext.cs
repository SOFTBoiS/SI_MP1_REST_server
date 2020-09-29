﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MP1_Rest_Client.Models
{
    public class ImageContext : DbContext
{
    public ImageContext(DbContextOptions<ImageContext> options)
        : base(options)
    {
    }

    public DbSet<Image> Images { get; set; }
}
}