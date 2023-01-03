namespace Projeto_final
{
    partial class JanelaPrincipal
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
            this.lbl_Título = new System.Windows.Forms.Label();
            this.lbl_Compra = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.lv_Relatorio = new System.Windows.Forms.ListView();
            this.cl_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NvCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Anotacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Valor = new System.Windows.Forms.MaskedTextBox();
            this.gb_NovoCliente = new System.Windows.Forms.GroupBox();
            this.rb_Nao = new System.Windows.Forms.RadioButton();
            this.rb_Sim = new System.Windows.Forms.RadioButton();
            this.gb_anotacoes = new System.Windows.Forms.GroupBox();
            this.cb_APrevio = new System.Windows.Forms.CheckBox();
            this.cb_Condominio = new System.Windows.Forms.CheckBox();
            this.cb_HComercial = new System.Windows.Forms.CheckBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.gb_NovoCliente.SuspendLayout();
            this.gb_anotacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Título.Location = new System.Drawing.Point(211, 12);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(248, 27);
            this.lbl_Título.TabIndex = 0;
            this.lbl_Título.Text = "Relatório de Vendas MH";
            // 
            // lbl_Compra
            // 
            this.lbl_Compra.AutoSize = true;
            this.lbl_Compra.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Compra.Location = new System.Drawing.Point(452, 41);
            this.lbl_Compra.Name = "lbl_Compra";
            this.lbl_Compra.Size = new System.Drawing.Size(77, 23);
            this.lbl_Compra.TabIndex = 1;
            this.lbl_Compra.Text = "Compra";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Cliente.Location = new System.Drawing.Point(123, 41);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(70, 23);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(74, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(74, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(74, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sobrenome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(74, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(74, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(393, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Anotações:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(393, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Data:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(393, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(392, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Novo Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(393, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Status:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(524, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 8;
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_ID.Location = new System.Drawing.Point(157, 78);
            this.tb_ID.MaximumSize = new System.Drawing.Size(100, 22);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 27);
            this.tb_ID.TabIndex = 3;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPessionada_ID);
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Sobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Sobrenome.Location = new System.Drawing.Point(157, 132);
            this.tb_Sobrenome.MaximumSize = new System.Drawing.Size(100, 22);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(100, 27);
            this.tb_Sobrenome.TabIndex = 5;
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_Nome.Location = new System.Drawing.Point(157, 104);
            this.tb_Nome.MaximumSize = new System.Drawing.Size(100, 22);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(100, 27);
            this.tb_Nome.TabIndex = 4;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Adicionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Adicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Adicionar.Location = new System.Drawing.Point(242, 237);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(181, 55);
            this.bt_Adicionar.TabIndex = 18;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = false;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // lv_Relatorio
            // 
            this.lv_Relatorio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_ID,
            this.cl_Nome,
            this.cl_Sobrenome,
            this.cl_Telefone,
            this.cl_CEP,
            this.cl_Status,
            this.cl_NvCliente,
            this.cl_Valor,
            this.cl_Data,
            this.cl_Anotacoes});
            this.lv_Relatorio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Relatorio.GridLines = true;
            this.lv_Relatorio.HideSelection = false;
            this.lv_Relatorio.Location = new System.Drawing.Point(0, 313);
            this.lv_Relatorio.Name = "lv_Relatorio";
            this.lv_Relatorio.Size = new System.Drawing.Size(668, 193);
            this.lv_Relatorio.TabIndex = 25;
            this.lv_Relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_Relatorio.View = System.Windows.Forms.View.Details;
            // 
            // cl_ID
            // 
            this.cl_ID.Text = "ID";
            this.cl_ID.Width = 26;
            // 
            // cl_Nome
            // 
            this.cl_Nome.Text = "Nome";
            // 
            // cl_Sobrenome
            // 
            this.cl_Sobrenome.Text = "Sobrenome";
            this.cl_Sobrenome.Width = 84;
            // 
            // cl_Telefone
            // 
            this.cl_Telefone.Text = "Telefone";
            this.cl_Telefone.Width = 73;
            // 
            // cl_CEP
            // 
            this.cl_CEP.Text = "CEP";
            this.cl_CEP.Width = 72;
            // 
            // cl_Status
            // 
            this.cl_Status.Text = "Status";
            this.cl_Status.Width = 67;
            // 
            // cl_NvCliente
            // 
            this.cl_NvCliente.Text = "Novo Cliente";
            this.cl_NvCliente.Width = 81;
            // 
            // cl_Valor
            // 
            this.cl_Valor.Text = "Valor";
            // 
            // cl_Data
            // 
            this.cl_Data.Text = "Data";
            // 
            // cl_Anotacoes
            // 
            this.cl_Anotacoes.Text = "Anotações";
            this.cl_Anotacoes.Width = 83;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Telefone.Location = new System.Drawing.Point(157, 160);
            this.mtb_Telefone.Mask = "(99) 00000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(100, 27);
            this.mtb_Telefone.TabIndex = 6;
            // 
            // mtb_CEP
            // 
            this.mtb_CEP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_CEP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_CEP.Location = new System.Drawing.Point(157, 193);
            this.mtb_CEP.Mask = "00000-000";
            this.mtb_CEP.Name = "mtb_CEP";
            this.mtb_CEP.Size = new System.Drawing.Size(100, 27);
            this.mtb_CEP.TabIndex = 7;
            // 
            // mtb_Valor
            // 
            this.mtb_Valor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Valor.Location = new System.Drawing.Point(487, 139);
            this.mtb_Valor.Mask = "$ 00.000";
            this.mtb_Valor.Name = "mtb_Valor";
            this.mtb_Valor.Size = new System.Drawing.Size(100, 27);
            this.mtb_Valor.TabIndex = 12;
            // 
            // gb_NovoCliente
            // 
            this.gb_NovoCliente.Controls.Add(this.rb_Nao);
            this.gb_NovoCliente.Controls.Add(this.rb_Sim);
            this.gb_NovoCliente.Location = new System.Drawing.Point(486, 96);
            this.gb_NovoCliente.Name = "gb_NovoCliente";
            this.gb_NovoCliente.Size = new System.Drawing.Size(100, 37);
            this.gb_NovoCliente.TabIndex = 9;
            this.gb_NovoCliente.TabStop = false;
            // 
            // rb_Nao
            // 
            this.rb_Nao.AutoSize = true;
            this.rb_Nao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Nao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rb_Nao.Location = new System.Drawing.Point(50, 13);
            this.rb_Nao.Name = "rb_Nao";
            this.rb_Nao.Size = new System.Drawing.Size(47, 19);
            this.rb_Nao.TabIndex = 11;
            this.rb_Nao.Text = "Não";
            this.rb_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Sim
            // 
            this.rb_Sim.AutoSize = true;
            this.rb_Sim.Checked = true;
            this.rb_Sim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Sim.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rb_Sim.Location = new System.Drawing.Point(6, 13);
            this.rb_Sim.Name = "rb_Sim";
            this.rb_Sim.Size = new System.Drawing.Size(44, 19);
            this.rb_Sim.TabIndex = 10;
            this.rb_Sim.TabStop = true;
            this.rb_Sim.Text = "Sim";
            this.rb_Sim.UseVisualStyleBackColor = true;
            // 
            // gb_anotacoes
            // 
            this.gb_anotacoes.Controls.Add(this.cb_APrevio);
            this.gb_anotacoes.Controls.Add(this.cb_Condominio);
            this.gb_anotacoes.Controls.Add(this.cb_HComercial);
            this.gb_anotacoes.Location = new System.Drawing.Point(486, 194);
            this.gb_anotacoes.Name = "gb_anotacoes";
            this.gb_anotacoes.Size = new System.Drawing.Size(102, 74);
            this.gb_anotacoes.TabIndex = 14;
            this.gb_anotacoes.TabStop = false;
            // 
            // cb_APrevio
            // 
            this.cb_APrevio.AutoSize = true;
            this.cb_APrevio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_APrevio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_APrevio.Location = new System.Drawing.Point(6, 51);
            this.cb_APrevio.Name = "cb_APrevio";
            this.cb_APrevio.Size = new System.Drawing.Size(95, 19);
            this.cb_APrevio.TabIndex = 17;
            this.cb_APrevio.Text = "Aviso Prévio";
            this.cb_APrevio.UseVisualStyleBackColor = true;
            // 
            // cb_Condominio
            // 
            this.cb_Condominio.AutoSize = true;
            this.cb_Condominio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Condominio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Condominio.Location = new System.Drawing.Point(6, 32);
            this.cb_Condominio.Name = "cb_Condominio";
            this.cb_Condominio.Size = new System.Drawing.Size(91, 19);
            this.cb_Condominio.TabIndex = 16;
            this.cb_Condominio.Text = "Condominio";
            this.cb_Condominio.UseVisualStyleBackColor = true;
            // 
            // cb_HComercial
            // 
            this.cb_HComercial.AutoSize = true;
            this.cb_HComercial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_HComercial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_HComercial.Location = new System.Drawing.Point(6, 14);
            this.cb_HComercial.Name = "cb_HComercial";
            this.cb_HComercial.Size = new System.Drawing.Size(93, 19);
            this.cb_HComercial.TabIndex = 15;
            this.cb_HComercial.Text = "H. Comercial";
            this.cb_HComercial.UseVisualStyleBackColor = true;
            // 
            // cb_Status
            // 
            this.cb_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Status.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_Status.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ag. Pagamento",
            "Pago",
            "Ag. envio",
            "Enviado",
            "Finalizado"});
            this.cb_Status.Location = new System.Drawing.Point(487, 74);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(101, 24);
            this.cb_Status.TabIndex = 8;
            // 
            // dtp_Data
            // 
            this.dtp_Data.CalendarFont = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Data.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Data.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(486, 172);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(102, 23);
            this.dtp_Data.TabIndex = 13;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(667, 507);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.gb_anotacoes);
            this.Controls.Add(this.gb_NovoCliente);
            this.Controls.Add(this.mtb_Valor);
            this.Controls.Add(this.mtb_CEP);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lv_Relatorio);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_Sobrenome);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.lbl_Compra);
            this.Controls.Add(this.lbl_Título);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JanelaPrincipal";
            this.Text = "Relatório Básico de Vendas";
            this.gb_NovoCliente.ResumeLayout(false);
            this.gb_NovoCliente.PerformLayout();
            this.gb_anotacoes.ResumeLayout(false);
            this.gb_anotacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_Compra;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.ListView lv_Relatorio;
        private System.Windows.Forms.ColumnHeader cl_ID;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Sobrenome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_CEP;
        private System.Windows.Forms.ColumnHeader cl_Status;
        private System.Windows.Forms.ColumnHeader cl_NvCliente;
        private System.Windows.Forms.ColumnHeader cl_Valor;
        private System.Windows.Forms.ColumnHeader cl_Data;
        private System.Windows.Forms.ColumnHeader cl_Anotacoes;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_CEP;
        private System.Windows.Forms.MaskedTextBox mtb_Valor;
        private System.Windows.Forms.GroupBox gb_NovoCliente;
        private System.Windows.Forms.RadioButton rb_Sim;
        private System.Windows.Forms.RadioButton rb_Nao;
        private System.Windows.Forms.GroupBox gb_anotacoes;
        private System.Windows.Forms.CheckBox cb_APrevio;
        private System.Windows.Forms.CheckBox cb_Condominio;
        private System.Windows.Forms.CheckBox cb_HComercial;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}

