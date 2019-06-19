namespace bubble
{
    partial class Starting
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
            this.imgGore = new System.Windows.Forms.PictureBox();
            this.imgDesno = new System.Windows.Forms.PictureBox();
            this.imgLevo = new System.Windows.Forms.PictureBox();
            this.lbShoot = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.lbLeft = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnControles = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLevo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGore
            // 
            this.imgGore.BackColor = System.Drawing.Color.Transparent;
            this.imgGore.BackgroundImage = global::bubble.Properties.Resources.keyUpTransparent;
            this.imgGore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgGore.Location = new System.Drawing.Point(283, 200);
            this.imgGore.Name = "imgGore";
            this.imgGore.Size = new System.Drawing.Size(50, 50);
            this.imgGore.TabIndex = 19;
            this.imgGore.TabStop = false;
            this.imgGore.Visible = false;
            // 
            // imgDesno
            // 
            this.imgDesno.BackColor = System.Drawing.Color.Transparent;
            this.imgDesno.BackgroundImage = global::bubble.Properties.Resources.keyRightTransparent;
            this.imgDesno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDesno.Location = new System.Drawing.Point(283, 126);
            this.imgDesno.Name = "imgDesno";
            this.imgDesno.Size = new System.Drawing.Size(50, 50);
            this.imgDesno.TabIndex = 18;
            this.imgDesno.TabStop = false;
            this.imgDesno.Visible = false;
            // 
            // imgLevo
            // 
            this.imgLevo.BackColor = System.Drawing.Color.Transparent;
            this.imgLevo.BackgroundImage = global::bubble.Properties.Resources.KeyLeftTransparent;
            this.imgLevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLevo.Location = new System.Drawing.Point(283, 53);
            this.imgLevo.Name = "imgLevo";
            this.imgLevo.Size = new System.Drawing.Size(50, 50);
            this.imgLevo.TabIndex = 17;
            this.imgLevo.TabStop = false;
            this.imgLevo.Visible = false;
            // 
            // lbShoot
            // 
            this.lbShoot.AutoSize = true;
            this.lbShoot.BackColor = System.Drawing.Color.Transparent;
            this.lbShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShoot.ForeColor = System.Drawing.Color.Navy;
            this.lbShoot.Location = new System.Drawing.Point(89, 209);
            this.lbShoot.Name = "lbShoot";
            this.lbShoot.Size = new System.Drawing.Size(81, 29);
            this.lbShoot.TabIndex = 16;
            this.lbShoot.Text = "Shoot";
            this.lbShoot.Visible = false;
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.BackColor = System.Drawing.Color.Transparent;
            this.lbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.ForeColor = System.Drawing.Color.Navy;
            this.lbRight.Location = new System.Drawing.Point(89, 136);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(144, 29);
            this.lbRight.TabIndex = 15;
            this.lbRight.Text = "Move Right";
            this.lbRight.Visible = false;
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.BackColor = System.Drawing.Color.Transparent;
            this.lbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.ForeColor = System.Drawing.Color.Navy;
            this.lbLeft.Location = new System.Drawing.Point(89, 63);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(126, 29);
            this.lbLeft.TabIndex = 14;
            this.lbLeft.Text = "Move Left";
            this.lbLeft.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Navy;
            this.btnBack.Location = new System.Drawing.Point(520, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(244, 58);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Navy;
            this.btnExit.Location = new System.Drawing.Point(37, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 58);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnControles
            // 
            this.btnControles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControles.ForeColor = System.Drawing.Color.Navy;
            this.btnControles.Location = new System.Drawing.Point(37, 165);
            this.btnControles.Name = "btnControles";
            this.btnControles.Size = new System.Drawing.Size(244, 58);
            this.btnControles.TabIndex = 11;
            this.btnControles.Text = "Controles";
            this.btnControles.UseVisualStyleBackColor = false;
            this.btnControles.Click += new System.EventHandler(this.btnControles_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewGame.CausesValidation = false;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Navy;
            this.btnNewGame.Location = new System.Drawing.Point(37, 51);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(244, 58);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bubble.Properties.Resources.StartBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgGore);
            this.Controls.Add(this.imgDesno);
            this.Controls.Add(this.imgLevo);
            this.Controls.Add(this.lbShoot);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnControles);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Starting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting";
            ((System.ComponentModel.ISupportInitialize)(this.imgGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGore;
        private System.Windows.Forms.PictureBox imgDesno;
        private System.Windows.Forms.PictureBox imgLevo;
        private System.Windows.Forms.Label lbShoot;
        private System.Windows.Forms.Label lbRight;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnControles;
        private System.Windows.Forms.Button btnNewGame;
    }
}