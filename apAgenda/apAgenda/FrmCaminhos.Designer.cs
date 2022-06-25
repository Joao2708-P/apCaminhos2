namespace apCaminhos
{
  partial class FrmCaminhos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaminhos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.Caminhos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMelhorCaminho = new System.Windows.Forms.Label();
            this.dgvCaminhosEncontrados = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMelhorCaminho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCaminhos = new System.Windows.Forms.Button();
            this.udCusto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.udDistancia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.lbKmCaminhoSelecionado = new System.Windows.Forms.Label();
            this.dlgAbrir2 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.Caminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhosEncontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 730);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1336, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slMensagem
            // 
            this.slMensagem.Name = "slMensagem";
            this.slMensagem.Size = new System.Drawing.Size(76, 17);
            this.slMensagem.Text = "Registro 1/23";
            // 
            // imlBotoes
            // 
            this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
            this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBotoes.Images.SetKeyName(0, "first.bmp");
            this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
            this.imlBotoes.Images.SetKeyName(2, "next.bmp");
            this.imlBotoes.Images.SetKeyName(3, "last.bmp");
            this.imlBotoes.Images.SetKeyName(4, "Oeil2.bmp");
            this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
            this.imlBotoes.Images.SetKeyName(6, "UNDO.BMP");
            this.imlBotoes.Images.SetKeyName(7, "Save.bmp");
            this.imlBotoes.Images.SetKeyName(8, "Minus.bmp");
            this.imlBotoes.Images.SetKeyName(9, "CLOSE1.BMP");
            // 
            // Caminhos
            // 
            this.Caminhos.BackColor = System.Drawing.Color.Silver;
            this.Caminhos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Caminhos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator3,
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator2,
            this.toolStripSeparator4,
            this.btnExcluir,
            this.toolStripSeparator5,
            this.btnSair});
            this.Caminhos.Location = new System.Drawing.Point(0, 0);
            this.Caminhos.Name = "Caminhos";
            this.Caminhos.Size = new System.Drawing.Size(1336, 42);
            this.Caminhos.TabIndex = 3;
            this.Caminhos.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 39);
            this.toolStripButton1.Text = "Início";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 39);
            this.toolStripButton2.Text = "Anterior";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(56, 39);
            this.toolStripButton3.Text = "Próximo";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(47, 39);
            this.toolStripButton4.Text = "Último";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(56, 39);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 39);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 39);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 42);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(46, 39);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 42);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 39);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.InitialDirectory = "c:\\temp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(332, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 576);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Caminhos encontrados";
            // 
            // lbMelhorCaminho
            // 
            this.lbMelhorCaminho.AutoSize = true;
            this.lbMelhorCaminho.Location = new System.Drawing.Point(121, 190);
            this.lbMelhorCaminho.Name = "lbMelhorCaminho";
            this.lbMelhorCaminho.Size = new System.Drawing.Size(195, 20);
            this.lbMelhorCaminho.TabIndex = 33;
            this.lbMelhorCaminho.Text = "Melhor caminho (yyyyy km)";
            // 
            // dgvCaminhosEncontrados
            // 
            this.dgvCaminhosEncontrados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaminhosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhosEncontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvCaminhosEncontrados.Location = new System.Drawing.Point(10, 599);
            this.dgvCaminhosEncontrados.Name = "dgvCaminhosEncontrados";
            this.dgvCaminhosEncontrados.Size = new System.Drawing.Size(1323, 121);
            this.dgvCaminhosEncontrados.TabIndex = 32;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1a";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2a";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3a";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4a";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5a";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6a";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7a";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8a";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "9a";
            this.Column10.Name = "Column10";
            // 
            // dgvMelhorCaminho
            // 
            this.dgvMelhorCaminho.AllowUserToDeleteRows = false;
            this.dgvMelhorCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMelhorCaminho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMelhorCaminho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMelhorCaminho.Location = new System.Drawing.Point(120, 213);
            this.dgvMelhorCaminho.Name = "dgvMelhorCaminho";
            this.dgvMelhorCaminho.Size = new System.Drawing.Size(201, 326);
            this.dgvMelhorCaminho.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Passando por";
            this.Column1.Name = "Column1";
            this.Column1.Width = 132;
            // 
            // btnCaminhos
            // 
            this.btnCaminhos.Location = new System.Drawing.Point(10, 213);
            this.btnCaminhos.Name = "btnCaminhos";
            this.btnCaminhos.Size = new System.Drawing.Size(104, 63);
            this.btnCaminhos.TabIndex = 45;
            this.btnCaminhos.Text = "Achar caminhos";
            this.btnCaminhos.UseVisualStyleBackColor = true;
            this.btnCaminhos.Click += new System.EventHandler(this.btnCaminhos_Click);
            // 
            // udCusto
            // 
            this.udCusto.Location = new System.Drawing.Point(85, 148);
            this.udCusto.Name = "udCusto";
            this.udCusto.Size = new System.Drawing.Size(74, 26);
            this.udCusto.TabIndex = 44;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(227, 116);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown2.TabIndex = 43;
            // 
            // udDistancia
            // 
            this.udDistancia.Location = new System.Drawing.Point(85, 116);
            this.udDistancia.Maximum = new decimal(new int[] {
            12500,
            0,
            0,
            0});
            this.udDistancia.Name = "udDistancia";
            this.udDistancia.Size = new System.Drawing.Size(74, 26);
            this.udDistancia.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tempo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Distância:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Origem:";
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(171, 76);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(150, 28);
            this.cbxDestino.TabIndex = 36;
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Items.AddRange(new object[] {
            "123456789012345"});
            this.cbxOrigem.Location = new System.Drawing.Point(10, 76);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(150, 28);
            this.cbxOrigem.TabIndex = 35;
            this.cbxOrigem.SelectedIndexChanged += new System.EventHandler(this.cbxOrigem_SelectedIndexChanged);
            // 
            // lbKmCaminhoSelecionado
            // 
            this.lbKmCaminhoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbKmCaminhoSelecionado.AutoSize = true;
            this.lbKmCaminhoSelecionado.Location = new System.Drawing.Point(12, 556);
            this.lbKmCaminhoSelecionado.Name = "lbKmCaminhoSelecionado";
            this.lbKmCaminhoSelecionado.Size = new System.Drawing.Size(285, 20);
            this.lbKmCaminhoSelecionado.TabIndex = 48;
            this.lbKmCaminhoSelecionado.Text = "Km do caminho selecionado: (xxxxx km)";
            // 
            // dlgAbrir2
            // 
            this.dlgAbrir2.FileName = "openFileDialog1";
            // 
            // FrmCaminhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 752);
            this.Controls.Add(this.lbKmCaminhoSelecionado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbMelhorCaminho);
            this.Controls.Add(this.btnCaminhos);
            this.Controls.Add(this.udCusto);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.udDistancia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDestino);
            this.Controls.Add(this.cbxOrigem);
            this.Controls.Add(this.dgvMelhorCaminho);
            this.Controls.Add(this.dgvCaminhosEncontrados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Caminhos);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCaminhos";
            this.Text = "Ligações e caminhos entre Cidades";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Caminhos.ResumeLayout(false);
            this.Caminhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhosEncontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhorCaminho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imlBotoes;
        private System.Windows.Forms.ToolStrip Caminhos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.ToolStripStatusLabel slMensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lbMelhorCaminho;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.DataGridView dgvCaminhosEncontrados;
    private System.Windows.Forms.DataGridView dgvMelhorCaminho;
    private System.Windows.Forms.Button btnCaminhos;
    private System.Windows.Forms.NumericUpDown udCusto;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown udDistancia;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cbxDestino;
    private System.Windows.Forms.ComboBox cbxOrigem;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.Label lbKmCaminhoSelecionado;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.OpenFileDialog dlgAbrir2;
    }
}

