using System;
using System.Windows.Forms;


namespace BibliotecaMaf.Controles.BloqueoAplicacion
{

	public partial class DesbloqueoSowart : UserControl
	{
		private void ButtonPegar_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text = Clipboard.GetText();
		}

		private void ButtonCopiar_Click(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrEmpty(TextBox2.Text))
			{
				Clipboard.SetText(TextBox2.Text);
			}
		}

		private void ButtonGuardar_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog1.AddExtension = true;
			SaveFileDialog1.DefaultExt = "regkey";
			SaveFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey";
			SaveFileDialog1.FilterIndex = 0;
			SaveFileDialog1.FileName = "CodigoSowart";
			SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			SaveFileDialog1.Title = "Guardar Clave";
			if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox2.Text);
			}
		}

		private void ButtonAbrir_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog1.AddExtension = true;
			OpenFileDialog1.DefaultExt = "regkey";
			OpenFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey";
			OpenFileDialog1.FilterIndex = 0;
			OpenFileDialog1.FileName = "Sowart Envio";
			OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			OpenFileDialog1.Multiselect = false;
			OpenFileDialog1.Title = "Abrir Clave";
			if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				TextBox1.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName);
			}
		}

		private void ButtonVerificar_Click(object sender, System.EventArgs e)
		{
			try
			{
				TextBox3.Text = Rutinas_Generales.Encrypt_Decrypt(TextBox1.Text, Rutinas_Generales.Clave1, Rutinas_Generales.Iniciador1, false);
				string Resultado = "";
				Resultado = TextBox3.Text.Substring(0, TextBox3.Text.IndexOf("\r\n"));
				TextBox2.Text = Rutinas_Generales.Encrypt_Decrypt(Resultado, Rutinas_Generales.Clave2, Rutinas_Generales.Iniciador2, true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public DesbloqueoSowart()
		{
			InitializeComponent();
		}
	}


}
