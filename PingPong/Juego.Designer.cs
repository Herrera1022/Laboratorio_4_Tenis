namespace PingPong
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            this.raquetaIzq = new System.Windows.Forms.Button();
            this.raquetaDer = new System.Windows.Forms.Button();
            this.pelota = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // raquetaIzq
            // 
            this.raquetaIzq.BackColor = System.Drawing.Color.White;
            this.raquetaIzq.Location = new System.Drawing.Point(12, 75);
            this.raquetaIzq.Name = "raquetaIzq";
            this.raquetaIzq.Size = new System.Drawing.Size(20, 100);
            this.raquetaIzq.TabIndex = 0;
            this.raquetaIzq.TabStop = false;
            this.raquetaIzq.UseVisualStyleBackColor = false;
            // 
            // raquetaDer
            // 
            this.raquetaDer.BackColor = System.Drawing.Color.White;
            this.raquetaDer.Location = new System.Drawing.Point(1022, 103);
            this.raquetaDer.Name = "raquetaDer";
            this.raquetaDer.Size = new System.Drawing.Size(20, 100);
            this.raquetaDer.TabIndex = 1;
            this.raquetaDer.TabStop = false;
            this.raquetaDer.UseVisualStyleBackColor = false;
            // 
            // pelota
            // 
            this.pelota.Image = global::PingPong.Properties.Resources.pelota;
            this.pelota.Location = new System.Drawing.Point(388, 173);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(30, 30);
            this.pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pelota.TabIndex = 2;
            this.pelota.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jugador 1";
            // 
            // lblJugador1
            // 
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.ForeColor = System.Drawing.Color.Black;
            this.lblJugador1.Location = new System.Drawing.Point(314, 491);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(18, 20);
            this.lblJugador1.TabIndex = 4;
            this.lblJugador1.Text = "0";
            // 
            // lblJugador2
            // 
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.ForeColor = System.Drawing.Color.Black;
            this.lblJugador2.Location = new System.Drawing.Point(774, 491);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(18, 20);
            this.lblJugador2.TabIndex = 5;
            this.lblJugador2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(659, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jugador 2";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1054, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.raquetaDer);
            this.Controls.Add(this.raquetaIzq);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Juego_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raquetaIzq;
        private System.Windows.Forms.Button raquetaDer;
        private System.Windows.Forms.PictureBox pelota;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Label label4;
    }
}