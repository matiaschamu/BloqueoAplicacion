namespace BibliotecaMaf.Controles.BloqueoAplicacion
{



	partial class DesbloqueoSowart
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonVerificar = new System.Windows.Forms.Button();
			this.ButtonGuardar = new System.Windows.Forms.Button();
			this.ButtonAbrir = new System.Windows.Forms.Button();
			this.ButtonCopiar = new System.Windows.Forms.Button();
			this.ButtonPegar = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// ButtonVerificar
			// 
			this.ButtonVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ButtonVerificar.Location = new System.Drawing.Point(534, 257);
			this.ButtonVerificar.Name = "ButtonVerificar";
			this.ButtonVerificar.Size = new System.Drawing.Size(89, 26);
			this.ButtonVerificar.TabIndex = 21;
			this.ButtonVerificar.Text = "Verificar";
			this.ButtonVerificar.UseVisualStyleBackColor = true;
			this.ButtonVerificar.Click += new System.EventHandler(this.ButtonVerificar_Click);
			// 
			// ButtonGuardar
			// 
			this.ButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ButtonGuardar.Location = new System.Drawing.Point(199, 257);
			this.ButtonGuardar.Name = "ButtonGuardar";
			this.ButtonGuardar.Size = new System.Drawing.Size(89, 26);
			this.ButtonGuardar.TabIndex = 20;
			this.ButtonGuardar.Text = "Guardar...";
			this.ButtonGuardar.UseVisualStyleBackColor = true;
			this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
			// 
			// ButtonAbrir
			// 
			this.ButtonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ButtonAbrir.Location = new System.Drawing.Point(199, 170);
			this.ButtonAbrir.Name = "ButtonAbrir";
			this.ButtonAbrir.Size = new System.Drawing.Size(89, 26);
			this.ButtonAbrir.TabIndex = 19;
			this.ButtonAbrir.Text = "Abrir...";
			this.ButtonAbrir.UseVisualStyleBackColor = true;
			this.ButtonAbrir.Click += new System.EventHandler(this.ButtonAbrir_Click);
			// 
			// ButtonCopiar
			// 
			this.ButtonCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ButtonCopiar.Location = new System.Drawing.Point(294, 257);
			this.ButtonCopiar.Name = "ButtonCopiar";
			this.ButtonCopiar.Size = new System.Drawing.Size(89, 26);
			this.ButtonCopiar.TabIndex = 18;
			this.ButtonCopiar.Text = "Copiar";
			this.ButtonCopiar.UseVisualStyleBackColor = true;
			this.ButtonCopiar.Click += new System.EventHandler(this.ButtonCopiar_Click);
			// 
			// ButtonPegar
			// 
			this.ButtonPegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.ButtonPegar.Location = new System.Drawing.Point(294, 170);
			this.ButtonPegar.Name = "ButtonPegar";
			this.ButtonPegar.Size = new System.Drawing.Size(89, 26);
			this.ButtonPegar.TabIndex = 17;
			this.ButtonPegar.Text = "Pegar";
			this.ButtonPegar.UseVisualStyleBackColor = true;
			this.ButtonPegar.Click += new System.EventHandler(this.ButtonPegar_Click);
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Label3.Location = new System.Drawing.Point(450, 2);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(132, 16);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Valor Desencriptado";
			// 
			// TextBox3
			// 
			this.TextBox3.Location = new System.Drawing.Point(389, 18);
			this.TextBox3.Multiline = true;
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBox3.Size = new System.Drawing.Size(234, 233);
			this.TextBox3.TabIndex = 15;
			this.TextBox3.WordWrap = false;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Label2.Location = new System.Drawing.Point(3, 183);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(147, 16);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Codigo de desbloqueo";
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(6, 199);
			this.TextBox2.Multiline = true;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(377, 52);
			this.TextBox2.TabIndex = 13;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Label1.Location = new System.Drawing.Point(3, 2);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(233, 16);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Codigo suministrado por la aplicacion";
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(6, 18);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(377, 146);
			this.TextBox1.TabIndex = 11;
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			// 
			// DesbloqueoSowart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.ButtonVerificar);
			this.Controls.Add(this.ButtonGuardar);
			this.Controls.Add(this.ButtonAbrir);
			this.Controls.Add(this.ButtonCopiar);
			this.Controls.Add(this.ButtonPegar);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.MaximumSize = new System.Drawing.Size(631, 288);
			this.MinimumSize = new System.Drawing.Size(631, 288);
			this.Name = "DesbloqueoSowart";
			this.Size = new System.Drawing.Size(629, 286);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button ButtonVerificar;
		internal System.Windows.Forms.Button ButtonGuardar;
		internal System.Windows.Forms.Button ButtonAbrir;
		internal System.Windows.Forms.Button ButtonCopiar;
		internal System.Windows.Forms.Button ButtonPegar;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
	}

}