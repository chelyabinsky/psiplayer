using RadioPlayer.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioPlayer
{
	public partial class LibraryForm : Form
	{
		public LibraryForm()
		{
			InitializeComponent();
		}

		private void LibraryForm_Load(object sender, EventArgs e)
		{
			LoadData(string.Empty);
		}
		private void LoadData(string filter)
		{
			using (PsiPlayerDbContext context = new PsiPlayerDbContext())
			{
				if (filter == string.Empty)
				{
					dataGridView1.DataSource = context.Songs.ToList();
				}
				else
				{
					dataGridView1.DataSource = context.Songs.Where(x => x.Title.Contains(filter)).ToList();
				}
				
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			LoadData(textBox1.Text);
		}
	}
}
