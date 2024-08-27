using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.models

{
    internal class PasswordManagerContext : DbContext
    {
        //Registar os modelos em nosso DbContext, ou seja, na nossa Base de Dados.

        public DbSet<Account> accounts { get; set; }
        public DbSet<Site> sites { get; set; }
        public DbSet<SiteDetail> sitesDetails { get; set; }
    }
}
