using BibliotecaMaf.Controles.BloqueoAplicacion;

namespace TestBloqueoSowart
{
	partial class TestBloqueo
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
			this.label1 = new System.Windows.Forms.Label();
			this.bloqueo1 = new BibliotecaMaf.Controles.BloqueoAplicacion.Bloqueo();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 217);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 55);
			this.label1.TabIndex = 1;
			this.label1.Text = "Desbloqueado";
			// 
			// bloqueo1
			// 
			this.bloqueo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bloqueo1.Location = new System.Drawing.Point(12, 12);
			this.bloqueo1.MaximumSize = new System.Drawing.Size(900, 900);
			this.bloqueo1.MinimumSize = new System.Drawing.Size(425, 481);
			this.bloqueo1.Name = "bloqueo1";
			this.bloqueo1.Size = new System.Drawing.Size(425, 549);
			this.bloqueo1.TabIndex = 2;
			this.bloqueo1.UsarClaveEnPendrive = true;
			this.bloqueo1.Reinicio += new BibliotecaMaf.Controles.BloqueoAplicacion.Bloqueo.BloqueoEventHandler(this.bloqueo1_Reiniciar);
			this.bloqueo1.DesBloqueado += new BibliotecaMaf.Controles.BloqueoAplicacion.Bloqueo.BloqueoEventHandler(this.bloqueo1_DesBloqueado);
			// 
			// TestBloqueo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 574);
			this.Controls.Add(this.bloqueo1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TestBloqueo";
			this.Text = "Bloqueo";
			this.Load += new System.EventHandler(this.Bloqueo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Bloqueo bloqueo1;


	}
}