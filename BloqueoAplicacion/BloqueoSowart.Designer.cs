namespace BibliotecaMaf.Controles.BloqueoAplicacion
{



	partial class Bloqueo
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloqueo));
			this.ButtonAceptar = new System.Windows.Forms.Button();
			this.ButtonAbrir = new System.Windows.Forms.Button();
			this.ButtonGuardar = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ButtonPegar = new System.Windows.Forms.Button();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.ButtonCopiar = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.Label1 = new System.Windows.Forms.Label();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.labelLlave = new System.Windows.Forms.Label();
			this.timerBuscandoLlave = new System.Windows.Forms.Timer(this.components);
			this.timerEspera = new System.Windows.Forms.Timer(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonAceptar
			// 
			this.ButtonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAceptar.Location = new System.Drawing.Point(340, 516);
			this.ButtonAceptar.Name = "ButtonAceptar";
			this.ButtonAceptar.Size = new System.Drawing.Size(75, 30);
			this.ButtonAceptar.TabIndex = 26;
			this.ButtonAceptar.Text = "Aceptar";
			this.ButtonAceptar.UseVisualStyleBackColor = true;
			this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
			// 
			// ButtonAbrir
			// 
			this.ButtonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAbrir.Location = new System.Drawing.Point(242, 451);
			this.ButtonAbrir.Name = "ButtonAbrir";
			this.ButtonAbrir.Size = new System.Drawing.Size(92, 30);
			this.ButtonAbrir.TabIndex = 25;
			this.ButtonAbrir.Text = "Cargar...";
			this.ButtonAbrir.UseVisualStyleBackColor = true;
			this.ButtonAbrir.Click += new System.EventHandler(this.ButtonAbrir_Click);
			// 
			// ButtonGuardar
			// 
			this.ButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonGuardar.Location = new System.Drawing.Point(242, 363);
			this.ButtonGuardar.Name = "ButtonGuardar";
			this.ButtonGuardar.Size = new System.Drawing.Size(92, 30);
			this.ButtonGuardar.TabIndex = 24;
			this.ButtonGuardar.Text = "Guardar...";
			this.ButtonGuardar.UseVisualStyleBackColor = true;
			this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(7, 486);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(299, 59);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 23;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(4, 377);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(156, 20);
			this.Label4.TabIndex = 22;
			this.Label4.Text = "Código de respuesta";
			// 
			// ButtonPegar
			// 
			this.ButtonPegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPegar.Location = new System.Drawing.Point(340, 451);
			this.ButtonPegar.Name = "ButtonPegar";
			this.ButtonPegar.Size = new System.Drawing.Size(75, 30);
			this.ButtonPegar.TabIndex = 21;
			this.ButtonPegar.Text = "Pegar";
			this.ButtonPegar.UseVisualStyleBackColor = true;
			this.ButtonPegar.Click += new System.EventHandler(this.ButtonPegar_Click);
			// 
			// TextBox2
			// 
			this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox2.Location = new System.Drawing.Point(8, 398);
			this.TextBox2.Multiline = true;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(407, 47);
			this.TextBox2.TabIndex = 20;
			// 
			// ButtonCopiar
			// 
			this.ButtonCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCopiar.Location = new System.Drawing.Point(340, 363);
			this.ButtonCopiar.Name = "ButtonCopiar";
			this.ButtonCopiar.Size = new System.Drawing.Size(75, 30);
			this.ButtonCopiar.TabIndex = 19;
			this.ButtonCopiar.Text = "Copiar";
			this.ButtonCopiar.UseVisualStyleBackColor = true;
			this.ButtonCopiar.Click += new System.EventHandler(this.ButtonCopiar_Click);
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(4, 116);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(122, 20);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "Código de envió";
			// 
			// TextBox1
			// 
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox1.Location = new System.Drawing.Point(8, 139);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(407, 218);
			this.TextBox1.TabIndex = 17;
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(5, 46);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(420, 62);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "suminístrele el código de envió citado abajo tal cual esta o cópielo y péguelo en" +
    " un mail, así le podremos suministrar una licencia para su uso.";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LinkLabel1
			// 
			this.LinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LinkLabel1.Location = new System.Drawing.Point(9, 26);
			this.LinkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(406, 20);
			this.LinkLabel1.TabIndex = 15;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "http://www.sowart.com.ar";
			this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(114, 6);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(194, 20);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Póngase en contacto con:";
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			// 
			// labelLlave
			// 
			this.labelLlave.AutoSize = true;
			this.labelLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLlave.ForeColor = System.Drawing.Color.Red;
			this.labelLlave.Location = new System.Drawing.Point(6, 451);
			this.labelLlave.Name = "labelLlave";
			this.labelLlave.Size = new System.Drawing.Size(136, 13);
			this.labelLlave.TabIndex = 27;
			this.labelLlave.Text = "Buscando alguna llave";
			this.labelLlave.Visible = false;
			// 
			// timerBuscandoLlave
			// 
			this.timerBuscandoLlave.Interval = 1000;
			this.timerBuscandoLlave.Tick += new System.EventHandler(this.timerBuscandoLlave_Tick);
			// 
			// timerEspera
			// 
			this.timerEspera.Enabled = true;
			this.timerEspera.Interval = 5000;
			this.timerEspera.Tick += new System.EventHandler(this.timerEspera_Tick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			// 
			// Bloqueo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.labelLlave);
			this.Controls.Add(this.ButtonAceptar);
			this.Controls.Add(this.ButtonAbrir);
			this.Controls.Add(this.ButtonGuardar);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.ButtonPegar);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.ButtonCopiar);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.Label1);
			this.MaximumSize = new System.Drawing.Size(425, 551);
			this.MinimumSize = new System.Drawing.Size(425, 551);
			this.Name = "Bloqueo";
			this.Size = new System.Drawing.Size(423, 549);
			this.Load += new System.EventHandler(this.BloqueoSowart_Load);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button ButtonAceptar;
		internal System.Windows.Forms.Button ButtonAbrir;
		internal System.Windows.Forms.Button ButtonGuardar;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button ButtonPegar;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.Button ButtonCopiar;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
		internal System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Label labelLlave;
		private System.Windows.Forms.Timer timerBuscandoLlave;
		private System.Windows.Forms.Timer timerEspera;
		private System.Windows.Forms.Timer timer1;


	}

}