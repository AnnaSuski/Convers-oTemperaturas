namespace Conversaodetemperatura
{
    partial class form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.gbfrom = new System.Windows.Forms.GroupBox();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.origem = new System.Windows.Forms.Label();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.destino = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.gbfrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbfrom
            // 
            this.gbfrom.Controls.Add(this.rbFromK);
            this.gbfrom.Controls.Add(this.rbFromF);
            this.gbfrom.Controls.Add(this.rbFromC);
            this.gbfrom.Location = new System.Drawing.Point(20, 55);
            this.gbfrom.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbfrom.Name = "gbfrom";
            this.gbfrom.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbfrom.Size = new System.Drawing.Size(200, 168);
            this.gbfrom.TabIndex = 0;
            this.gbfrom.TabStop = false;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromC.Location = new System.Drawing.Point(16, 29);
            this.rbFromC.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(97, 25);
            this.rbFromC.TabIndex = 1;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "Celsius";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromF.Location = new System.Drawing.Point(16, 68);
            this.rbFromF.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(131, 25);
            this.rbFromF.TabIndex = 1;
            this.rbFromF.Text = "Fahrenheit";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFromK.Location = new System.Drawing.Point(16, 111);
            this.rbFromK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(88, 25);
            this.rbFromK.TabIndex = 1;
            this.rbFromK.Text = "Kelvin";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // origem
            // 
            this.origem.BackColor = System.Drawing.Color.White;
            this.origem.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origem.ForeColor = System.Drawing.Color.LightCoral;
            this.origem.Location = new System.Drawing.Point(17, 18);
            this.origem.Name = "origem";
            this.origem.Size = new System.Drawing.Size(203, 36);
            this.origem.TabIndex = 1;
            this.origem.Text = "Origem";
            this.origem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.rbToK);
            this.gbTo.Controls.Add(this.rbToF);
            this.gbTo.Controls.Add(this.rbToC);
            this.gbTo.Location = new System.Drawing.Point(21, 285);
            this.gbTo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbTo.Name = "gbTo";
            this.gbTo.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbTo.Size = new System.Drawing.Size(200, 168);
            this.gbTo.TabIndex = 0;
            this.gbTo.TabStop = false;
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToK.Location = new System.Drawing.Point(16, 111);
            this.rbToK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(88, 25);
            this.rbToK.TabIndex = 1;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "Kelvin";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToF.Location = new System.Drawing.Point(16, 68);
            this.rbToF.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(131, 25);
            this.rbToF.TabIndex = 1;
            this.rbToF.Text = "Fahrenheit";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbToC.Location = new System.Drawing.Point(16, 29);
            this.rbToC.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(97, 25);
            this.rbToC.TabIndex = 1;
            this.rbToC.Text = "Celsius";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // destino
            // 
            this.destino.BackColor = System.Drawing.Color.White;
            this.destino.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino.ForeColor = System.Drawing.Color.LightCoral;
            this.destino.Location = new System.Drawing.Point(18, 248);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(203, 36);
            this.destino.TabIndex = 1;
            this.destino.Text = "Destino";
            this.destino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatura
            // 
            this.temperatura.BackColor = System.Drawing.Color.White;
            this.temperatura.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatura.ForeColor = System.Drawing.Color.LightCoral;
            this.temperatura.Location = new System.Drawing.Point(245, 18);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(203, 36);
            this.temperatura.TabIndex = 1;
            this.temperatura.Text = "Temperatura:";
            this.temperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(244, 60);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(205, 34);
            this.txtTemperatura.TabIndex = 2;
            this.txtTemperatura.Text = "0";
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.White;
            this.btnConverter.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.LightCoral;
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(244, 97);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(204, 126);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.White;
            this.lbResposta.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.LightCoral;
            this.lbResposta.Location = new System.Drawing.Point(246, 248);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(203, 205);
            this.lbResposta.TabIndex = 1;
            this.lbResposta.Text = "Resposta:";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(475, 471);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.origem);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbfrom);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gbfrom.ResumeLayout(false);
            this.gbfrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfrom;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.Label origem;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.Label destino;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lbResposta;
    }
}

