namespace PROJETO1
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDTN = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblEND = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(630, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(630, 91);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(89, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(630, 237);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(89, 20);
            this.txtCEP.TabIndex = 7;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            // 
            // cmbDia
            // 
            this.cmbDia.AccessibleDescription = "";
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.Location = new System.Drawing.Point(630, 200);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(46, 21);
            this.cmbDia.TabIndex = 4;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(571, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "NOME";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCpf.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(584, 93);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 13;
            this.lblCpf.Text = "CPF";
            // 
            // lblDTN
            // 
            this.lblDTN.AutoSize = true;
            this.lblDTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTN.Location = new System.Drawing.Point(486, 202);
            this.lblDTN.Name = "lblDTN";
            this.lblDTN.Size = new System.Drawing.Size(129, 15);
            this.lblDTN.TabIndex = 16;
            this.lblDTN.Text = "DATA  NASCIMENTO";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO ",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cmbMes.Location = new System.Drawing.Point(682, 200);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(84, 21);
            this.cmbMes.TabIndex = 5;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
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
            "2000"});
            this.cmbAno.Location = new System.Drawing.Point(772, 200);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(84, 21);
            this.cmbAno.TabIndex = 6;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "CEP";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(725, 237);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(60, 20);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblEND
            // 
            this.lblEND.AutoSize = true;
            this.lblEND.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEND.Location = new System.Drawing.Point(541, 275);
            this.lblEND.Name = "lblEND";
            this.lblEND.Size = new System.Drawing.Size(74, 15);
            this.lblEND.TabIndex = 18;
            this.lblEND.Text = "ENDEREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "NÚMERO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Adamantina",
            "Adolfo",
            "Aguai",
            "Aguas da Prata",
            "Aguas de Lindoia",
            "Aguas de Santa Barbara",
            "Aguas de Sao Pedro",
            "Agudos",
            "Alambari",
            "Alfredo Marcondes",
            "Altair",
            "Altinopolis",
            "Alto Alegre",
            "Aluminio",
            "Alvares Florence",
            "Alvares Machado",
            "Alvaro de Carvalho",
            "Alvinlandia",
            "Americana",
            "Americo Brasiliense",
            "Americo de Campos",
            "Amparo",
            "Analandia",
            "Andradina",
            "Angatuba",
            "Anhembi",
            "Anhumas",
            "Aparecida d\'Oeste",
            "Aparecida",
            "Apiai",
            "Aracariguama",
            "Aracatuba",
            "Aracoiaba da Serra",
            "Aramina",
            "Arandu",
            "Arapei",
            "Araraquara",
            "Araras",
            "Arco-Iris",
            "Arealva",
            "Areias",
            "Areiopolis",
            "Ariranha",
            "Artur Nogueira",
            "Aruja",
            "Aspasia",
            "Assis",
            "Atibaia",
            "Auriflama",
            "Avai",
            "Avanhandava",
            "Avare",
            "Bady Bassitt",
            "Balbinos",
            "Balsamo",
            "Bananal",
            "Barao de Antonina",
            "Barbosa",
            "Bariri",
            "Barra Bonita",
            "Barra do Chapeu",
            "Barra do Turvo",
            "Barretos",
            "Barrinha",
            "Barueri",
            "Bastos",
            "Batatais",
            "Bauru",
            "Bebedouro",
            "Bento de Abreu",
            "Bernardino de Campos",
            "Bertioga",
            "Bilac",
            "Birigui",
            "Biritiba-Mirim",
            "Boa Esperanca do Sul",
            "Bocaina",
            "Bofete",
            "Boituva",
            "Bom Jesus dos Perdoes",
            "Bom Sucesso de Itarare",
            "Bora",
            "Boraceia",
            "Borborema",
            "Borebi",
            "Botucatu",
            "Braganca Paulista",
            "Brauna",
            "Brejo Alegre",
            "Brodosqui",
            "Brotas",
            "Buri",
            "Buritama",
            "Buritizal",
            "Cabralia Paulista",
            "Cabreuva",
            "Cacapava",
            "Cachoeira Paulista",
            "Caconde",
            "Cafelandia",
            "Caiabu",
            "Caieiras",
            "Caiua",
            "Cajamar",
            "Cajati",
            "Cajobi",
            "Cajuru",
            "Campina do Monte Alegre",
            "Campinas",
            "Campo Limpo Paulista",
            "Campos Novos Paulista",
            "Campos do Jordao",
            "Cananeia",
            "Canas",
            "Candido Mota",
            "Candido Rodrigues",
            "Canitar",
            "Capao Bonito",
            "Capela do Alto",
            "Capivari",
            "Caraguatatuba",
            "Carapicuiba",
            "Cardoso",
            "Casa Branca",
            "Cassia dos Coqueiros",
            "Castilho",
            "Catanduva",
            "Catigua",
            "Cedral",
            "Cerqueira Cesar",
            "Cerquilho",
            "Cesario Lange",
            "Charqueada",
            "Chavantes",
            "Clementina",
            "Colina",
            "Colombia",
            "Conchal",
            "Conchas",
            "Cordeiropolis",
            "Coroados",
            "Coronel Macedo",
            "Corumbatai",
            "Cosmopolis",
            "Cosmorama",
            "Cotia",
            "Cravinhos",
            "Cristais Paulista",
            "Cruzalia",
            "Cruzeiro",
            "Cubatao",
            "Cunha",
            "Descalvado",
            "Diadema",
            "Dirce Reis",
            "Divinolandia",
            "Dobrada",
            "Dois Corregos",
            "Dolcinopolis",
            "Dourado",
            "Dracena",
            "Duartina",
            "Dumont",
            "Echapora",
            "Eldorado",
            "Elias Fausto",
            "Elisiario",
            "Embauba",
            "Embu",
            "Embu-Guacu",
            "Emilianopolis",
            "Engenheiro Coelho",
            "Espirito Santo do Pinhal",
            "Espirito Santo do Turvo",
            "Estiva Gerbi",
            "Estrela d\'Oeste",
            "Estrela do Norte",
            "Euclides da Cunha Paulista",
            "Fartura",
            "Fernando Prestes",
            "Fernandopolis",
            "Fernao",
            "Ferraz de Vasconcelos",
            "Flora Rica",
            "Floreal",
            "Florida Paulista",
            "Florinia",
            "Franca",
            "Francisco Morato",
            "Franco da Rocha",
            "Gabriel Monteiro",
            "Galia",
            "Garca",
            "Gastao Vidigal",
            "Gaviao Peixoto",
            "General Salgado",
            "Getulina",
            "Glicerio",
            "Guaicara",
            "Guaimbe",
            "Guaira",
            "Guapiacu",
            "Guapiara",
            "Guara",
            "Guaracai",
            "Guaraci",
            "Guarani d\'Oeste",
            "Guaranta",
            "Guararapes",
            "Guararema",
            "Guaratingueta",
            "Guarei",
            "Guariba",
            "Guaruja",
            "Guarulhos",
            "Guatapara",
            "Guzolandia",
            "Herculandia",
            "Holambra",
            "Hortolandia",
            "Iacanga",
            "Iacri",
            "Iaras",
            "Ibate",
            "Ibira",
            "Ibirarema",
            "Ibitinga",
            "Ibiuna",
            "Icem",
            "Iepe",
            "Igaracu do Tiete",
            "Igarapava",
            "Igarata",
            "Iguape",
            "Ilha Comprida",
            "Ilha Solteira",
            "Ilhabela",
            "Indaiatuba",
            "Indiana",
            "Indiapora",
            "Inubia Paulista",
            "Ipaucu",
            "Ipero",
            "Ipeuna",
            "Ipigua",
            "Iporanga",
            "Ipua",
            "Iracemapolis",
            "Irapua",
            "Irapuru",
            "Itabera",
            "Itai",
            "Itajobi",
            "Itaju",
            "Itanhaem",
            "Itaoca",
            "Itapecerica da Serra",
            "Itapetininga",
            "Itapeva",
            "Itapevi",
            "Itapira",
            "Itapirapua Paulista",
            "Itapolis",
            "Itaporanga",
            "Itapui",
            "Itapura",
            "Itaquaquecetuba",
            "Itarare",
            "Itariri",
            "Itatiba",
            "Itatinga",
            "Itirapina",
            "Itirapua",
            "Itobi",
            "Itu",
            "Itupeva",
            "Ituverava",
            "Jaborandi",
            "Jaboticabal",
            "Jacarei",
            "Jaci",
            "Jacupiranga",
            "Jaguariuna",
            "Jales",
            "Jambeiro",
            "Jandira",
            "Jardinopolis",
            "Jarinu",
            "Jau",
            "Jeriquara",
            "Joanopolis",
            "Joao Ramalho",
            "Jose Bonifacio",
            "Julio Mesquita",
            "Jumirim",
            "Jundiai",
            "Junqueiropolis",
            "Juquia",
            "Juquitiba",
            "Lagoinha",
            "Laranjal Paulista",
            "Lavinia",
            "Lavrinhas",
            "Leme",
            "Lencois Paulista",
            "Limeira",
            "Lindoia",
            "Lins",
            "Lorena",
            "Lourdes",
            "Louveira",
            "Lucelia",
            "Lucianopolis",
            "Luis Antonio",
            "Luiziania",
            "Lupercio",
            "Lutecia",
            "Macatuba",
            "Macaubal",
            "Macedonia",
            "Magda",
            "Mairinque",
            "Mairipora",
            "Manduri",
            "Maraba Paulista",
            "Maracai",
            "Marapoama",
            "Mariapolis",
            "Marilia",
            "Marinopolis",
            "Martinopolis",
            "Matao",
            "Maua",
            "Mendonca",
            "Meridiano",
            "Mesopolis",
            "Miguelopolis",
            "Mineiros do Tiete",
            "Mira Estrela",
            "Miracatu",
            "Mirandopolis",
            "Mirante do Paranapanema",
            "Mirassol",
            "Mirassolandia",
            "Mococa",
            "Mogi Guacu",
            "Moji das Cruzes",
            "Moji-Mirim",
            "Mombuca",
            "Moncoes",
            "Mongagua",
            "Monte Alegre do Sul",
            "Monte Alto",
            "Monte Aprazivel",
            "Monte Azul Paulista",
            "Monte Castelo",
            "Monte Mor",
            "Monteiro Lobato",
            "Morro Agudo",
            "Morungaba",
            "Motuca",
            "Murutinga do Sul",
            "Nantes",
            "Narandiba",
            "Natividade da Serra",
            "Nazare Paulista",
            "Neves Paulista",
            "Nhandeara",
            "Nipoa",
            "Nova Alianca",
            "Nova Campina",
            "Nova Canaa Paulista",
            "Nova Castilho",
            "Nova Europa",
            "Nova Granada",
            "Nova Guataporanga",
            "Nova Independencia",
            "Nova Luzitania",
            "Nova Odessa",
            "Novais",
            "Novo Horizonte",
            "Nuporanga",
            "Ocaucu",
            "Oleo",
            "Olimpia",
            "Onda Verde",
            "Oriente",
            "Orindiuva",
            "Orlandia",
            "Osasco",
            "Oscar Bressane",
            "Osvaldo Cruz",
            "Ourinhos",
            "Ouro Verde",
            "Ouroeste",
            "Pacaembu",
            "Palestina",
            "Palmares Paulista",
            "Palmeira d\'Oeste",
            "Palmital",
            "Panorama",
            "Paraguacu Paulista",
            "Paraibuna",
            "Paraiso",
            "Paranapanema",
            "Paranapua",
            "Parapua",
            "Pardinho",
            "Pariquera-Acu",
            "Parisi",
            "Patrocinio Paulista",
            "Pauliceia",
            "Paulinia",
            "Paulistania",
            "Paulo de Faria",
            "Pederneiras",
            "Pedra Bela",
            "Pedranopolis",
            "Pedregulho",
            "Pedreira",
            "Pedrinhas Paulista",
            "Pedro de Toledo",
            "Penapolis",
            "Pereira Barreto",
            "Pereiras",
            "Peruibe",
            "Piacatu",
            "Piedade",
            "Pilar do Sul",
            "Pindamonhangaba",
            "Pindorama",
            "Pinhalzinho",
            "Piquerobi",
            "Piquete",
            "Piracaia",
            "Piracicaba",
            "Piraju",
            "Pirajui",
            "Pirangi",
            "Pirapora do Bom Jesus",
            "Pirapozinho",
            "Pirassununga",
            "Piratininga",
            "Pitangueiras",
            "Planalto",
            "Platina",
            "Poa",
            "Poloni",
            "Pompeia",
            "Pongai",
            "Pontal",
            "Pontalinda",
            "Pontes Gestal",
            "Populina",
            "Porangaba",
            "Porto Feliz",
            "Porto Ferreira",
            "Potim",
            "Potirendaba",
            "Pracinha",
            "Pradopolis",
            "Praia Grande",
            "Pratania",
            "Presidente Alves",
            "Presidente Bernardes",
            "Presidente Epitacio",
            "Presidente Prudente",
            "Presidente Venceslau",
            "Promissao",
            "Quadra",
            "Quata",
            "Queiroz",
            "Queluz",
            "Quintana",
            "Rafard",
            "Rancharia",
            "Redencao da Serra",
            "Regente Feijo",
            "Reginopolis",
            "Registro",
            "Restinga",
            "Ribeira",
            "Ribeirao Bonito",
            "Ribeirao Branco",
            "Ribeirao Corrente",
            "Ribeirao Grande",
            "Ribeirao Pires",
            "Ribeirao Preto",
            "Ribeirao do Sul",
            "Ribeirao dos Indios",
            "Rifaina",
            "Rincao",
            "Rinopolis",
            "Rio Claro",
            "Rio Grande da Serra",
            "Rio das Pedras",
            "Riolandia",
            "Riversul",
            "Rosana",
            "Roseira",
            "Rubiacea",
            "Rubineia",
            "Sabino",
            "Sagres",
            "Sales Oliveira",
            "Sales",
            "Salesopolis",
            "Salmourao",
            "Saltinho",
            "Salto Grande",
            "Salto de Pirapora",
            "Salto",
            "Sandovalina",
            "Santa Adelia",
            "Santa Albertina",
            "Santa Barbara d\'Oeste",
            "Santa Branca",
            "Santa Clara d\'Oeste",
            "Santa Cruz da Conceicao",
            "Santa Cruz da Esperanca",
            "Santa Cruz das Palmeiras",
            "Santa Cruz do Rio Pardo",
            "Santa Ernestina",
            "Santa Fe do Sul",
            "Santa Gertrudes",
            "Santa Isabel",
            "Santa Lucia",
            "Santa Maria da Serra",
            "Santa Mercedes",
            "Santa Rita d\'Oeste",
            "Santa Rita do Passa Quatro",
            "Santa Rosa de Viterbo",
            "Santa Salete",
            "Santana da Ponte Pensa",
            "Santana de Parnaiba",
            "Santo Anastacio",
            "Santo Andre",
            "Santo Antonio da Alegria",
            "Santo Antonio de Posse",
            "Santo Antonio do Aracangua",
            "Santo Antonio do Jardim",
            "Santo Antonio do Pinhal",
            "Santo Expedito",
            "Santopolis do Aguapei",
            "Santos",
            "Sao Bento do Sapucai",
            "Sao Bernardo do Campo",
            "Sao Caetano do Sul",
            "Sao Carlos",
            "Sao Francisco",
            "Sao Joao da Boa Vista",
            "Sao Joao das Duas Pontes",
            "Sao Joao de Iracema",
            "Sao Joao do Pau d\'Alho",
            "Sao Joaquim da Barra",
            "Sao Jose da Bela Vista",
            "Sao Jose do Barreiro",
            "Sao Jose do Rio Pardo",
            "Sao Jose do Rio Preto",
            "Sao Jose dos Campos",
            "Sao Lourenco da Serra",
            "Sao Luis do Paraitinga",
            "Sao Manuel",
            "Sao Miguel Arcanjo",
            "Sao Paulo",
            "Sao Pedro do Turvo",
            "Sao Pedro",
            "Sao Roque",
            "Sao Sebastiao da Grama",
            "Sao Sebastiao",
            "Sao Simao",
            "Sao Vicente",
            "Sarapui",
            "Sarutaia",
            "Sebastianopolis do Sul",
            "Serra Azul",
            "Serra Negra",
            "Serrana",
            "Sertaozinho",
            "Sete Barras",
            "Severinia",
            "Silveiras",
            "Socorro",
            "Sorocaba",
            "Sud Mennucci",
            "Sumare",
            "Suzanapolis",
            "Suzano",
            "Tabapua",
            "Tabatinga",
            "Taboao da Serra",
            "Taciba",
            "Taguai",
            "Taiacu",
            "Taiuva",
            "Tambau",
            "Tanabi",
            "Tapirai",
            "Tapiratiba",
            "Taquaral",
            "Taquaritinga",
            "Taquarituba",
            "Taquarivai",
            "Tarabai",
            "Taruma",
            "Tatui",
            "Taubate",
            "Tejupa",
            "Teodoro Sampaio",
            "Terra Roxa",
            "Tiete",
            "Timburi",
            "Torre de Pedra",
            "Torrinha",
            "Trabiju",
            "Tremembe",
            "Tres Fronteiras",
            "Tuiuti",
            "Tupa",
            "Tupi Paulista",
            "Turiuba",
            "Turmalina",
            "Ubarana",
            "Ubatuba",
            "Ubirajara",
            "Uchoa",
            "Uniao Paulista",
            "Urania",
            "Uru",
            "Urupes",
            "Valentim Gentil",
            "Valinhos",
            "Valparaiso",
            "Vargem Grande Paulista",
            "Vargem Grande do Sul",
            "Vargem",
            "Varzea Paulista",
            "Vera Cruz",
            "Vinhedo",
            "Viradouro",
            "Vista Alegre do Alto",
            "Vitoria Brasil",
            "Votorantim",
            "Votuporanga",
            "Zacarias"});
            this.cmbCidade.Location = new System.Drawing.Point(630, 341);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(136, 21);
            this.cmbCidade.TabIndex = 11;
            this.cmbCidade.SelectedIndexChanged += new System.EventHandler(this.cmbCidade_SelectedIndexChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(561, 343);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 15);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "CIDADE";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(630, 273);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(320, 20);
            this.txtEnd.TabIndex = 9;
            this.txtEnd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(545, 166);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 15);
            this.lblTelefone.TabIndex = 15;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(565, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 15);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-MAIL";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(630, 164);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(89, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(630, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(630, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 20);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1034, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEND);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblDTN);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1050, 497);
            this.MinimumSize = new System.Drawing.Size(1050, 497);
            this.Name = "frmCadastro";
            this.Text = "Cliente - Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDTN;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblEND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label3;
    }
}

