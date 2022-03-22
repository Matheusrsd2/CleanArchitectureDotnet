using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.EntitiesConfiguration
{
    public class CategoryConfiguration //: IEntityTypeConfiguration<Categoria>
    {
        //public void Configure(EntityTypeBuilder<Categoria> builder)
        //{
        //    builder.HasKey(c => c.Id);
        //    builder.Property(c => c.Nome).HasMaxLength(100);    
        //}
    }
}
