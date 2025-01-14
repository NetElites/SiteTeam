﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NetElites.Domain.Model;
using NetElites.Domain.Model.Articles;
using NetElites.Domain.Model.Members;
using NetElites.Domain.Model.Users;
using NetElites.Domain.Model.Worksamples;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetElitres.Application.Repository
{
    public interface IApplicationDbContext
    {
        public DbSet<Token> tokens { set; get; }
        public DbSet<SmsCode> smsCodes { set; get; }
        public DbSet<Article> articles { set; get; }
        public DbSet<Comment> comments { set; get; }
        public DbSet<Seo> seos { set; get; }
        public DbSet<Member> members { set; get; }
        public DbSet<Worksample> worksamples { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        EntityEntry Entry([NotNullAttribute] object entity);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
