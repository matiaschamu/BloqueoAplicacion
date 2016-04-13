using System;
using System.Windows.Forms;

namespace TestBloqueoSowart
{
	public partial class TestBloqueo : Form
	{
		public TestBloqueo()
		{
			InitializeComponent();
		}

		private void Bloqueo_Load(object sender, EventArgs e)
		{
			TestDesBloqueo F = new TestDesBloqueo();
			F.Show ( );

			//if (bloqueo1.EstaBloqueado==false)
			//{
				
			//}
		}

		private void bloqueo1_Reiniciar(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bloqueo1_DesBloqueado(object sender, EventArgs e)
		{
bloqueo1.Visible = false;
		}
	}
}
