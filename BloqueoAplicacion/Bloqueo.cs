using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using BibliotecaMaf.Clases.HardwareData;

namespace BibliotecaMaf.Controles.BloqueoAplicacion
{
    public partial class Bloqueo : UserControl
    {
        public event BloqueoEventHandler Reinicio;
        public event BloqueoEventHandler DesBloqueado;
        public delegate void BloqueoEventHandler(object sender, EventArgs e);

        //[DllImport("kernel32.dll")]
        //public static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SystemInfo lpSystemInfo);

        //[StructLayout(LayoutKind.Sequential)]
        //public struct SystemInfo
        //{
        //	internal ProcessorInfoUnion uProcessorInfo;
        //	public uint dwPageSize;
        //	public IntPtr lpMinimumApplicationAddress;
        //	public IntPtr lpMaximumApplicationAddress;
        //	public IntPtr dwActiveProcessorMask;
        //	public uint dwNumberOfProcessors;
        //	public uint dwProcessorType;
        //	public uint dwAllocationGranularity;
        //	public ushort dwProcessorLevel;
        //	public ushort dwProcessorRevision;
        //}

        //[StructLayout(LayoutKind.Explicit)]
        //public struct ProcessorInfoUnion
        //{
        //	[FieldOffset(0)] internal uint dwOemId;
        //	[FieldOffset(0)] internal ushort wProcessorArchitecture;
        //	[FieldOffset(2)] internal ushort wReserved;
        //}

        private string mTextoCifrado = "";
        private string mInformacion = "";
        private bool mEstaBloqueado = true;

        public Bloqueo()
        {
            InitializeComponent();
        }

        //public bool EstaBloqueado
        //{
        //	get { return mEstaBloqueado; }
        //}

        private bool mUsarClaveEnPendrive = false;
        public bool UsarClaveEnPendrive
        {
            get { return mUsarClaveEnPendrive; }
            set { mUsarClaveEnPendrive = value; }
        }

        public static byte DeCharToByte(char pf)
        {
            return Convert.ToByte(pf);
        }

