using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using ADOX;

namespace xml_json_to_accdb
{
	public partial class Converter : Form
    {
		private BindingSource currentBindingSource;
		public Converter()
        {
            InitializeComponent();
        }

		public void SetCurrentTable(string tableName)
		{
			switch (tableName)
			{
				case "Provider":
                case "ProviderTable":
					currentBindingSource = providerBindingSource;
					break;
				case "Income":
				case "IncomeTable":
					currentBindingSource = incomeBindingSource;
					break;
				case "Product":
				case "ProductTable":
					currentBindingSource = productBindingSource;
					break;
			}
		}

		private void buttonReadXML_Click(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader("Table.xml");
            textBox1.Text = sw.ReadLine();
            sw.Close();
        }

		private void buttonReadJSON_Click(object sender, EventArgs e)
		{
			StreamReader sw = new StreamReader("Table.json");
			textBox1.Text = sw.ReadLine();
			sw.Close();
		}

		private void buttonXMLtoGrid_Click(object sender, EventArgs e)
        {
			XmlDocument xml = new XmlDocument();
            xml.Load("Table.xml");
            if (xml.DocumentElement != null)
            {
				testDBDataSet.Clear();
                SetCurrentTable(xml.DocumentElement.Name);
				foreach (XmlNode node in xml.DocumentElement)
                {
					currentBindingSource.AddNew();
					DataRowView rowView = (DataRowView)currentBindingSource.Current;
					int i = 0;
					foreach (XmlElement element in node.ChildNodes)
                    {
                        rowView[i] = element.InnerText;
                        if (++i == rowView.Row.Table.Columns.Count)
                            break;
					}
                }
				currentBindingSource.EndEdit();
				dataGridView1.DataSource = currentBindingSource;
			}
        }

        private void buttonJSONtoGrid_Click(object sender, EventArgs e)
        {
            testDBDataSet.Clear();
            char[] charsToTrim = { '\'', ' ', ',', '{' };
			StreamReader sr = new StreamReader("Table.json");
			string json = sr.ReadLine();
			sr.Close();
            int start = json.IndexOf('\"');
            SetCurrentTable(json.Substring(start + 1, json.IndexOf(':') - start - 2));
			start = json.IndexOf('[');
			json = json.Substring(start + 1, json.IndexOf(']') - start - 1);
			string[] rows = json.Split('}');
			for (int i = 0; i < rows.Length - 1; i++)
			{
				string[] cells = rows[i].Trim(charsToTrim).Split(',');
				currentBindingSource.AddNew();
				DataRowView rowView = (DataRowView)currentBindingSource.Current;
				for (int j = 0; j < cells.Length; j++)
				{
					string[] cell = cells[j].Split(':');
					rowView[j] = cell[1].Trim('\"');
				}
			}
			currentBindingSource.EndEdit();
			dataGridView1.DataSource = currentBindingSource;
		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string DBname = "TestDB.accdb";
            OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder
            {
                DataSource = DBname,
                Provider = "Microsoft.ACE.OLEDB.12.0"
            };
            if (File.Exists(DBname))
                File.Delete(DBname);
            Catalog catalog = new Catalog();
            catalog.Create(builder.ConnectionString);
            catalog.ActiveConnection.Close();
            catalog = null;
            using (OleDbConnection Connection = new OleDbConnection(builder.ConnectionString))
            using (OleDbCommand command = new OleDbCommand(@"CREATE TABLE Поставщик (
                                                                [id] AUTOINCREMENT PRIMARY KEY, 
                                                                [Название] VARCHAR(255) NOT NULL)", Connection))
            {
                Connection.Open();
				command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Поставщик ([id], [Название]) VALUES (@id, @Название)";
				command.Parameters.Add("@id", OleDbType.Integer);
				command.Parameters.Add("@Название", OleDbType.VarChar);
				foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    command.Parameters["@id"].Value = row.Cells[0].Value;
					command.Parameters["@Название"].Value = row.Cells[1].Value;
					command.ExecuteNonQuery();
                }
                DataTable result = new DataTable();
                command.CommandText = "SELECT * FROM Поставщик";
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(result);
                dataGridView1.DataSource = result;
                Connection.Close();
            }
        }
	}
 }