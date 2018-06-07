using BibliotecaMaf.Controles.BloqueoAplicacion;

namespace TestBloqueoSowart
{
	partial class TestDesBloqueo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.desbloqueoSowart1 = new BibliotecaMaf.Controles.BloqueoAplicacion.DesbloqueoSowart();
            this.SuspendLayout();
            // 
            // desbloqueoSowart1
            // 
            this.desbloqueoSowart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desbloqueoSowart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desbloqueoSowart1.Location = new System.Drawing.Point(12, 12);
            this.desbloqueoSowart1.Name = "desbloqueoSowart1";
            this.desbloqueoSowart1.Size = new System.Drawing.Size(645, 383);
            this.desbloqueoSowart1.TabIndex = 0;
            // 
            // TestDesBloqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 407);
            this.Controls.Add(this.desbloqueoSowart1);
            this.MinimumSize = new System.Drawing.Size(685, 446);
            this.Name = "TestDesBloqueo";
            this.Text = "Reinicio";
            this.ResumeLayout(false);

		}

		#endregion

		private DesbloqueoSowart desbloqueoSowart1;


	}
}