namespace ProgimContactFinal
{
    partial class Insert
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label22 = new System.Windows.Forms.Label();
            this.comboRiservatoSoc = new System.Windows.Forms.ComboBox();
            this.tblsocietaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ProgimContactFinal.AppData();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSavesocieta = new System.Windows.Forms.Button();
            this.txtpiva = new System.Windows.Forms.TextBox();
            this.txtsito = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txttelefono2 = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtRag_soc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcellulare = new System.Windows.Forms.TextBox();
            this.tblcontattiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboSocieta = new System.Windows.Forms.ComboBox();
            this.txtemailCont = new System.Windows.Forms.TextBox();
            this.txtfaxcont = new System.Windows.Forms.TextBox();
            this.txttel2cont = new System.Windows.Forms.TextBox();
            this.panelSocieta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttelcon = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.panelcontatti = new System.Windows.Forms.Panel();
            this.tbl_societaTableAdapter = new ProgimContactFinal.AppDataTableAdapters.tbl_societaTableAdapter();
            this.tbl_contattiTableAdapter = new ProgimContactFinal.AppDataTableAdapters.tbl_contattiTableAdapter();
            this.tblsocietatblcontattiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnNewSoc = new System.Windows.Forms.Button();
            this.BtnNewCont = new System.Windows.Forms.Button();
            this.tblsocietatblcontattiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontattiBindingSource)).BeginInit();
            this.panelSocieta.SuspendLayout();
            this.panelcontatti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietatblcontattiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietatblcontattiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(42, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Telefono : ";
            // 
            // comboRiservatoSoc
            // 
            this.comboRiservatoSoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "riservato", true));
            this.comboRiservatoSoc.FormattingEnabled = true;
            this.comboRiservatoSoc.Items.AddRange(new object[] {
            "S",
            "N"});
            this.comboRiservatoSoc.Location = new System.Drawing.Point(175, 376);
            this.comboRiservatoSoc.Name = "comboRiservatoSoc";
            this.comboRiservatoSoc.Size = new System.Drawing.Size(121, 21);
            this.comboRiservatoSoc.TabIndex = 25;
            this.comboRiservatoSoc.Text = "S";
            // 
            // tblsocietaBindingSource
            // 
            this.tblsocietaBindingSource.DataMember = "tbl_societa";
            this.tblsocietaBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Riservato :";
            // 
            // btnSavesocieta
            // 
            this.btnSavesocieta.BackColor = System.Drawing.Color.LightCoral;
            this.btnSavesocieta.Location = new System.Drawing.Point(382, 415);
            this.btnSavesocieta.Name = "btnSavesocieta";
            this.btnSavesocieta.Size = new System.Drawing.Size(100, 30);
            this.btnSavesocieta.TabIndex = 23;
            this.btnSavesocieta.Text = "Save";
            this.btnSavesocieta.UseVisualStyleBackColor = false;
            this.btnSavesocieta.Click += new System.EventHandler(this.btnSavesocieta_Click);
            // 
            // txtpiva
            // 
            this.txtpiva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "p_iva", true));
            this.txtpiva.Location = new System.Drawing.Point(173, 337);
            this.txtpiva.Name = "txtpiva";
            this.txtpiva.Size = new System.Drawing.Size(309, 20);
            this.txtpiva.TabIndex = 22;
            // 
            // txtsito
            // 
            this.txtsito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "url", true));
            this.txtsito.Location = new System.Drawing.Point(173, 311);
            this.txtsito.Name = "txtsito";
            this.txtsito.Size = new System.Drawing.Size(309, 20);
            this.txtsito.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "email", true));
            this.txtemail.Location = new System.Drawing.Point(173, 283);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(309, 20);
            this.txtemail.TabIndex = 20;
            // 
            // txtfax
            // 
            this.txtfax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "fax", true));
            this.txtfax.Location = new System.Drawing.Point(173, 257);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(309, 20);
            this.txtfax.TabIndex = 19;
            // 
            // txttelefono2
            // 
            this.txttelefono2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "telefono2", true));
            this.txttelefono2.Location = new System.Drawing.Point(173, 231);
            this.txttelefono2.Name = "txttelefono2";
            this.txttelefono2.Size = new System.Drawing.Size(309, 20);
            this.txttelefono2.TabIndex = 18;
            // 
            // txttelefono
            // 
            this.txttelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "telefono1", true));
            this.txttelefono.Location = new System.Drawing.Point(173, 205);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(309, 20);
            this.txttelefono.TabIndex = 17;
            // 
            // txtCap
            // 
            this.txtCap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "cap", true));
            this.txtCap.Location = new System.Drawing.Point(173, 179);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(309, 20);
            this.txtCap.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(42, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Fax :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(42, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "Email :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(42, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 31;
            this.label17.Text = "Telefono2 : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(42, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "Nome : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(42, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Cognome : ";
            // 
            // txtProvincia
            // 
            this.txtProvincia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "provincia", true));
            this.txtProvincia.Location = new System.Drawing.Point(173, 153);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(309, 20);
            this.txtProvincia.TabIndex = 15;
            // 
            // txtCittà
            // 
            this.txtCittà.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "citta", true));
            this.txtCittà.Location = new System.Drawing.Point(173, 125);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(309, 20);
            this.txtCittà.TabIndex = 14;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "indirizzo", true));
            this.txtIndirizzo.Location = new System.Drawing.Point(173, 96);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(309, 20);
            this.txtIndirizzo.TabIndex = 13;
            // 
            // txtRag_soc
            // 
            this.txtRag_soc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblsocietaBindingSource, "societa", true));
            this.txtRag_soc.Location = new System.Drawing.Point(173, 69);
            this.txtRag_soc.Name = "txtRag_soc";
            this.txtRag_soc.Size = new System.Drawing.Size(309, 20);
            this.txtRag_soc.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(36, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Fax :";
            // 
            // txtcellulare
            // 
            this.txtcellulare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "cellulare", true));
            this.txtcellulare.Location = new System.Drawing.Point(179, 148);
            this.txtcellulare.Name = "txtcellulare";
            this.txtcellulare.Size = new System.Drawing.Size(309, 20);
            this.txtcellulare.TabIndex = 37;
            // 
            // tblcontattiBindingSource
            // 
            this.tblcontattiBindingSource.DataMember = "tbl_contatti";
            this.tblcontattiBindingSource.DataSource = this.appData;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "nome", true));
            this.txtnome.Location = new System.Drawing.Point(179, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(309, 20);
            this.txtnome.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(42, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 28;
            this.label20.Text = "Cellulare : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(34, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(36, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Sito :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(34, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "P.IVA : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(38, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono2 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(36, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Indirizzo : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(36, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Città : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(36, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Provincia : ";
            // 
            // txtCognome
            // 
            this.txtCognome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "cognome", true));
            this.txtCognome.Location = new System.Drawing.Point(179, 122);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(309, 20);
            this.txtCognome.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(42, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 15);
            this.label23.TabIndex = 25;
            this.label23.Text = "Società : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert Contatto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(36, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cap :";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "riservato", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "S",
            "N"});
            this.comboBox2.Location = new System.Drawing.Point(181, 306);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(67, 21);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.Text = "S";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(42, 309);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 20);
            this.label21.TabIndex = 44;
            this.label21.Text = "Riservato :";
            // 
            // comboSocieta
            // 
            this.comboSocieta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblcontattiBindingSource, "societa_id", true));
            this.comboSocieta.DataSource = this.tblsocietaBindingSource;
            this.comboSocieta.DisplayMember = "societa";
            this.comboSocieta.FormattingEnabled = true;
            this.comboSocieta.Location = new System.Drawing.Point(179, 69);
            this.comboSocieta.Name = "comboSocieta";
            this.comboSocieta.Size = new System.Drawing.Size(309, 21);
            this.comboSocieta.TabIndex = 43;
            this.comboSocieta.ValueMember = "id_societa";
            // 
            // txtemailCont
            // 
            this.txtemailCont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "email", true));
            this.txtemailCont.Location = new System.Drawing.Point(179, 252);
            this.txtemailCont.Name = "txtemailCont";
            this.txtemailCont.Size = new System.Drawing.Size(309, 20);
            this.txtemailCont.TabIndex = 42;
            // 
            // txtfaxcont
            // 
            this.txtfaxcont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "fax", true));
            this.txtfaxcont.Location = new System.Drawing.Point(179, 226);
            this.txtfaxcont.Name = "txtfaxcont";
            this.txtfaxcont.Size = new System.Drawing.Size(309, 20);
            this.txtfaxcont.TabIndex = 41;
            // 
            // txttel2cont
            // 
            this.txttel2cont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "telefono2", true));
            this.txttel2cont.Location = new System.Drawing.Point(179, 200);
            this.txttel2cont.Name = "txttel2cont";
            this.txttel2cont.Size = new System.Drawing.Size(309, 20);
            this.txttel2cont.TabIndex = 40;
            // 
            // panelSocieta
            // 
            this.panelSocieta.BackColor = System.Drawing.Color.Teal;
            this.panelSocieta.Controls.Add(this.comboRiservatoSoc);
            this.panelSocieta.Controls.Add(this.label14);
            this.panelSocieta.Controls.Add(this.btnSavesocieta);
            this.panelSocieta.Controls.Add(this.txtpiva);
            this.panelSocieta.Controls.Add(this.txtsito);
            this.panelSocieta.Controls.Add(this.txtemail);
            this.panelSocieta.Controls.Add(this.txtfax);
            this.panelSocieta.Controls.Add(this.txttelefono2);
            this.panelSocieta.Controls.Add(this.txttelefono);
            this.panelSocieta.Controls.Add(this.txtCap);
            this.panelSocieta.Controls.Add(this.txtProvincia);
            this.panelSocieta.Controls.Add(this.txtCittà);
            this.panelSocieta.Controls.Add(this.txtIndirizzo);
            this.panelSocieta.Controls.Add(this.txtRag_soc);
            this.panelSocieta.Controls.Add(this.label13);
            this.panelSocieta.Controls.Add(this.label12);
            this.panelSocieta.Controls.Add(this.label11);
            this.panelSocieta.Controls.Add(this.label10);
            this.panelSocieta.Controls.Add(this.label9);
            this.panelSocieta.Controls.Add(this.label8);
            this.panelSocieta.Controls.Add(this.label7);
            this.panelSocieta.Controls.Add(this.label6);
            this.panelSocieta.Controls.Add(this.label5);
            this.panelSocieta.Controls.Add(this.label4);
            this.panelSocieta.Controls.Add(this.label3);
            this.panelSocieta.Controls.Add(this.label1);
            this.panelSocieta.Enabled = false;
            this.panelSocieta.Location = new System.Drawing.Point(3, 21);
            this.panelSocieta.Name = "panelSocieta";
            this.panelSocieta.Size = new System.Drawing.Size(563, 460);
            this.panelSocieta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(36, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ragione Sociale : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Società";
            // 
            // txttelcon
            // 
            this.txttelcon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblcontattiBindingSource, "telefono1", true));
            this.txttelcon.Location = new System.Drawing.Point(179, 174);
            this.txttelcon.Name = "txttelcon";
            this.txttelcon.Size = new System.Drawing.Size(309, 20);
            this.txttelcon.TabIndex = 39;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.LightCoral;
            this.btnSaveContact.Location = new System.Drawing.Point(375, 405);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(113, 30);
            this.btnSaveContact.TabIndex = 24;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // panelcontatti
            // 
            this.panelcontatti.BackColor = System.Drawing.Color.SkyBlue;
            this.panelcontatti.Controls.Add(this.comboBox2);
            this.panelcontatti.Controls.Add(this.label21);
            this.panelcontatti.Controls.Add(this.comboSocieta);
            this.panelcontatti.Controls.Add(this.txtemailCont);
            this.panelcontatti.Controls.Add(this.txtfaxcont);
            this.panelcontatti.Controls.Add(this.txttel2cont);
            this.panelcontatti.Controls.Add(this.txttelcon);
            this.panelcontatti.Controls.Add(this.txtcellulare);
            this.panelcontatti.Controls.Add(this.txtCognome);
            this.panelcontatti.Controls.Add(this.txtnome);
            this.panelcontatti.Controls.Add(this.label15);
            this.panelcontatti.Controls.Add(this.label16);
            this.panelcontatti.Controls.Add(this.label17);
            this.panelcontatti.Controls.Add(this.label18);
            this.panelcontatti.Controls.Add(this.label19);
            this.panelcontatti.Controls.Add(this.label20);
            this.panelcontatti.Controls.Add(this.label22);
            this.panelcontatti.Controls.Add(this.label23);
            this.panelcontatti.Controls.Add(this.btnSaveContact);
            this.panelcontatti.Controls.Add(this.label2);
            this.panelcontatti.Enabled = false;
            this.panelcontatti.Location = new System.Drawing.Point(590, 21);
            this.panelcontatti.Name = "panelcontatti";
            this.panelcontatti.Size = new System.Drawing.Size(530, 460);
            this.panelcontatti.TabIndex = 3;
            // 
            // tbl_societaTableAdapter
            // 
            this.tbl_societaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_contattiTableAdapter
            // 
            this.tbl_contattiTableAdapter.ClearBeforeFill = true;
            // 
            // tblsocietatblcontattiBindingSource
            // 
            this.tblsocietatblcontattiBindingSource.DataMember = "tbl_societatbl_contatti";
            this.tblsocietatblcontattiBindingSource.DataSource = this.tblsocietaBindingSource;
            // 
            // BtnNewSoc
            // 
            this.BtnNewSoc.BackColor = System.Drawing.Color.LightCoral;
            this.BtnNewSoc.Location = new System.Drawing.Point(207, 487);
            this.BtnNewSoc.Name = "BtnNewSoc";
            this.BtnNewSoc.Size = new System.Drawing.Size(100, 30);
            this.BtnNewSoc.TabIndex = 26;
            this.BtnNewSoc.Text = "New";
            this.BtnNewSoc.UseVisualStyleBackColor = false;
            this.BtnNewSoc.Click += new System.EventHandler(this.BtnNewSoc_Click);
            // 
            // BtnNewCont
            // 
            this.BtnNewCont.BackColor = System.Drawing.Color.LightCoral;
            this.BtnNewCont.Location = new System.Drawing.Point(807, 487);
            this.BtnNewCont.Name = "BtnNewCont";
            this.BtnNewCont.Size = new System.Drawing.Size(101, 30);
            this.BtnNewCont.TabIndex = 46;
            this.BtnNewCont.Text = "New";
            this.BtnNewCont.UseVisualStyleBackColor = false;
            this.BtnNewCont.Click += new System.EventHandler(this.BtnNewCont_Click);
            // 
            // tblsocietatblcontattiBindingSource1
            // 
            this.tblsocietatblcontattiBindingSource1.DataMember = "tbl_societatbl_contatti";
            this.tblsocietatblcontattiBindingSource1.DataSource = this.tblsocietaBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(521, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNewCont);
            this.Controls.Add(this.BtnNewSoc);
            this.Controls.Add(this.panelSocieta);
            this.Controls.Add(this.panelcontatti);
            this.Name = "Insert";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcontattiBindingSource)).EndInit();
            this.panelSocieta.ResumeLayout(false);
            this.panelSocieta.PerformLayout();
            this.panelcontatti.ResumeLayout(false);
            this.panelcontatti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietatblcontattiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsocietatblcontattiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboRiservatoSoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSavesocieta;
        private System.Windows.Forms.TextBox txtpiva;
        private System.Windows.Forms.TextBox txtsito;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txttelefono2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtRag_soc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcellulare;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboSocieta;
        private System.Windows.Forms.TextBox txtemailCont;
        private System.Windows.Forms.TextBox txtfaxcont;
        private System.Windows.Forms.TextBox txttel2cont;
        private System.Windows.Forms.Panel panelSocieta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttelcon;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.Panel panelcontatti;
        private AppData appData;
        private System.Windows.Forms.BindingSource tblsocietaBindingSource;
        private AppDataTableAdapters.tbl_societaTableAdapter tbl_societaTableAdapter;
        private System.Windows.Forms.BindingSource tblcontattiBindingSource;
        private AppDataTableAdapters.tbl_contattiTableAdapter tbl_contattiTableAdapter;
        private System.Windows.Forms.BindingSource tblsocietatblcontattiBindingSource;
        private System.Windows.Forms.Button BtnNewSoc;
        private System.Windows.Forms.Button BtnNewCont;
        private System.Windows.Forms.BindingSource tblsocietatblcontattiBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}

