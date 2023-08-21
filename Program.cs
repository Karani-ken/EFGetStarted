using EFGetStarted.Actions;
using EFGetStarted.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

ApplicationDbContext applicationDbContext = new ApplicationDbContext();
BlogActions blog = new BlogActions();
blog.addBlog();
blog.getBlogs();


