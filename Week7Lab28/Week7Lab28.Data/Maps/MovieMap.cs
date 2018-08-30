using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Week7Lab28.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week7Lab28.Data.Maps
{
    internal class MovieMap : EntityTypeConfiguration<Movie>
    {
        internal MovieMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title);
            Property(x => x.Category);
            Property(x => x.Description).HasMaxLength(254);
            
        }
    }
}
