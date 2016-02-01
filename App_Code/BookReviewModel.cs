﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Author
{
    public Author()
    {
        this.Books = new HashSet<Book>();
    }

    public int AuthorKey { get; set; }
    public string AuthorName { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}

public partial class Book
{
    public Book()
    {
        this.Authors = new HashSet<Author>();
    }

    public int BookKey { get; set; }
    public string BookTitle { get; set; }
    public System.DateTime BookEntryDate { get; set; }
    public string BookISBN { get; set; }

    public virtual ICollection<Author> Authors { get; set; }
}
