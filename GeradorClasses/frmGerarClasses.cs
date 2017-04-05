//------------------------------------------------------------------------
// Author      : Clint Steele
// Version     : 1.0
// Description : Aplicação que a partir de um banco de dados Access
//               Gera um arquivo de classe para cada tabela
//------------------------------------------------------------------------
using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;
using Npgsql;

namespace Macoratti
{
    /// <summary>
    /// descrição do form
    /// </summary>
    public class frmGeradorClasses : System.Windows.Forms.Form
    {
        //Variavel para a string de conexão do banco de dados selecionado
        
        private string AccessConnString = "";

        private NpgsqlConnection Conn = new NpgsqlConnection();
        //
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatabaseLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FindDatabaseDialog;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.ColumnHeader Tables;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader FieldName;
        private System.Windows.Forms.ColumnHeader FieldType;
        private System.Windows.Forms.ListView lvFields;
        private System.Windows.Forms.Button btnGerarClasses;
        private Label label3;
        private Button btnLerArquivos;
        private Button btnSair;
        private TextBox txtSchema;
        private Label label4;
        private string schema = "public";
        private TextBox txtConnectionString;
        private TextBox txtUsingsClasse;
        private Label label5;
        private TextBox txtUsingsMapper;
        private Label label6;
        private CheckBox chkMapper;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmGeradorClasses()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpa os recursos utilizados
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.lblDatabaseLocation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindDatabaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.Tables = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTables = new System.Windows.Forms.ListView();
            this.FieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFields = new System.Windows.Forms.ListView();
            this.btnGerarClasses = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLerArquivos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtUsingsClasse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsingsMapper = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkMapper = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatabaseLocation
            // 
            this.lblDatabaseLocation.Location = new System.Drawing.Point(153, 58);
            this.lblDatabaseLocation.Name = "lblDatabaseLocation";
            this.lblDatabaseLocation.Size = new System.Drawing.Size(511, 32);
            this.lblDatabaseLocation.TabIndex = 3;
            this.lblDatabaseLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local do Banco de dados :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionString.ForeColor = System.Drawing.Color.Black;
            this.lblConnectionString.Location = new System.Drawing.Point(120, 16);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(525, 42);
            this.lblConnectionString.TabIndex = 5;
            this.lblConnectionString.Click += new System.EventHandler(this.lblConnectionString_Click);
            // 
            // Tables
            // 
            this.Tables.Text = "Tables";
            this.Tables.Width = 117;
            // 
            // lvTables
            // 
            this.lvTables.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tables});
            this.lvTables.Location = new System.Drawing.Point(16, 104);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(183, 393);
            this.lvTables.TabIndex = 6;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            // 
            // FieldName
            // 
            this.FieldName.Text = "Field Name";
            this.FieldName.Width = 148;
            // 
            // FieldType
            // 
            this.FieldType.Text = "FieldType";
            this.FieldType.Width = 63;
            // 
            // lvFields
            // 
            this.lvFields.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldName,
            this.FieldType});
            this.lvFields.Location = new System.Drawing.Point(220, 104);
            this.lvFields.Name = "lvFields";
            this.lvFields.Size = new System.Drawing.Size(321, 393);
            this.lvFields.TabIndex = 7;
            this.lvFields.UseCompatibleStateImageBehavior = false;
            this.lvFields.View = System.Windows.Forms.View.Details;
            // 
            // btnGerarClasses
            // 
            this.btnGerarClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerarClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarClasses.Location = new System.Drawing.Point(842, 447);
            this.btnGerarClasses.Name = "btnGerarClasses";
            this.btnGerarClasses.Size = new System.Drawing.Size(140, 53);
            this.btnGerarClasses.TabIndex = 8;
            this.btnGerarClasses.Text = "Gerar Classes";
            this.btnGerarClasses.UseVisualStyleBackColor = false;
            this.btnGerarClasses.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(573, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Os arquivos de classe serão gerados na pasta bin";
            // 
            // btnLerArquivos
            // 
            this.btnLerArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLerArquivos.Location = new System.Drawing.Point(713, 447);
            this.btnLerArquivos.Name = "btnLerArquivos";
            this.btnLerArquivos.Size = new System.Drawing.Size(112, 53);
            this.btnLerArquivos.TabIndex = 10;
            this.btnLerArquivos.Text = "Ler Arquivos";
            this.btnLerArquivos.UseVisualStyleBackColor = false;
            this.btnLerArquivos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Location = new System.Drawing.Point(573, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 50);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(573, 114);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(112, 20);
            this.txtSchema.TabIndex = 12;
            this.txtSchema.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Schema";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(13, 37);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(672, 20);
            this.txtConnectionString.TabIndex = 14;
            // 
            // txtUsingsClasse
            // 
            this.txtUsingsClasse.Location = new System.Drawing.Point(573, 164);
            this.txtUsingsClasse.Multiline = true;
            this.txtUsingsClasse.Name = "txtUsingsClasse";
            this.txtUsingsClasse.Size = new System.Drawing.Size(232, 232);
            this.txtUsingsClasse.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Usings Classes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUsingsMapper
            // 
            this.txtUsingsMapper.Location = new System.Drawing.Point(831, 164);
            this.txtUsingsMapper.Multiline = true;
            this.txtUsingsMapper.Name = "txtUsingsMapper";
            this.txtUsingsMapper.Size = new System.Drawing.Size(232, 232);
            this.txtUsingsMapper.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Usings Mapper";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkMapper
            // 
            this.chkMapper.AutoSize = true;
            this.chkMapper.Checked = true;
            this.chkMapper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMapper.Location = new System.Drawing.Point(713, 116);
            this.chkMapper.Name = "chkMapper";
            this.chkMapper.Size = new System.Drawing.Size(86, 17);
            this.chkMapper.TabIndex = 19;
            this.chkMapper.Text = "Criar Mapper";
            this.chkMapper.UseVisualStyleBackColor = true;
            this.chkMapper.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmGeradorClasses
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 532);
            this.Controls.Add(this.chkMapper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsingsMapper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsingsClasse);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSchema);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLerArquivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGerarClasses);
            this.Controls.Add(this.lvFields);
            this.Controls.Add(this.lvTables);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDatabaseLocation);
            this.Controls.Add(this.label1);
            this.Name = "frmGeradorClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Classes de Classe Gerados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmGeradorClasses());
        }

        //Abri conexão com o banco de dados
        private void OpenConn(string ConnStr)
        {
            Conn.ConnectionString = ConnStr;
            Conn.Open();
        }
        //Fecha a conexão com o banco de dados
        private void CloseConn()
        {
            Conn.Close();
        }
        /// <summary>
        /// Envia o nome da tabela e a HashTable com a coluna de dados
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="htColumns"></param>
        private void CriarArquivo(string TableName, Hashtable htColumns)
        {

            //define um string builder
            StringBuilder sb = new StringBuilder();
            //define a declaração using
            sb.Append("using System;" + "\r\n");
            sb.Append("using System.Data;" + "\r\n");
            sb.Append(txtUsingsClasse.Text);
            //inclui espaço extra
            sb.Append("" + "\r\n");
            //define o namespace
            sb.Append("namespace Prismatec" + "\r\n");
            sb.Append("{" + "\r\n");
            //identifica a classe
            sb.Append("\t" + "/// <summary>" + "\r\n");
            sb.Append("\t" + "/// Classe gerada para a tabela : " + TableName + "." + "\r\n");
            sb.Append("\t" + "/// </summary>" + "\r\n");
            //inicia com o nome da classe
            sb.Append("\t" + "public class " + ToCamelCase(TableName) + "" + "\r\n");
            sb.Append("\t" + "{" + "\r\n");
            //define a conexao
            //inicia o construtor
            sb.Append("\t" + "\t" + "public " + ToCamelCase(TableName) + "()" + "\r\n");
            sb.Append("\t" + "\t" + "{" + "\r\n");
            sb.Append("\t" + "\t" + "\t" + "//" + "\r\n");
            sb.Append("\t" + "\t" + "\t" + "// TODO: Logica do construtor" + "\r\n");
            sb.Append("\t" + "\t" + "\t" + "//" + "\r\n");
            sb.Append("\t" + "\t" + "}" + "\r\n");
            //define variaveis publicas
            foreach (string key in htColumns.Keys)
            {
                sb.Append("\t" + "\t" + "public " + htColumns[key].ToString() + " " + ToCamelCase(key.ToString()) + "" + " { get; set;} \n");
            }

            sb.Append("\t" + "}" + "\r\n");
            sb.Append("}");
            //cria o arquivo com o nome : nomeDaTabela.cs
            EscreverArquivo(ToCamelCase(TableName), sb.ToString());
            if (chkMapper.Checked)
                EscreverArquivo(ToCamelCase(TableName) + "Mapper", CriaMapper(TableName, htColumns), true);                        
        }


        public string CriaMapper(string TableName, Hashtable htColumns)
        {

            var classCamel = ToCamelCase(TableName);
            StringBuilder sb = new StringBuilder();
            sb.Append("using DapperExtensions.Mapper; \r\n");
            sb.Append(txtUsingsMapper.Text);
            sb.Append("namespace Prismatec{" + "\r\n");
            sb.AppendFormat("\t" + "public class {0}Mapper : ClassMapper<{0}>" + "\r\n", classCamel);
            sb.Append("\t" + "{" + "\r\n");

            sb.Append("\t" + "\t" + "public " + classCamel + "Mapper()" + "\r\n");
            sb.Append("\t" + "\t" + "{" + "\r\n");
            sb.Append("\t" + "\t" + "\t" + "//" + "\r\n");
            sb.AppendFormat("\t" + "\t" + "\t" + "Schema(\"{0}\");" + "\r\n", schema);
            sb.AppendFormat("\t" + "\t" + "\t" + "Table(\"{0}\");" + "\r\n", TableName);
            var first = true;
            foreach (string key in htColumns.Keys)
            {
                if (first && key.ToLower().Contains("id"))
                {
                    first = false;
                    sb.AppendFormat("\t" + "\t" + "Map(prop => prop.{0}).Column(\"{1}\").Key(KeyType.Identity);" + "  \n", ToCamelCase(key), key);
                }
                else
                {
                    sb.AppendFormat("\t" + "\t" + "Map(prop => prop.{0}).Column(\"{1}\");" + "  \n", ToCamelCase(key), key);
                }

            }
            sb.Append("\t" + "\t" + "\t" + "//" + "\r\n");

            //fecha classe e namespace
            sb.Append("\t" + "\t" + "}" + "\r\n");
            sb.Append("\t" + "}" + "\r\n");

            sb.Append("}");

            return sb.ToString();
        }



        public string ToCamelCase(string valor)
        {
            var spl = valor.Split('_').ToList().Select(ToSingular);
            var camelcase = spl.Aggregate("",
                (current, s) => current + (s[0].ToString().ToUpper() + s.Substring(1, s.Length - 1)));
            return camelcase;
        }

        public string ToSingular(string texto)
        {
            if (texto.EndsWith("ns"))
                texto = texto.Substring(0, texto.Length - 2) + "m";
            else if (texto.EndsWith("ais"))
                texto = texto.Substring(0, texto.Length - 3) + "al";
            else if (texto.EndsWith("oes"))
                texto = texto.Substring(0, texto.Length - 3) + "ao";
            else if (texto.EndsWith("res"))
                texto = texto.Substring(0, texto.Length - 3);
            else if (texto.EndsWith("s"))
                texto = texto.Substring(0, texto.Length - 1);


            return texto;
        }
        /// <summary>
        /// Função que escreve no código no arquivo
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="str"></param>
        private void EscreverArquivo(string TableName, string str, bool mapper = false)
        {
            var path = mapper
                ? Application.StartupPath + "\\" + schema + "\\mapper"
                : Application.StartupPath + "\\" + schema;
            Directory.CreateDirectory(path);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path + "\\" + TableName + ".cs", false);
            sw.Write(str);
            sw.Close();
            sw = null;
        }

        /// <summary>
        /// Função que verifica o tipo de dados e retorna um string com o seu tipo
        /// </summary>
        /// <param name="parm1"></param>
        /// <returns></returns>
        private string fieldtypename(string parm1)
        {
            string fieldtypename;
            switch (parm1)
            {
                case "int4":
                    fieldtypename = "int";
                    break;
                case "int8":
                    fieldtypename = "Int64";
                    break;
                case "bool":
                case "boolean":
                    fieldtypename = "bool";
                    break;
                case "date":
                case "timestamp":
                case "timestamp with time zone":
                case "timestamp without time zone":
                    fieldtypename = "DateTime";
                    break;
                case "timestamptz":
                    fieldtypename = "DateTime?";
                    break;
                case "time":
                case "time with time zone":
                case "time without time zone":
                case "interval":
                    fieldtypename = "TimeSpan";
                    break;
                case "char":
                case "varchar":
                case "text":
                case "citext":
                case "enum":
                case "bit":
                case "varbit":
                case "cidr":
                case "inet":
                case "macaddr":
                case "point":
                case "line":
                case "lseg":
                case "box":
                case "path":
                case "polygon":
                case "circle":
                case "xml":
                case "character":
                case "character varying":
                case "bit varying":
                case "json":
                case "jsonb":
                case "bpchar":
                    fieldtypename = "string";
                    break;
                case "float8":
                    fieldtypename = "double";
                    break;
                case "uuid2":
                    fieldtypename = "Guid";
                    break;
                case "bytea":
                    fieldtypename = "Byte[]";
                    break;
                case "float4":
                    fieldtypename = "float?";
                    break;
                case "numeric":
                    fieldtypename = "decimal";
                    break;
                default:
                    fieldtypename = "object";
                    break;
            }
            return fieldtypename;
        }
        /// <summary>
        /// gera os arquivos para cada tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGen_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSchema.Text))
                    schema = txtSchema.Text;
                //limpa o listview
                lvTables.Items.Clear();
                lvFields.Items.Clear();
                //abre a conexão com o banco de dados
                OpenConn(AccessConnString + lblDatabaseLocation.Text);
                //Pega o Schema da tabela
                DataTable schemaTable = Conn.GetSchema("Tables", new string[] { null, schema, null, null });
                //percorre a tabelas
                var usings = new StringBuilder();
                foreach (DataRow row in schemaTable.Rows)
                {
                    //define o nome das tabelas
                    string TableName = row["TABLE_NAME"].ToString();
                    //inclui no listview
                    lvTables.Items.Add(TableName);
                    object[] objArrRestrict;
                    //verifica a tabela 
                    objArrRestrict = new object[] { null, null, TableName, null };
                    //Obtem o schema da tabela
                    DataTable dataColumns = Conn.GetSchema("Columns", new string[] { null, schema, row["table_name"].ToString() });
                    //declara uma Hashtable para a coluna de dados
                    Hashtable htCols = new Hashtable();
                    //Lista o schema para a tabela selecionada

                    foreach (DataRow fieldrow in dataColumns.Rows)
                    {
                        //Tipo e nome da coluna
                        string ColumnName = fieldrow["COLUMN_NAME"].ToString();
                        //Tipo de dados é um inteiro para iniciar
                        string DataType = fieldtypename(fieldrow["DATA_TYPE"].ToString());
                        //inclui na lista de campos 
                        ListViewItem LVI = new ListViewItem();
                        LVI.Text = ColumnName;
                        LVI.SubItems.Add(DataType);
                        htCols.Add(ColumnName, DataType);
                        lvFields.Items.Add(LVI);
                    }
                    //Cria o arquivo para esta tabela
                    CriarArquivo(TableName, htCols);
                    usings.Append("typeof("+ToCamelCase(TableName) +"Mapper).Assembly, \n\t");
                }

                EscreverArquivo("typeof",usings.ToString());
                //Fecha a conexão
                CloseConn();
            }
            catch (Exception ex)
            {
                //Se ocorrer algum problema fecha a conexão e exibe o erro
                Conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Seleciona um arquivo de codigo e abre o seu conteudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Filter = "cs files (*.cs)|*.cs|All files (*.*)|*.*";
            dialog.Title = "Selecione um arquivo ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            frmTexto codigo = new frmTexto(filePath);
            codigo.ShowDialog();
        }
        /// <summary>
        /// sai da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Encerrar",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// Seleciona o banco de dados 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncontrarBancoDados_Click_1(object sender, EventArgs e)
        {
            FindDatabaseDialog.ShowDialog();
            lblDatabaseLocation.Text = FindDatabaseDialog.FileName.ToString();
            lblConnectionString.Text = AccessConnString + lblDatabaseLocation.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblConnectionString_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}