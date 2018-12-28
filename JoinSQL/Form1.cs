using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace JoinSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyFormBase _base = new MyFormBase();
        public string ValidationMessage = "No se encontró ningún archivo de extensión *.SQL en la ruta especificada";
        public string SucessMessage = "Se ha guardado el archivo en la ruta: {0} .";
        public string FolderEmpty = "Seleccione una ubicación para buscar archivos.";
        public string ConectionSctring = "Data Source={0};Initial Catalog={1};Persist Security Info=True; User={2}; Password={3} ;MultipleActiveResultSets=True;";

        #region Events

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string JoinSQL = Process();
            if (string.IsNullOrEmpty(JoinSQL))
            {
                MessageBox.Show(ValidationMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            rchTxtContent.Text = JoinSQL;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            btnProcess.Enabled = false;
            btnSave.Enabled = false;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string JoinSQL = Process();
            if (string.IsNullOrEmpty(JoinSQL))
            {
                MessageBox.Show(ValidationMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string FileName = saveFileDialog1.FileName;
            File.WriteAllText(FileName, JoinSQL);
            MessageBox.Show(string.Format(SucessMessage, FileName), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // When user clicks button, show the dialog.
            saveFileDialog1.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPathSource.Text = "";
            rchTxtContent.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                string foldername = this.folderBrowserDialog1.SelectedPath;
                txtPathSource.Text = foldername;
                btnProcess.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchFolder.Text))
            {
                MessageBox.Show(FolderEmpty, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var result = (from file in
                              new System.IO.DirectoryInfo(txtSearchFolder.Text).EnumerateFileSystemInfos()
                          where file.Name.ToUpper().Contains(txtSearchNameFilter.Text.ToUpper())
                          select new
                          {
                              Name = file.Name
                          });

            dgvFiles.DataSource = result.ToList();
            dgvFiles.Columns[0].Width = 650;
        }

        private void bntUploadFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                string foldername = this.folderBrowserDialog1.SelectedPath;
                txtSearchFolder.Text = foldername;
                btnProcess.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnFindInsideFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderInFile.Text))
            {
                MessageBox.Show(FolderEmpty, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string files = "";
            var listFiles = (from file in
                                 new System.IO.DirectoryInfo(txtFolderInFile.Text).EnumerateFileSystemInfos()
                             select new
                             {
                                 Name = file.Name,
                                 FullName = file.FullName,
                                 Extension = file.Extension
                             });


            foreach (var file in listFiles)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line.ToUpper().Contains(txtnametofind.Text.ToUpper()))
                        {
                            files += file.Name + ";";
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(files))
            {
                var query = files.Split(';').Where(x => x != "").Select(x => x.Trim()).Distinct();
                var datasource = (from file in query
                                  select new
                                  {
                                      FullName = file.ToString()
                                  }
                                 );
                dgfilesconsidence.DataSource = datasource.ToList();
                dgfilesconsidence.Columns[0].Width = 650;
            }
            else
            {
                MessageBox.Show("No se encontró coincidencias");
            }
        }

        private void btnSelectFolderInsideFile_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // the code here will be executed if the user presses Open in
                // the dialog.
                string foldername = this.folderBrowserDialog1.SelectedPath;
                txtFolderInFile.Text = foldername;
            }
        }

        private void btnPreviewScript_Click(object sender, EventArgs e)
        {
            string mensaje = "Obteniendo scripts, este proceso puede tardar unos minutos" + Environment.NewLine + "Porfavor espere...";
            _base.ShowWaitForm(mensaje);
            string cn = string.Format(ConectionSctring, txtServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text);
            List<Routines> listRoutines = GetListRoutines(cn);
            string ScriptSQL = "";
            foreach (Routines routine in listRoutines)
            {
                routine.ListDefinitionItem = GetDefinitionObj(cn, routine);
                string ScriptRoutine = "";
                foreach (var definition in routine.ListDefinitionItem)
                {
                    ScriptRoutine += definition.Text;
                }
                ScriptSQL += ScriptRoutine + Environment.NewLine + "GO" + Environment.NewLine;
            }

            richTxtScript.Text = ScriptSQL;
            MessageBox.Show("El proceso ha terminado con éxito");
        }

        #endregion


        #region Methods

        private string Process()
        {
            //string[] filePaths = Directory.GetFiles(@"c:\MyDir\");
            string[] filePaths = Directory.GetFiles(txtPathSource.Text, "*.sql");
            string JoinSQL = "";
            foreach (string file in filePaths)
            {
                string contents = File.ReadAllText(file, Encoding.Default);
                // Create a file to write to. 
                string createText = Environment.NewLine + "GO" + Environment.NewLine;
                createText += contents;

                JoinSQL += createText;
            }
            return JoinSQL;
        }

        public List<Routines> GetListRoutines(string cadenaconexion)
        {
            List<Routines> RoutineList = new List<Routines>();

            DALSQLNative bd = new DALSQLNative(cadenaconexion);
            StringBuilder _SQL = new StringBuilder();
            _SQL.Append(" select ROUTINE_TYPE, 	");
            _SQL.Append(" ROUTINE_SCHEMA+'.'+ROUTINE_NAME ROUTINE_NAME, 	");
            _SQL.Append(" ROUTINE_DEFINITION 	");
            _SQL.Append(" from information_schema.routines");

            try
            {
                bd.conectar();
                using (SqlCommand _comando = bd.crearComandoText(_SQL.ToString()))
                {
                    using (System.Data.SqlClient.SqlDataReader reader = _comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Object[] RegistOfSelect = new Object[reader.FieldCount];
                            int IdxROUTINE_TYPE = reader.GetOrdinal("ROUTINE_TYPE");
                            int IdxROUTINE_NAME = reader.GetOrdinal("ROUTINE_NAME");
                            int IdxROUTINE_DEFINITION = reader.GetOrdinal("ROUTINE_DEFINITION");

                            while (reader.Read())
                            {
                                Routines _Routines = new Routines();
                                reader.GetValues(RegistOfSelect);
                                if (!(RegistOfSelect[IdxROUTINE_TYPE] is DBNull))
                                {
                                    _Routines.Type = RegistOfSelect[IdxROUTINE_TYPE].ToString();
                                }
                                if (!(RegistOfSelect[IdxROUTINE_NAME] is DBNull))
                                {
                                    _Routines.Name = RegistOfSelect[IdxROUTINE_NAME].ToString();
                                }
                                if (!(RegistOfSelect[IdxROUTINE_DEFINITION] is DBNull))
                                {
                                    _Routines.Definition = RegistOfSelect[IdxROUTINE_DEFINITION].ToString();
                                }
                                RoutineList.Add(_Routines);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
            return RoutineList;
        }

        public List<DefitionItem> GetDefinitionObj(string cadenaconexion, Routines routine)
        {
            List<DefitionItem> ListDefinition = new List<DefitionItem>();
            DALSQLNative bd = new DALSQLNative(cadenaconexion);
            StringBuilder _SQL = new StringBuilder();
            _SQL.Append(" EXEC sp_helptext '" + routine.Name + "'; 	");

            try
            {
                bd.conectar();
                using (SqlCommand _comando = bd.crearComandoText(_SQL.ToString()))
                {
                    using (System.Data.SqlClient.SqlDataReader reader = _comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Object[] RegistOfSelect = new Object[reader.FieldCount];
                            int IdxText = reader.GetOrdinal("Text");

                            while (reader.Read())
                            {
                                DefitionItem _Definition = new DefitionItem();
                                reader.GetValues(RegistOfSelect);
                                if (!(RegistOfSelect[IdxText] is DBNull))
                                {
                                    //_Definition.Text = RegistOfSelect[IdxText].ToString().ToUpper().Replace("CREATE PROC", "ALTER PROC");
                                    _Definition.Text = RegistOfSelect[IdxText].ToString();
                                }
                                ListDefinition.Add(_Definition);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
            return ListDefinition;
        }

        #endregion

    }
}