        public static char DeByteToChar(byte pf)
        {
            return Convert.ToChar(pf);
        }

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sowart.com.ar");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sowart.com.ar");
        }

        private void BloqueoSowart_Load(object sender, System.EventArgs e)
        {
            //string dd = HardwareData.HardwareData.ToString();

            //ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + "Win32_Processor");
            //string mNombreProcesador = "";
            //string mIdProcesador = "";
            //string mBitsProcesador = "";
            //foreach (ManagementBaseObject mManagementBaseObject in searcher.Get())
            //{
            //	mNombreProcesador = mManagementBaseObject.Properties["Name"].Value.ToString();
            //	mIdProcesador = mManagementBaseObject.Properties["ProcessorId"].Value.ToString();
            //	mBitsProcesador = mManagementBaseObject.Properties["DataWidth"].Value.ToString() + " bits";
            //	break;

            //	foreach (PropertyData mPropertyData in mManagementBaseObject.Properties)
            //	{
            //		Console.WriteLine(mPropertyData.Name + " - " + mPropertyData.Value);
            //	}
            //}

            //string mSystemaOperativo = "";
            //string mVersionOS = "";
            //string mNumerodeSerie = "";
            //string mBuild = "";
            //string mPlataforma = "";
            //searcher = new ManagementObjectSearcher("select * from " + "Win32_OperatingSystem");
            //foreach (ManagementBaseObject mManagementBaseObject in searcher.Get())
            //{
            //	mSystemaOperativo = mManagementBaseObject.Properties["Caption"].Value.ToString();
            //	mVersionOS = mManagementBaseObject.Properties["Version"].Value.ToString();
            //	mNumerodeSerie = mManagementBaseObject.Properties["SerialNumber"].Value.ToString();
            //	mBuild = mManagementBaseObject.Properties["BuildNumber"].Value.ToString();
            //	mPlataforma = mManagementBaseObject.Properties["OSArchitecture"].Value.ToString();

            //	foreach (PropertyData mPropertyData in mManagementBaseObject.Properties)
            //	{
            //		Console.WriteLine(mPropertyData.Name + " - " + mPropertyData.Value);
            //	}
            //}

            //SYSTEM_INFO Info = default(SYSTEM_INFO);
            //GetSystemInfo(ref Info);




            ////borrarlo!!!!!!!!!!!!!
            ///////////////////////////////////////////
            //if (DesBloqueado != null)
            //{
            //	DesBloqueado(this, new EventArgs());
            //}
            //return;
            /////////////////////////////////////////////////

            if (TestKey(Application.StartupPath + "\\CodigoSowart.regkey", Rutinas_Generales.Clave2, Rutinas_Generales.Iniciador2) == true)
            {
                if (DesBloqueado != null)
                {
                    mEstaBloqueado = false;
                    timerEspera.Stop();
                    timerBuscandoLlave.Stop();
                    DesBloqueado(this, new EventArgs());
                }
            }
            else
            {
                foreach (var mUnidade in HardwareData.Unidades)
                {
                    if (TestKey(mUnidade.RootDirectory + "SowartKey.regkey", Rutinas_Generales.Clave3, Rutinas_Generales.Iniciador3) == true)
                    {
                        if (DesBloqueado != null)
                        {
                            mEstaBloqueado = false;
                            timerEspera.Stop();
                            timerBuscandoLlave.Stop();
                            DesBloqueado(this, new EventArgs());
                        }
                        return;
                    }
                }
            }

            //if (System.IO.File.Exists(Application.StartupPath + "\\CodigoSowart.regkey"))
            //{
            //    string m_ClaveLocal = "";
            //    m_ClaveLocal = System.IO.File.ReadAllText(Application.StartupPath + "\\CodigoSowart.regkey");
            //    mInformacion = "MicroID: " + HardwareData.Procesadores[0].ProcessorId;
            //    if (m_ClaveLocal == Rutinas_Generales.Encrypt_Decrypt(mInformacion, Rutinas_Generales.Clave2, Rutinas_Generales.Iniciador2, true))
            //    {
            //        mEstaBloqueado = false;
            //    }
            //}

            if (mEstaBloqueado == true)
            {
                mInformacion = "MicroID: " + HardwareData.Procesadores[0].ProcessorId + "\r\n";
                mInformacion = mInformacion + "Procesador: " + HardwareData.Procesadores[0].Name + " - " + HardwareData.Procesadores[0].DataWidth + "\r\n";
                mInformacion = mInformacion + "Pantalla: " + Screen.PrimaryScreen.Bounds.Width + " x " + Screen.PrimaryScreen.Bounds.Height + "\r\n";
                mInformacion = mInformacion + "NombrePC: " + System.Environment.MachineName + "\r\n";
                mInformacion = mInformacion + "Windows: " + HardwareData.SystemaOperativo + " - " + HardwareData.Plataforma + "\r\n";
                mInformacion = mInformacion + "Numero de serie OS: " + HardwareData.NumerodeSerie + "\r\n";
                mInformacion = mInformacion + "Version Windows: " + HardwareData.VersionOs + " Build: " + HardwareData.Build + "\r\n";
                mInformacion = mInformacion + "VersionPrograma: " + Application.ProductVersion + "\r\n";
                mInformacion = mInformacion + "Path Instalacion: " + Application.StartupPath;

                Console.Write(mInformacion);

                mTextoCifrado = Rutinas_Generales.Encrypt_Decrypt(mInformacion, Rutinas_Generales.Clave1, Rutinas_Generales.Iniciador1, true);
                TextBox1.Text = Rutinas_Generales.Encrypt_Decrypt(mInformacion, Rutinas_Generales.Clave1, Rutinas_Generales.Iniciador1, true);
            }

            if (mUsarClaveEnPendrive == true)
            {
                labelLlave.Visible = true;
                timerEspera.Start();
            }
        }

        private bool TestKey(string pathKey, byte[] Clave, byte[] Iniciador)
        {
            if (System.IO.File.Exists(pathKey))
            {
                string mClaveLocal = System.IO.File.ReadAllText(pathKey);
                mInformacion = "MicroID: " + HardwareData.Procesadores[0].ProcessorId;
                if (mClaveLocal == Rutinas_Generales.Encrypt_Decrypt(mInformacion, Clave, Iniciador, true))
                {
                    return true;
                }
            }
            return false;
        }

        private void ButtonAceptar_Click(object sender, System.EventArgs e)
        {
            System.IO.File.WriteAllText(Application.StartupPath + "\\CodigoSowart.regkey", TextBox2.Text);
            MessageBox.Show("La aplicacion se cerrara para registrarse, por favor iniciela nuevamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Reinicio != null)
            {
                Reinicio(this, new EventArgs());
            }
        }

        private void ButtonCopiar_Click(object sender, System.EventArgs e)
        {

            Clipboard.SetText(TextBox1.Text);
        }

        private void ButtonPegar_Click(object sender, System.EventArgs e)
        {
            TextBox2.Text = Clipboard.GetText();
        }

        private void ButtonGuardar_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog1.AddExtension = true;
            SaveFileDialog1.DefaultExt = "regkey";
            SaveFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey";
            SaveFileDialog1.FilterIndex = 0;
            SaveFileDialog1.FileName = "Sowart Envio";
            SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveFileDialog1.Title = "Guardar Clave";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, mTextoCifrado);
            }
        }

        private void ButtonAbrir_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog1.AddExtension = true;
            OpenFileDialog1.DefaultExt = "regkey";
            OpenFileDialog1.Filter = "Archivos de Clave (*.regkey)|*.regkey";
            OpenFileDialog1.FilterIndex = 0;
            OpenFileDialog1.FileName = "CodigoSowart";
            OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.Title = "Abrir Clave";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox2.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName);
            }
        }

        private void timerBuscandoLlave_Tick(object sender, EventArgs e)
        {
            if (labelLlave.Text == "Buscando alguna llave...........")
            {
                labelLlave.Text = "Buscando alguna llave";
            }
            else
            {
                labelLlave.Text = labelLlave.Text + ".";
            }

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                string Dir = d.RootDirectory.Name + "SowartKey.RegKey";

                if (System.IO.File.Exists(Dir))
                {
                    HardwareData.Drive[] D = HardwareData.UnidadesA;

                    for (int i = 0; i < D.Length; i++)
                    {
                        if (d.RootDirectory.Name == D[i].Name)
                        {
                            string SerialPenDrive = HardwareData.UnidadesA[i].SerialNumber;
                        }
                    }

                    if (TestKey(Dir, Rutinas_Generales.Clave3, Rutinas_Generales.Iniciador3) == true)
                    {
                        if (DesBloqueado != null)
                        {
                            mEstaBloqueado = false;
                            timerEspera.Stop();
                            timerBuscandoLlave.Stop();
                            DesBloqueado(this, new EventArgs());
                        }
                        return;
                    }
                }
            }
        }

        private void timerEspera_Tick(object sender, EventArgs e)
        {
            timerEspera.Stop();
            timerBuscandoLlave.Start();
        }
    }
}