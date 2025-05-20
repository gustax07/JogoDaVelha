namespace JogoDaVelha
{
    partial class Form1
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibTitulo = new System.Windows.Forms.PictureBox();
            this.pibJogo = new System.Windows.Forms.PictureBox();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.ImageKey = "(nenhum/a)";
            this.btnFechar.Location = new System.Drawing.Point(466, 403);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 29);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::JogoDaVelha.Properties.Resources.reset;
            this.pictureBox1.Location = new System.Drawing.Point(436, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pibTitulo
            // 
            this.pibTitulo.Image = global::JogoDaVelha.Properties.Resources.tttmarqlrg;
            this.pibTitulo.Location = new System.Drawing.Point(134, 3);
            this.pibTitulo.Name = "pibTitulo";
            this.pibTitulo.Size = new System.Drawing.Size(286, 110);
            this.pibTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTitulo.TabIndex = 2;
            this.pibTitulo.TabStop = false;
            // 
            // pibJogo
            // 
            this.pibJogo.Image = global::JogoDaVelha.Properties.Resources.velha;
            this.pibJogo.Location = new System.Drawing.Point(54, 173);
            this.pibJogo.Name = "pibJogo";
            this.pibJogo.Size = new System.Drawing.Size(460, 299);
            this.pibJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibJogo.TabIndex = 0;
            this.pibJogo.TabStop = false;
            // 
            // btn11
            // 
            this.btn11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(110, 185);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(86, 69);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn12
            // 
            this.btn12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn12.FlatAppearance.BorderSize = 0;
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(224, 185);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(86, 69);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn13
            // 
            this.btn13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn13.FlatAppearance.BorderSize = 0;
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(339, 185);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(86, 69);
            this.btn13.TabIndex = 6;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn21
            // 
            this.btn21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn21.FlatAppearance.BorderSize = 0;
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(110, 273);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(86, 69);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn22
            // 
            this.btn22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn22.FlatAppearance.BorderSize = 0;
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(224, 273);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(86, 69);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn23
            // 
            this.btn23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn23.FlatAppearance.BorderSize = 0;
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(339, 273);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(86, 69);
            this.btn23.TabIndex = 9;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn31
            // 
            this.btn31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn31.FlatAppearance.BorderSize = 0;
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(110, 363);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(86, 69);
            this.btn31.TabIndex = 10;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn32
            // 
            this.btn32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn32.FlatAppearance.BorderSize = 0;
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(224, 364);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(86, 69);
            this.btn32.TabIndex = 11;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn33
            // 
            this.btn33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn33.FlatAppearance.BorderSize = 0;
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(339, 364);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(86, 69);
            this.btn33.TabIndex = 12;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(176, 126);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(174, 32);
            this.lblinfo.TabIndex = 13;
            this.lblinfo.Text = "É a Vez do X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(565, 444);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pibTitulo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pibJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibJogo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pibTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label lblinfo;
    }
}

