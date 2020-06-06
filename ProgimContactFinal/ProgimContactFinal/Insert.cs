using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProgimContactFinal
{
    public partial class Insert : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\users\asus-i3\documents\visual studio 2017\Projects\ProgimContactFinal\ProgimContactFinal\rubrica.mdb");
        
        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'appData.tbl_contatti'. È possibile spostarla o rimuoverla se necessario.
            this.tbl_contattiTableAdapter.Fill(this.appData.tbl_contatti);
            // TODO: questa riga di codice carica i dati nella tabella 'appData.tbl_societa'. È possibile spostarla o rimuoverla se necessario.
            this.tbl_societaTableAdapter.FillBysocieta(this.appData.tbl_societa);


            // inserimento della lista delle societa nella combobox
         /*   try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                String query = "Select * from tbl_societa";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboSocieta.Items.Add(reader["societa"]);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }

        //NEW SOCIETA
        private void BtnNewSoc_Click(object sender, EventArgs e)
        {
            try
            {
                panelSocieta.Enabled = true;
                txtRag_soc.Focus();              
                this.appData.tbl_societa.Addtbl_societaRow(this.appData.tbl_societa.Newtbl_societaRow());
                tblsocietaBindingSource.MoveLast();                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblcontattiBindingSource.ResetBindings(false);
            }
        }

        //NEW CONTACT
        private void BtnNewCont_Click(object sender, EventArgs e)
        {          
            try
            {
                panelcontatti.Enabled = true;
                comboSocieta.Focus();
                this.appData.tbl_contatti.Addtbl_contattiRow(this.appData.tbl_contatti.Newtbl_contattiRow());
                tblcontattiBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblcontattiBindingSource.ResetBindings(false);
            }
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            try
            {               
                this.Validate();
                tblcontattiBindingSource.EndEdit();
                tbl_contattiTableAdapter.Update(this.appData.tbl_contatti);
                panelcontatti.Enabled = false;
                MessageBox.Show("Salvataggio Riuscito !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " NOT DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblcontattiBindingSource.ResetBindings(false);
            }
        }

        private void btnSavesocieta_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                tblsocietaBindingSource.EndEdit();
                tbl_societaTableAdapter.Update(this.appData.tbl_societa);
                panelSocieta.Enabled = false;
                MessageBox.Show("Salvataggio Riuscito !!");
                this.tbl_contattiTableAdapter.Fill(this.appData.tbl_contatti);
                this.tbl_societaTableAdapter.Fill(this.appData.tbl_societa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblsocietaBindingSource.ResetBindings(false);
            }
        }


        //Cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            panelcontatti.Enabled = false;
            panelSocieta.Enabled = false;
            tblcontattiBindingSource.ResetBindings(false);
            tblsocietaBindingSource.ResetBindings(false);
        }
    }
}
