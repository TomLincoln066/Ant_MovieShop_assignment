using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace ApplicationCore.Entities
{
    [Table("Genre")]
    public class Genre
    {

            public int Id { get; set; }

            [MaxLength(64)]
            public string Name { get; set; }

        
    }


}

