using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioPlayer.DataAccess
{
	public class PsiPlayerDbContext : DbContext
	{
		public DbSet<AudioFile> Songs { get; set; }
	}

}
