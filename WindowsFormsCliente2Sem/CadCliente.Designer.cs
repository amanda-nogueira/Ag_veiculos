namespace WindowsFormsCliente2Sem
{
    partial class CadCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cBEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComple = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReside = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFipe = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbCombu = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbCambio = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cBAno = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btCadastar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.cBEstado);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtComple);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReside);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateNasc);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(28, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.checkedListBox1.Location = new System.Drawing.Point(372, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 30);
            this.checkedListBox1.TabIndex = 29;
            // 
            // cBEstado
            // 
            this.cBEstado.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cBEstado.AllowDrop = true;
            this.cBEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBEstado.FormattingEnabled = true;
            this.cBEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cBEstado.Location = new System.Drawing.Point(331, 129);
            this.cBEstado.Name = "cBEstado";
            this.cBEstado.Size = new System.Drawing.Size(205, 21);
            this.cBEstado.TabIndex = 28;
            this.cBEstado.SelectedIndexChanged += new System.EventHandler(this.cBEstado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCidade.Location = new System.Drawing.Point(324, 190);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(212, 20);
            this.txtCidade.TabIndex = 26;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cidade:";
            // 
            // txtComple
            // 
            this.txtComple.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtComple.Location = new System.Drawing.Point(93, 187);
            this.txtComple.Name = "txtComple";
            this.txtComple.Size = new System.Drawing.Size(181, 20);
            this.txtComple.TabIndex = 24;
            this.txtComple.TextChanged += new System.EventHandler(this.txtComple_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Complemento:";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNum.Location = new System.Drawing.Point(465, 158);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(71, 20);
            this.txtNum.TabIndex = 22;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCep.Location = new System.Drawing.Point(315, 158);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 21;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Numero:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "CEP: ";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRua.Location = new System.Drawing.Point(54, 158);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(210, 20);
            this.txtRua.TabIndex = 18;
            this.txtRua.TextChanged += new System.EventHandler(this.txtRua_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Long.:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtReside
            // 
            this.txtReside.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReside.Location = new System.Drawing.Point(372, 106);
            this.txtReside.Name = "txtReside";
            this.txtReside.Size = new System.Drawing.Size(164, 20);
            this.txtReside.TabIndex = 16;
            this.txtReside.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCpf.Location = new System.Drawing.Point(54, 130);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(210, 20);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtCel
            // 
            this.txtCel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCel.Location = new System.Drawing.Point(80, 104);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(184, 20);
            this.txtCel.TabIndex = 15;
            this.txtCel.TextChanged += new System.EventHandler(this.txtCel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(62, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(474, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tel. Residencial: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tel. Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo:";
            // 
            // dateNasc
            // 
            this.dateNasc.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateNasc.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateNasc.Location = new System.Drawing.Point(60, 42);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.Size = new System.Drawing.Size(210, 20);
            this.dateNasc.TabIndex = 4;
            this.dateNasc.ValueChanged += new System.EventHandler(this.dateNasc_ValueChanged);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(59, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(477, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nasc.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFipe);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cbCombu);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cbCambio);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cBAno);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.txtChassi);
            this.groupBox2.Controls.Add(this.txtCor);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtRenavam);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(28, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtFipe
            // 
            this.txtFipe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFipe.Location = new System.Drawing.Point(307, 103);
            this.txtFipe.Name = "txtFipe";
            this.txtFipe.Size = new System.Drawing.Size(100, 20);
            this.txtFipe.TabIndex = 20;
            this.txtFipe.TextChanged += new System.EventHandler(this.txtFipe_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(244, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Valor Fipe:";
            // 
            // cbCombu
            // 
            this.cbCombu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCombu.FormattingEnabled = true;
            this.cbCombu.Items.AddRange(new object[] {
            "1. Gasolina",
            "2. Etanol",
            "3. Flex",
            "4. Disel",
            "5. Gás Natural"});
            this.cbCombu.Location = new System.Drawing.Point(80, 103);
            this.cbCombu.Name = "cbCombu";
            this.cbCombu.Size = new System.Drawing.Size(145, 21);
            this.cbCombu.TabIndex = 18;
            this.cbCombu.SelectedIndexChanged += new System.EventHandler(this.cbCombu_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Combustível:";
            // 
            // cbCambio
            // 
            this.cbCambio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCambio.FormattingEnabled = true;
            this.cbCambio.Items.AddRange(new object[] {
            "",
            "Manual",
            "Automatizado de dupla embreagem",
            "Automático",
            "CVT "});
            this.cbCambio.Location = new System.Drawing.Point(328, 78);
            this.cbCambio.Name = "cbCambio";
            this.cbCambio.Size = new System.Drawing.Size(210, 21);
            this.cbCambio.TabIndex = 16;
            this.cbCambio.SelectedIndexChanged += new System.EventHandler(this.cbCambio_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(287, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Câmbio:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlaca.Location = new System.Drawing.Point(175, 78);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(105, 20);
            this.txtPlaca.TabIndex = 14;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(137, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Placa:";
            // 
            // cBAno
            // 
            this.cBAno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBAno.FormattingEnabled = true;
            this.cBAno.Items.AddRange(new object[] {
            "",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cBAno.Location = new System.Drawing.Point(44, 78);
            this.cBAno.Name = "cBAno";
            this.cBAno.Size = new System.Drawing.Size(87, 21);
            this.cBAno.TabIndex = 12;
            this.cBAno.SelectedIndexChanged += new System.EventHandler(this.cBAno_SelectedIndexChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMarca.Location = new System.Drawing.Point(257, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(141, 20);
            this.txtMarca.TabIndex = 11;
            this.txtMarca.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // txtChassi
            // 
            this.txtChassi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtChassi.Location = new System.Drawing.Point(318, 19);
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(220, 20);
            this.txtChassi.TabIndex = 10;
            this.txtChassi.TextChanged += new System.EventHandler(this.txtChassi_TextChanged);
            // 
            // txtCor
            // 
            this.txtCor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCor.Location = new System.Drawing.Point(427, 48);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(111, 20);
            this.txtCor.TabIndex = 8;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModelo.Location = new System.Drawing.Point(58, 48);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(155, 20);
            this.txtModelo.TabIndex = 7;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // txtRenavam
            // 
            this.txtRenavam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRenavam.Location = new System.Drawing.Point(68, 19);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(206, 20);
            this.txtRenavam.TabIndex = 6;
            this.txtRenavam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(219, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Marca:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Chassi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Ano:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(404, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Cor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Modelo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Renavam:";
            // 
            // btCadastar
            // 
            this.btCadastar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastar.Location = new System.Drawing.Point(250, 429);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(148, 33);
            this.btCadastar.TabIndex = 2;
            this.btCadastar.Text = "Cadastar";
            this.btCadastar.UseVisualStyleBackColor = false;
            this.btCadastar.Click += new System.EventHandler(this.btCadastar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(229, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(149, 20);
            this.label21.TabIndex = 3;
            this.label21.Text = "Cadastrar Cliente";
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(635, 468);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btCadastar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CadCliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNasc;
        private System.Windows.Forms.TextBox txtReside;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cBAno;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbCambio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFipe;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbCombu;
        private System.Windows.Forms.Label label23;
    }
}

