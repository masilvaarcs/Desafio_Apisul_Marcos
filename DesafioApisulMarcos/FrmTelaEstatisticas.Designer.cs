namespace DesafioApisul
{
    partial class FrmTelaEstatisticas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJsonService = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPercentualCadaElevadorE = new System.Windows.Forms.TextBox();
            this.txtPercentualCadaElevadorD = new System.Windows.Forms.TextBox();
            this.txtPercentualCadaElevadorC = new System.Windows.Forms.TextBox();
            this.txtPercentualCadaElevadorB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutrosMenosUtilizados = new System.Windows.Forms.TextBox();
            this.txtPercentualCadaElevadorA = new System.Windows.Forms.TextBox();
            this.txtMaiorUtilizacaoConjuntoElevadores = new System.Windows.Forms.TextBox();
            this.txtMenosFrequentadoMenorFluxo = new System.Windows.Forms.TextBox();
            this.txtMaisFrequentadoMaiorFluxo = new System.Windows.Forms.TextBox();
            this.txtMenosUtilizado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLerJSON = new System.Windows.Forms.Button();
            this.txtPercentualCadaElevadorF = new System.Windows.Forms.TextBox();
            this.lblInfoCargaJsonInterno_Desafio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblInfoCargaJsonInterno_Desafio);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorF);
            this.panel1.Controls.Add(this.btnJsonService);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorE);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorD);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorC);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOutrosMenosUtilizados);
            this.panel1.Controls.Add(this.txtPercentualCadaElevadorA);
            this.panel1.Controls.Add(this.txtMaiorUtilizacaoConjuntoElevadores);
            this.panel1.Controls.Add(this.txtMenosFrequentadoMenorFluxo);
            this.panel1.Controls.Add(this.txtMaisFrequentadoMaiorFluxo);
            this.panel1.Controls.Add(this.txtMenosUtilizado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLerJSON);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 619);
            this.panel1.TabIndex = 1;
            // 
            // btnJsonService
            // 
            this.btnJsonService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJsonService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJsonService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJsonService.ForeColor = System.Drawing.Color.Blue;
            this.btnJsonService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJsonService.Location = new System.Drawing.Point(491, 71);
            this.btnJsonService.Name = "btnJsonService";
            this.btnJsonService.Size = new System.Drawing.Size(116, 35);
            this.btnJsonService.TabIndex = 18;
            this.btnJsonService.Text = "Json Externo";
            this.btnJsonService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJsonService.UseVisualStyleBackColor = false;
            this.btnJsonService.Click += new System.EventHandler(this.BtnJsonService_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(723, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(63, 40);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // txtPercentualCadaElevadorE
            // 
            this.txtPercentualCadaElevadorE.AcceptsReturn = true;
            this.txtPercentualCadaElevadorE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorE.Enabled = false;
            this.txtPercentualCadaElevadorE.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorE.Location = new System.Drawing.Point(603, 539);
            this.txtPercentualCadaElevadorE.MaxLength = 500;
            this.txtPercentualCadaElevadorE.Multiline = true;
            this.txtPercentualCadaElevadorE.Name = "txtPercentualCadaElevadorE";
            this.txtPercentualCadaElevadorE.ReadOnly = true;
            this.txtPercentualCadaElevadorE.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorE.TabIndex = 17;
            // 
            // txtPercentualCadaElevadorD
            // 
            this.txtPercentualCadaElevadorD.AcceptsReturn = true;
            this.txtPercentualCadaElevadorD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorD.Enabled = false;
            this.txtPercentualCadaElevadorD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorD.Location = new System.Drawing.Point(324, 573);
            this.txtPercentualCadaElevadorD.MaxLength = 500;
            this.txtPercentualCadaElevadorD.Multiline = true;
            this.txtPercentualCadaElevadorD.Name = "txtPercentualCadaElevadorD";
            this.txtPercentualCadaElevadorD.ReadOnly = true;
            this.txtPercentualCadaElevadorD.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorD.TabIndex = 16;
            // 
            // txtPercentualCadaElevadorC
            // 
            this.txtPercentualCadaElevadorC.AcceptsReturn = true;
            this.txtPercentualCadaElevadorC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorC.Enabled = false;
            this.txtPercentualCadaElevadorC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorC.Location = new System.Drawing.Point(324, 539);
            this.txtPercentualCadaElevadorC.MaxLength = 500;
            this.txtPercentualCadaElevadorC.Multiline = true;
            this.txtPercentualCadaElevadorC.Name = "txtPercentualCadaElevadorC";
            this.txtPercentualCadaElevadorC.ReadOnly = true;
            this.txtPercentualCadaElevadorC.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorC.TabIndex = 15;
            // 
            // txtPercentualCadaElevadorB
            // 
            this.txtPercentualCadaElevadorB.AcceptsReturn = true;
            this.txtPercentualCadaElevadorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorB.Enabled = false;
            this.txtPercentualCadaElevadorB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorB.Location = new System.Drawing.Point(45, 573);
            this.txtPercentualCadaElevadorB.MaxLength = 500;
            this.txtPercentualCadaElevadorB.Multiline = true;
            this.txtPercentualCadaElevadorB.Name = "txtPercentualCadaElevadorB";
            this.txtPercentualCadaElevadorB.ReadOnly = true;
            this.txtPercentualCadaElevadorB.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(40, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Outros andares MENOS utilizados:";
            // 
            // txtOutrosMenosUtilizados
            // 
            this.txtOutrosMenosUtilizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtOutrosMenosUtilizados.Enabled = false;
            this.txtOutrosMenosUtilizados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutrosMenosUtilizados.Location = new System.Drawing.Point(364, 216);
            this.txtOutrosMenosUtilizados.MaxLength = 100;
            this.txtOutrosMenosUtilizados.Name = "txtOutrosMenosUtilizados";
            this.txtOutrosMenosUtilizados.ReadOnly = true;
            this.txtOutrosMenosUtilizados.Size = new System.Drawing.Size(422, 30);
            this.txtOutrosMenosUtilizados.TabIndex = 12;
            // 
            // txtPercentualCadaElevadorA
            // 
            this.txtPercentualCadaElevadorA.AcceptsReturn = true;
            this.txtPercentualCadaElevadorA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorA.Enabled = false;
            this.txtPercentualCadaElevadorA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorA.Location = new System.Drawing.Point(45, 539);
            this.txtPercentualCadaElevadorA.MaxLength = 500;
            this.txtPercentualCadaElevadorA.Multiline = true;
            this.txtPercentualCadaElevadorA.Name = "txtPercentualCadaElevadorA";
            this.txtPercentualCadaElevadorA.ReadOnly = true;
            this.txtPercentualCadaElevadorA.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorA.TabIndex = 11;
            // 
            // txtMaiorUtilizacaoConjuntoElevadores
            // 
            this.txtMaiorUtilizacaoConjuntoElevadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaiorUtilizacaoConjuntoElevadores.Enabled = false;
            this.txtMaiorUtilizacaoConjuntoElevadores.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaiorUtilizacaoConjuntoElevadores.Location = new System.Drawing.Point(523, 431);
            this.txtMaiorUtilizacaoConjuntoElevadores.Name = "txtMaiorUtilizacaoConjuntoElevadores";
            this.txtMaiorUtilizacaoConjuntoElevadores.ReadOnly = true;
            this.txtMaiorUtilizacaoConjuntoElevadores.Size = new System.Drawing.Size(105, 30);
            this.txtMaiorUtilizacaoConjuntoElevadores.TabIndex = 10;
            // 
            // txtMenosFrequentadoMenorFluxo
            // 
            this.txtMenosFrequentadoMenorFluxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMenosFrequentadoMenorFluxo.Enabled = false;
            this.txtMenosFrequentadoMenorFluxo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenosFrequentadoMenorFluxo.Location = new System.Drawing.Point(523, 356);
            this.txtMenosFrequentadoMenorFluxo.Name = "txtMenosFrequentadoMenorFluxo";
            this.txtMenosFrequentadoMenorFluxo.ReadOnly = true;
            this.txtMenosFrequentadoMenorFluxo.Size = new System.Drawing.Size(263, 30);
            this.txtMenosFrequentadoMenorFluxo.TabIndex = 9;
            // 
            // txtMaisFrequentadoMaiorFluxo
            // 
            this.txtMaisFrequentadoMaiorFluxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaisFrequentadoMaiorFluxo.Enabled = false;
            this.txtMaisFrequentadoMaiorFluxo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaisFrequentadoMaiorFluxo.Location = new System.Drawing.Point(523, 281);
            this.txtMaisFrequentadoMaiorFluxo.Name = "txtMaisFrequentadoMaiorFluxo";
            this.txtMaisFrequentadoMaiorFluxo.ReadOnly = true;
            this.txtMaisFrequentadoMaiorFluxo.Size = new System.Drawing.Size(263, 30);
            this.txtMaisFrequentadoMaiorFluxo.TabIndex = 8;
            // 
            // txtMenosUtilizado
            // 
            this.txtMenosUtilizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMenosUtilizado.Enabled = false;
            this.txtMenosUtilizado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenosUtilizado.Location = new System.Drawing.Point(523, 180);
            this.txtMenosUtilizado.MaxLength = 100;
            this.txtMenosUtilizado.Name = "txtMenosUtilizado";
            this.txtMenosUtilizado.ReadOnly = true;
            this.txtMenosUtilizado.Size = new System.Drawing.Size(105, 30);
            this.txtMenosUtilizado.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 56);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estatísticas:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "e) Percentual de uso de cada elevador com relação a todos os serviços prestados:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 55);
            this.label4.TabIndex = 4;
            this.label4.Text = "d) Período de maior utilização do conjunto de elevadores (M: Matutino | V: Vesper" +
    "tino | N: Noturno):";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "c) Elevador menos frequentado e o período que se encontra menor fluxo (M: Matutin" +
    "o | V: Vespertino | N: Noturno):";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "b) Elevador mais frequentado e o período que se encontra maior fluxo (M: Matutino" +
    " | V: Vespertino | N: Noturno):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "a) Andar MENOS utilizado pelos usuários:";
            // 
            // btnLerJSON
            // 
            this.btnLerJSON.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLerJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerJSON.ForeColor = System.Drawing.Color.Red;
            this.btnLerJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLerJSON.Location = new System.Drawing.Point(3, 3);
            this.btnLerJSON.Name = "btnLerJSON";
            this.btnLerJSON.Size = new System.Drawing.Size(119, 49);
            this.btnLerJSON.TabIndex = 0;
            this.btnLerJSON.Text = "Baixar Dados (Json fixo)";
            this.btnLerJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLerJSON.UseVisualStyleBackColor = false;
            this.btnLerJSON.Click += new System.EventHandler(this.BtnLerJSON_Click);
            // 
            // txtPercentualCadaElevadorF
            // 
            this.txtPercentualCadaElevadorF.AcceptsReturn = true;
            this.txtPercentualCadaElevadorF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPercentualCadaElevadorF.Enabled = false;
            this.txtPercentualCadaElevadorF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualCadaElevadorF.Location = new System.Drawing.Point(603, 573);
            this.txtPercentualCadaElevadorF.MaxLength = 500;
            this.txtPercentualCadaElevadorF.Multiline = true;
            this.txtPercentualCadaElevadorF.Name = "txtPercentualCadaElevadorF";
            this.txtPercentualCadaElevadorF.ReadOnly = true;
            this.txtPercentualCadaElevadorF.Size = new System.Drawing.Size(183, 28);
            this.txtPercentualCadaElevadorF.TabIndex = 19;
            // 
            // lblInfoCargaJsonInterno_Desafio
            // 
            this.lblInfoCargaJsonInterno_Desafio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCargaJsonInterno_Desafio.ForeColor = System.Drawing.Color.Red;
            this.lblInfoCargaJsonInterno_Desafio.Location = new System.Drawing.Point(124, 13);
            this.lblInfoCargaJsonInterno_Desafio.Name = "lblInfoCargaJsonInterno_Desafio";
            this.lblInfoCargaJsonInterno_Desafio.Size = new System.Drawing.Size(593, 24);
            this.lblInfoCargaJsonInterno_Desafio.TabIndex = 20;
            this.lblInfoCargaJsonInterno_Desafio.Text = "Estatísticas do Prédio 99a da Tecnopuc (16 andares e 5 elevadores: A, B, C, D e E" +
    ")";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(488, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 53);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estatísticas a partir de um Json externo (Gerado por outro sistema - mesmo layout" +
    ")";
            // 
            // FrmTelaEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 619);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmTelaEstatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle dos Elevadores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLerJSON;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorA;
        private System.Windows.Forms.TextBox txtMaiorUtilizacaoConjuntoElevadores;
        private System.Windows.Forms.TextBox txtMenosFrequentadoMenorFluxo;
        private System.Windows.Forms.TextBox txtMaisFrequentadoMaiorFluxo;
        private System.Windows.Forms.TextBox txtMenosUtilizado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutrosMenosUtilizados;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorE;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorD;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorC;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorB;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnJsonService;
        private System.Windows.Forms.TextBox txtPercentualCadaElevadorF;
        private System.Windows.Forms.Label lblInfoCargaJsonInterno_Desafio;
        private System.Windows.Forms.Label label8;
    }
}

