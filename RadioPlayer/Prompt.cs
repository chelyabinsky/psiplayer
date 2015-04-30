using System.Drawing;
using System.Windows.Forms;

namespace RadioPlayer
{
    public static class Prompt
    {
        public static string[] ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 400;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label { Size = new Size(200, 15), Left = 10, Top = 20, Text = text };
            TextBox textBox = new TextBox { Left = 10, Top = 50, Width = 200 };
            TextBox textBox2 = new TextBox { Left = 10, Top = 100, Width = 200 };
            textBox2.UseSystemPasswordChar = true;
            Button confirmation = new Button { Text = "Ok", Left = 10, Width = 50, Top = 130 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            string[] value = { textBox.Text, textBox2.Text };
            return value;
        }

		public static string[] ShowDialog(string text, string caption, string text2)
		{
			Form prompt = new Form();
			prompt.Width = 400;
			prompt.Height = 400;
			prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
			prompt.Text = caption;
			prompt.StartPosition = FormStartPosition.CenterScreen;
			Label textLabel = new Label { Size = new Size(200, 15), Left = 10, Top = 20, Text = text };
			Label textLabel2 = new Label { Size = new Size(200, 15), Left = 10, Top = 80, Text = text2 };
			TextBox textBox = new TextBox { Left = 10, Top = 50, Width = 200 };
			TextBox textBox2 = new TextBox { Left = 10, Top = 100, Width = 200 };
			textBox2.UseSystemPasswordChar = true;
			Button confirmation = new Button { Text = "Ok", Left = 10, Width = 50, Top = 130 };
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(textBox2);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.Controls.Add(textLabel2);
			prompt.AcceptButton = confirmation;
			prompt.ShowDialog();
			string[] value = { textBox.Text, textBox2.Text };
			return value;
		}
    }
}
